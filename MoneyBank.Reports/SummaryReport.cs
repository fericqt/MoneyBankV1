using CrystalDecisions.CrystalReports.Engine;
using FerPROJ.DBHelper.CRUD;
using FerPROJ.Design.Class;
using MoneyBank.Reports.RPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports
{
    public class SummaryReport
    {
        private delegate ReportDocument MyFunction();
        private Dictionary<ReportList, MyFunction> reportFunctions;
        public SummaryReport() {
            reportFunctions = new Dictionary<ReportList, MyFunction>();
            reportFunctions.Add(ReportList.UserList, UserList);
        }
        public enum ReportList {
            UserList,
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
            return rpt1;
        }
        private ReportDocument UserList() {
            string sQuery = $"SELECT * FROM tbluser";
            var rpt = new crListOfUsers();
            rpt.SetDataSource(new Conn().GetDataTable(sQuery));
            return rpt;
        }
    }
}
