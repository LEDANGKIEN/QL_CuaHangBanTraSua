using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevExpress.Skins;
//using DevExpress.UserSkins.BonusSkins;
using GUI;
namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            Application.Run(new DangNhap());
        }

        public static object mainForm { get; set; }
    }
}
