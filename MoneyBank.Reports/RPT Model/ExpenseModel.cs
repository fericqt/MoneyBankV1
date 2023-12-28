using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class ExpenseModel {
        public DateTime DateReference { get; set; }
        public string UserID { get; set; }
        public string ExpenseTransNo { get; set; }
        public string BankAccountNo { get; set; }
        public decimal TotalExpenseAmount { get; set; }
        public string BankName { get; set; }
        public string BankType { get; set; }
    }
}
