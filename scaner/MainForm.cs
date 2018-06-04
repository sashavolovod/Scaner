using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using Npgsql;

namespace scaner
{
    public partial class MainForm : Form, IMessageFilter
    {
        private Int32 orderNumber;
        private string connStr = "Server=172.16.2.111;Port=5432;User Id=texac_admin;Password=123;Database=texac_db;";
        private int imageCount=0;


        private bool msgfilter;
        private Twain tw;

        BITMAPINFOHEADER bmi;
        Rectangle bmprect;
        IntPtr dibhand;
        IntPtr bmpptr;
        IntPtr pixptr;


        public MainForm(Int32 orderNumber)
        {
            InitializeComponent();
            this.orderNumber = orderNumber;
            tw = new Twain();
            tw.Init(this.Handle);

            loadImagesFromDb(orderNumber);
        }

        private void loadImagesFromDb(int orderId)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connStr);
            NpgsqlCommand command = new NpgsqlCommand("select image from images where order_id=" + orderId, conn);
            conn.Open();
            try
            {
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Byte[] bytes = (Byte[])dr["image"];
                    MemoryStream ms = new MemoryStream(bytes);
                    Image img = Image.FromStream(ms);
                    addImageToPicturebox(img);
                 }
            }
            finally
            {
                conn.Close();
            }
        }

        private void actSaveToDb(object sender, EventArgs e)
        {
            Image image;

            TabPage p = tcImeges.SelectedTab;
            if (p == null)
                return;

            if (p.Controls[0] is PictureBox)
            {
                image = (p.Controls[0] as PictureBox).Image;
            }
            else
            {
                MessageBox.Show("Нет изображения");
                return;
            }

            byte[] data;
            using(System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                data = stream.ToArray();
            }

            MemoryStream ms = new MemoryStream(data);
            Image img = Image.FromStream(ms);

            NpgsqlConnection conn = new NpgsqlConnection(connStr);
            NpgsqlCommand command = new NpgsqlCommand("insert into images(order_id, image) values(@order_id, @image)", conn);
            command.Parameters.AddWithValue("@order_id", orderNumber);
            command.Parameters.AddWithValue("@image", data);
            conn.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            btnSaveToDb.Enabled = false;
        }

        private void addImageToPicturebox(string imagePath)
        {
            addImageToPicturebox(Image.FromFile(imagePath));
        }

        private void addImageToPicturebox(Image img)
        {
            TabPage page = new TabPage();
            page.AutoScroll = true;
            page.Text = "Изображение " + (imageCount+1).ToString();
            page.Tag = "test";

            PictureBox pic = new PictureBox();

            pic.Image = img;
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            page.Controls.Add(pic);


            tcImeges.Controls.Add(page);
            tcImeges.SelectedTab = page;

            imageCount++;
            pic.MouseEnter += new EventHandler(pic_MouseEnter);
            MainForm_Resize(this, null);
        }

        void pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Parent.Focus();
        }

        private void actAddFromFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            dialog.Title = "Выбор изображения";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                addImageToPicturebox(dialog.FileName);
                btnSaveToDb.Enabled = true;
            }   
        }

        private void actAddImageFromScanner(object sender, EventArgs e)
        {
            if (!msgfilter)
            {
                this.Enabled = false;
                msgfilter = true;
                Application.AddMessageFilter(this);
            }
            tw.Acquire();

        }

        private void actExit(object sender, EventArgs e)
        {
            Close();
        }

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            TwainCommand cmd = tw.PassMessage(ref m);

            if (cmd == TwainCommand.Null)
                return false;

            if (cmd == TwainCommand.Not)
                return false;

            switch (cmd)
            {
                case TwainCommand.CloseRequest:
                    {
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.CloseOk:
                    {
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.DeviceEvent:
                    {
                        break;
                    }
                case TwainCommand.TransferReady:
                    {
                        ArrayList pics = tw.TransferPictures();
                        EndingScan();
                        tw.CloseSrc();

                        dibhand = (IntPtr)pics[0];
                        bmpptr = GlobalLock(dibhand);
                        pixptr = GetPixelInfo(bmpptr);


                        IntPtr img = IntPtr.Zero;
                        Guid clsid;
                        String filename = "temp.png";

                        if (!Gdip.GetCodecClsid(filename, out clsid))
                        {
                            return false;
                        }

                        int st = Gdip.GdipCreateBitmapFromGdiDib(bmpptr, pixptr, ref img);

                        if ((st != 0) || (img == IntPtr.Zero))
                        {
                            return false;
                        }

                        st = Gdip.GdipSaveImageToFile(img, filename, ref clsid, IntPtr.Zero);
                        Gdip.GdipDisposeImage(img);

                        addImageToPicturebox(filename);
                        btnSaveToDb.Enabled = true;

                        //pictureBox1.Image = Image.FromFile(filename);

                        /*
                        picnumber++;
                        for (int i = 0; i < pics.Count; i++)
                        {
                            
                            IntPtr img = (IntPtr)pics[i];
                        
                            PicForm newpic = new PicForm(img);
                            newpic.MdiParent = this;
                            int picnum = i + 1;
                            newpic.Text = "ScanPass" + picnumber.ToString() + "_Pic" + picnum.ToString();
                            newpic.Show();
                        
                        }
                        */

                        break;
                    }
            }

            return true;
        }

        protected IntPtr GetPixelInfo(IntPtr bmpptr)
        {
            bmi = new BITMAPINFOHEADER();
            Marshal.PtrToStructure(bmpptr, bmi);

            bmprect.X = bmprect.Y = 0;
            bmprect.Width = bmi.biWidth;
            bmprect.Height = bmi.biHeight;

            if (bmi.biSizeImage == 0)
                bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight;

            int p = bmi.biClrUsed;
            
            if ((p == 0) && (bmi.biBitCount <= 8))
                p = 1 << bmi.biBitCount;

            p = (p * 4) + bmi.biSize + (int)bmpptr;

            return (IntPtr)p;
        }

        private void EndingScan()
        {
            if (msgfilter)
            {
                Application.RemoveMessageFilter(this);
                msgfilter = false;
                this.Enabled = true;
                this.Activate();
            }
        }



        [DllImport("gdi32.dll", ExactSpelling = true)]
        internal static extern int SetDIBitsToDevice(IntPtr hdc, int xdst, int ydst,
                                                int width, int height, int xsrc, int ysrc, int start, int lines,
                                                IntPtr bitsptr, IntPtr bmiptr, int color);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GlobalLock(IntPtr handle);
        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GlobalFree(IntPtr handle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern void OutputDebugString(string outstr);

      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dibhand != IntPtr.Zero)
                {
                    GlobalFree(dibhand);
                    dibhand = IntPtr.Zero;
                }

                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        private void tabPage1_MouseEnter(object sender, EventArgs e)
        {
            tcImeges.Focus();
        }

        void pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                p.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                p.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            TabPage p = tcImeges.SelectedTab;
            if (p == null)
                return;




            if (p.Controls[0] is PictureBox)
            {
                int x, y;
                
                PictureBox pic = p.Controls[0] as PictureBox;
                Image img = pic.Image;
                x = img.Width > ClientSize.Width ? y = 0 : y = (ClientSize.Width / 2) - (img.Width / 2);
                y = img.Height > ClientSize.Height ? y = 0 : y = (ClientSize.Height / 2) - (img.Height / 2);

                pic.Location = new Point(x, y);

            }
        }

        private void tcImeges_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnSaveToDb.Enabled = false;
        }



    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal class BITMAPINFOHEADER
    {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public short biPlanes;
        public short biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int biClrImportant;
    }
}

