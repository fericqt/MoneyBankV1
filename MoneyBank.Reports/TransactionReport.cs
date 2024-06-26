﻿using CrystalDecisions.CrystalReports.Engine;
using FerPROJ.DBHelper.CRUD;
using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
using MoneyBank.Reports.RPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports {
    public class TransactionReport {

        private delegate ReportDocument MyFunction(string transNo);
        private Dictionary<ReportList, MyFunction> reportFunctions;
        public TransactionReport() {
            reportFunctions = new Dictionary<ReportList, MyFunction>();
            reportFunctions.Add(ReportList.ReceiveTransaction, ReceiveTransaction);
            reportFunctions.Add(ReportList.ExpenseTransaction, ExpenseTransaction);
        }
        public enum ReportList {
            ReceiveTransaction,
            ExpenseTransaction
        }

        public void PreviewReport(ReportList reportType, string transNo) {
            ReportDocument report = GetReport(reportType, transNo);
            if (report != null) {
                CReport.GenerateReport(report);
            }
        }

        private ReportDocument GetReport(ReportList rpt, string transNo) {
            FrmSplasherReport.ShowSplash();
            return reportFunctions[rpt](transNo);
        }
        private ReportDocument ExpenseTransaction(string transNo) {
            //
            string sSelect = $"SELECT * FROM tblexpense tblr INNER JOIN tbluserbank tblu ON tblr.BankAccountNo = tblu.BankAccountNo WHERE tblr.TransNo = '{transNo}'";
            string sSelectD = $"SELECT * FROM tblexpensedetails WHERE TransNo = '{transNo}'";
            //
            var rpt = new crExpense();
            rpt.Database.Tables[0].SetDataSource(new Conn().GetDataTable(sSelect));
            rpt.Database.Tables[1].SetDataSource(new Conn().GetDataTable(sSelectD));
            //
            return rpt;
        }
        private ReportDocument ReceiveTransaction(string transNo) {
            //
            string sSelect = $"SELECT * FROM tblreceive tblr INNER JOIN tbluserbank tblu ON tblr.BankAccountNo = tblu.BankAccountNo WHERE tblr.TransNo = '{transNo}'";
            string sSelectD = $"SELECT * FROM tblreceivedetails WHERE TransNo = '{transNo}'";
            //
            var rpt = new crReceive();
            rpt.Database.Tables[0].SetDataSource(new Conn().GetDataTable(sSelect));
            rpt.Database.Tables[1].SetDataSource(new Conn().GetDataTable(sSelectD));
            //
            return rpt;
        }
    }
}
