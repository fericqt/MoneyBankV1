using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
using MoneyBank.Forms;
using MoneyBankV2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBankV1 {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new FormLayer.ManageForm().ManageLogin()) {
                CStaticVariable.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                //
                FrmSplasher.ShowSplash();
                Application.Run(new Main());
            }
        }
    }
}
