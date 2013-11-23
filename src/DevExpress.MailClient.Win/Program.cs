using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using DevExpress.Data.Filtering;
using DevExpress.MailClient.Win.Forms;

namespace DevExpress.MailClient.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments) {
            DataHelper.ApplicationArguments = arguments;
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            SkinManager.EnableFormSkins();
            EnumProcessingHelper.RegisterEnum<TaskStatus>();

            SplashScreenManager.ShowForm(typeof(ssMain));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
