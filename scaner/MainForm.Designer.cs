namespace scaner
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddImageFromScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИзображениеИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFromScanner = new System.Windows.Forms.ToolStripButton();
            this.btnAddFromFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveToDb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.tcImeges = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сканировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзображениеToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьИзображениеToolStripMenuItem
            // 
            this.сохранитьИзображениеToolStripMenuItem.Name = "сохранитьИзображениеToolStripMenuItem";
            this.сохранитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сохранитьИзображениеToolStripMenuItem.Text = "Сохранить изображение";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.actExit);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddImageFromScanner,
            this.добавитьИзображениеИзФайлаToolStripMenuItem,
            this.miOptions});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // miAddImageFromScanner
            // 
            this.miAddImageFromScanner.Name = "miAddImageFromScanner";
            this.miAddImageFromScanner.Size = new System.Drawing.Size(280, 22);
            this.miAddImageFromScanner.Text = "Сканировать изображение";
            this.miAddImageFromScanner.Click += new System.EventHandler(this.actAddImageFromScanner);
            // 
            // добавитьИзображениеИзФайлаToolStripMenuItem
            // 
            this.добавитьИзображениеИзФайлаToolStripMenuItem.Name = "добавитьИзображениеИзФайлаToolStripMenuItem";
            this.добавитьИзображениеИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.добавитьИзображениеИзФайлаToolStripMenuItem.Text = "Добавить изображение  из файла";
            this.добавитьИзображениеИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.actAddFromFile);
            // 
            // miOptions
            // 
            this.miOptions.Name = "miOptions";
            this.miOptions.Size = new System.Drawing.Size(280, 22);
            this.miOptions.Text = "Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(161, 22);
            this.miAbout.Text = "О программе";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFromScanner,
            this.btnAddFromFile,
            this.btnSaveToDb,
            this.toolStripSeparator2,
            this.btnDeleteImage,
            this.toolStripSeparator3,
            this.btnSettings,
            this.toolStripSeparator4,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFromScanner
            // 
            this.btnAddFromScanner.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFromScanner.Image")));
            this.btnAddFromScanner.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddFromScanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFromScanner.Name = "btnAddFromScanner";
            this.btnAddFromScanner.Size = new System.Drawing.Size(106, 36);
            this.btnAddFromScanner.Text = "Со сканера";
            this.btnAddFromScanner.ToolTipText = "Сканировать изображение";
            this.btnAddFromScanner.Click += new System.EventHandler(this.actAddImageFromScanner);
            // 
            // btnAddFromFile
            // 
            this.btnAddFromFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFromFile.Image")));
            this.btnAddFromFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddFromFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFromFile.Name = "btnAddFromFile";
            this.btnAddFromFile.Size = new System.Drawing.Size(96, 36);
            this.btnAddFromFile.Text = "Из файла";
            this.btnAddFromFile.ToolTipText = "Добавить изображение из файла";
            this.btnAddFromFile.Click += new System.EventHandler(this.actAddFromFile);
            // 
            // btnSaveToDb
            // 
            this.btnSaveToDb.Enabled = false;
            this.btnSaveToDb.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDb.Image")));
            this.btnSaveToDb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveToDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveToDb.Name = "btnSaveToDb";
            this.btnSaveToDb.Size = new System.Drawing.Size(102, 36);
            this.btnSaveToDb.Text = "Сохранить";
            this.btnSaveToDb.ToolTipText = "Сохранить изображение в файл";
            this.btnSaveToDb.Click += new System.EventHandler(this.actSaveToDb);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Enabled = false;
            this.btnDeleteImage.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteImage.Image")));
            this.btnDeleteImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(89, 36);
            this.btnDeleteImage.Text = "Удалить";
            this.btnDeleteImage.ToolTipText = "Удалить изображение";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(36, 36);
            this.btnSettings.Text = "toolStripButton5";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(36, 36);
            this.btnAbout.Text = "toolStripButton6";
            // 
            // tcImeges
            // 
            this.tcImeges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcImeges.Location = new System.Drawing.Point(0, 63);
            this.tcImeges.Name = "tcImeges";
            this.tcImeges.SelectedIndex = 0;
            this.tcImeges.Size = new System.Drawing.Size(857, 423);
            this.tcImeges.TabIndex = 7;
            this.tcImeges.SelectedIndexChanged += new System.EventHandler(this.tcImeges_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 508);
            this.Controls.Add(this.tcImeges);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Просмотр и сканирование изображений";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAddImageFromScanner;
        private System.Windows.Forms.ToolStripMenuItem добавитьИзображениеИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOptions;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddFromScanner;
        private System.Windows.Forms.ToolStripButton btnAddFromFile;
        private System.Windows.Forms.ToolStripButton btnSaveToDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDeleteImage;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabControl tcImeges;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

