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
            reportListBox.Items.Add("****USER INFORMATIONS****");
            reportListBox.Items.Add(" ");
            reportListBox.Items.Add("Registered Users");
            reportListBox.Items.Add(" ");
            reportListBox.Items.Add("****ACCOUNTING INFORMATIONS****");
            reportListBox.Items.Add(" ");
            reportListBox.Items.Add("Registered Banks");
            reportListBox.Items.Add("Bank Transaction By Account");
        }

        private void reportListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            GenerateReport();
        }
        private void GenerateReport() {
            switch (reportListBox.SelectedItem.ToString()) {
                case "Registered Users":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.UserList);
                    break;
                case "Bank Transaction By Account":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.BankTransactionByBank);
                    break;
            }
        }
    }
}
