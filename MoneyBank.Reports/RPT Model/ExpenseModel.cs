using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class ExpenseModel {
        public System.DateTime DateReference { get; set; }
        public string UserID { get; set; }
        public string TransNo { get; set; }
        public string BankAccountNo { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string CancelledBy { get; set; }
        public System.DateTime CancelledDate { get; set; }
        public string CancelledRemarks { get; set; }
    }
}
