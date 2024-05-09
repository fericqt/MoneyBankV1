using CrystalDecisions.CrystalReports.Engine;
using FerPROJ.DBHelper.CRUD;
using FerPROJ.DBHelper.Query;
using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
using MoneyBank.Reports.RPT;
using MoneyBank.Reports.RPT_Criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBank.Reports {
    public class SummaryReport {
        private delegate ReportDocument MyFunction();
        private Dictionary<ReportList, MyFunction> reportFunctions;
        public SummaryReport() {
            reportFunctions = new Dictionary<ReportList, MyFunction>();
            reportFunctions.Add(ReportList.UserList, UserList);
            reportFunctions.Add(ReportList.BankList, BankList);
            reportFunctions.Add(ReportList.BankTransactionByBank, BankTransactionByBank);
            reportFunctions.Add(ReportList.BankBalanceByUserID, BankBalanceByUserID);
            reportFunctions.Add(ReportList.Expenses, Expenses);
            reportFunctions.Add(ReportList.Receives, Receives);
            reportFunctions.Add(ReportList.ExpensesByDate, ExpensesByDate);
            reportFunctions.Add(ReportList.ReceivesByDate, ReceivesByDate);
        }
        public enum ReportList {
            UserList,
            BankList,
            BankTransactionByBank,
            BankBalanceByUserID,
            Expenses,
            ExpensesByDate,
            Receives,
            ReceivesByDate
        }
        public void PreviewReport(ReportList reportType) {
            ReportDocument report = GetReport(reportType);
            if (report != null) {
                CReport.GenerateReport(report);
            }
        }

        private ReportDocument GetReport(ReportList reportType) {
            var result = reportFunctions[reportType];
            ReportDocument rpt1 = result();
            if (rpt1 != null) {
                FrmSplasherReport.ShowSplash();
            }
            return rpt1;
        }
        private ReportDocument UserList() {
            string sQuery = $"SELECT * FROM tbluser";
            var rpt = new crListOfUsers();
            rpt.SetDataSource(new Conn().GetDataTable(sQuery));
            return rpt;
        }
        private ReportDocument BankList() {
            string sQuery = $"SELECT * FROM tblbank";
            var rpt = new crBank();
            rpt.SetDataSource(new Conn().GetDataTable(sQuery));
            return rpt;
        }
        private ReportDocument BankTransactionByBank() {
            using (var frm = new ManageReportFilter()) {
                frm.ShowBank = true;
                frm.ShowUserID = true;
                frm.CurrentFormMode = FrmManage2.FormMode.Add;
                frm.ShowDialog();
                if (frm.CurrentFormResult) {
                    string sQuery = $"SELECT * FROM tbltransactions tblt INNER JOIN tbluserbank tblu ON tblt.BankAccountNo = tblu.BankAccountNo " +
                                    $"INNER JOIN tbluserbankaccount tblub ON tblub.BankAccountNo = tblu.BankAccountNo " +
                                    $"INNER JOIN tbluser tbl ON tbl.UserID = tblu.UserID AND tblt.BankAccountNo = '{frm.Manage_BankAccountNo}'";

                    var rpt = new crBankTransaction();
                    rpt.SetDataSource(new Conn().GetDataTable(sQuery));
                    return rpt;
                }
            }
            return null;
        }
        private ReportDocument BankBalanceByUserID() {
            using (var frm = new ManageReportFilter()) {
                frm.ShowUserID = true;
                frm.CurrentFormMode = FrmManage2.FormMode.Add;
                frm.ShowDialog();
                if (frm.CurrentFormResult) {
                    string sQuery = $"SELECT * FROM tbluser tu INNER JOIN viewbankbalance bb ON bb.UserID = tu.UserID " +
                                    $"INNER JOIN tbluserbankaccount tub ON tub.BankAccountNo = bb.BankAccountNo WHERE bb.UserID = '{frm.Manage_UserID}'";
                    //
                    var rpt = new crBankBalanceByUserID();
                    rpt.SetDataSource(new Conn().GetDataTable(sQuery));
                    return rpt;
                }
            }
            return null;
        }
        private ReportDocument Expenses() {
            string sQuery = $"SELECT * FROM tblexpense tble INNER JOIN tbluserbank tblu ON tble.BankAccountNo = tblu.BankAccountNo";
            string sQueryD = $"SELECT * FROM tblexpensedetails";
            //
            var rpt = new crExpenseSummary();
            rpt.SetDataSource(new Conn().GetDataTable(sQuery));
            rpt.OpenSubreport("1").SetDataSource(new Conn().GetDataTable(sQueryD));
            return rpt;
        }
        private ReportDocument ExpensesByDate() {
            using (var frm = new ManageReportFilter()) {
                frm.ShowDate = true;
                frm.CurrentFormMode = FrmManage2.FormMode.Add;
                frm.ShowDialog();
                if (frm.CurrentFormResult) {
                    string sQuery = $"SELECT * FROM tblexpense tble INNER JOIN tbluserbank tblu ON tble.BankAccountNo = tblu.BankAccountNo " +
                                    $"WHERE {MySQLQueryHelper.GetDateRange(frm.Manage_DateFrom, frm.Manage_DateTo, "tble.DateReference")}";
                    string sQueryD = $"SELECT * FROM tblexpensedetails";
                    //
                    var rpt = new crExpenseByDate();
                    rpt.SetDataSource(new Conn().GetDataTable(sQuery));
                    rpt.OpenSubreport("1").SetDataSource(new Conn().GetDataTable(sQueryD));
                    rpt.SetParameterValue("DateRange", MySQLQueryHelper.GetDateRangeWord(frm.Manage_DateFrom, frm.Manage_DateTo));
                    return rpt;
                }
            }
            return null;
        }
        private ReportDocument Receives() {
            string sQuery = $"SELECT * FROM tblreceive tble INNER JOIN tbluserbank tblu ON tble.BankAccountNo = tblu.BankAccountNo";
            string sQueryD = $"SELECT * FROM tblreceivedetails";
            //
            var rpt = new crReceiveSummary();
            rpt.SetDataSource(new Conn().GetDataTable(sQuery));
            rpt.OpenSubreport("1").SetDataSource(new Conn().GetDataTable(sQueryD));
            return rpt;
        }
        private ReportDocument ReceivesByDate() {
            using (var frm = new ManageReportFilter()) {
                frm.ShowDate = true;
                frm.CurrentFormMode = FrmManage2.FormMode.Add;
                frm.ShowDialog();
                if (frm.CurrentFormResult) {
                    string sQuery = $"SELECT * FROM tblreceive tble INNER JOIN tbluserbank tblu ON tble.BankAccountNo = tblu.BankAccountNo " +
                            $"WHERE {MySQLQueryHelper.GetDateRange(frm.Manage_DateFrom, frm.Manage_DateTo, "tble.DateReference")}";
                    string sQueryD = $"SELECT * FROM tblreceivedetails";
                    //
                    var rpt = new crReceiveByDate();
                    rpt.SetDataSource(new Conn().GetDataTable(sQuery));
                    rpt.OpenSubreport("1").SetDataSource(new Conn().GetDataTable(sQueryD));
                    rpt.SetParameterValue("DateRange", MySQLQueryHelper.GetDateRangeWord(frm.Manage_DateFrom, frm.Manage_DateTo));
                    return rpt;
                }
            }
            return null;
        }

    }
}
