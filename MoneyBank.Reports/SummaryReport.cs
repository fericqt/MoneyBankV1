using CrystalDecisions.CrystalReports.Engine;
using FerPROJ.DBHelper.CRUD;
using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
using MoneyBank.Reports.RPT;
using MoneyBank.Reports.RPT_Criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        public enum ReportList {
            UserList,
            BankList,
            BankTransactionByBank,
            BankBalanceByUserID
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
                frm.ShowDialog();
                if (frm.CurrentFormResult) {
                    string sQuery = $"SELECT * FROM tbluser tu INNER JOIN viewbankbalance bb ON bb.UserID = tu.UserID " +
                                    $"INNER JOIN tbluserbankaccount tub ON tub.BankAccountNo = bb.BankAccountNo WHERE bb.UserID = '{frm.Manage_UserID}'";
                    //
                    var rpt = new crBankBalanceByUserID();
                    rpt.SetDataSource(new Conn().GetDataTable(sQuery));
                    return rpt;
                }
            }return null;
        }

    }
}
