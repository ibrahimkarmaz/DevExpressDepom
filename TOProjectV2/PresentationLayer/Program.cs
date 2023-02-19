using PresentationLayer.Reports;
using PresentationLayer.WinFormList;
using PresentationLayer.WinFormList.BankWF;
using PresentationLayer.WinFormList.BeginWF;
using PresentationLayer.WinFormList.BirthdayWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {//https://www.youtube.com/watch?v=SUXvAHw6osw
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdministratorWF());
        }
    }
}
