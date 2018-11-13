using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace scaner
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Int32 orderId;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 1)
            {
                Int32.TryParse(args[0], out orderId);
                Application.Run(new MainForm(orderId));
            }
            else
                MessageBox.Show("Программа должна быть вызвана из Texac", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
    }
}
