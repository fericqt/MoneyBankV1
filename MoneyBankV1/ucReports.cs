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
            reportListBox.Items.Add("--USERS--");
            reportListBox.Items.Add("Registered Users");
            reportListBox.Items.Add(" ");
            reportListBox.Items.Add("--BANK--");
            reportListBox.Items.Add("Registered Banks");
            reportListBox.Items.Add("Bank Transaction By Account");
            reportListBox.Items.Add("Bank Balance By UserID");
            reportListBox.Items.Add(" ");
            reportListBox.Items.Add("--EXPENSES--");
            reportListBox.Items.Add("Expenses");
            reportListBox.Items.Add("Expenses By Date");
            reportListBox.Items.Add(" ");
            reportListBox.Items.Add("--RECEIVES--");
            reportListBox.Items.Add("Receives");
            reportListBox.Items.Add("Receives By Date");
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
                case "Registered Banks":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.BankList);
                    break;
                case "Bank Balance By UserID":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.BankBalanceByUserID);
                    break;
                case "Expenses":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.Expenses);
                    break;
                case "Receives":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.Receives);
                    break;
                case "Expenses By Date":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.ExpensesByDate);
                    break;
                case "Receives By Date":
                    new SummaryReport().PreviewReport(SummaryReport.ReportList.ReceivesByDate);
                    break;
            }
        }
    }
}
