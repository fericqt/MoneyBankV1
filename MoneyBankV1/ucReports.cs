using FerPROJ.Design.UC;
using MoneyBank.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBankV2 {
    public partial class ucReports : UCReportMain {
        public ucReports() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            reportListBox.Items.Add("Registered Users");
        }

        private void reportListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            GenerateReport();
        }
        private void GenerateReport() {
            switch (reportListBox.SelectedItem.ToString()) {
                case "Registered Users":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.UserList);
                    break;
            }
        }
    }
}
