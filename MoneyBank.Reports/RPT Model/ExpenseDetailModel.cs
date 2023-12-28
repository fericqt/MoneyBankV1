using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class ExpenseDetailModel {
        public int IdTrack { get; set; }
        public DateTime DateReference { get; set; }
        public string ExpenseTransNo { get; set; }
        public string ExpenseName { get; set; }
        public decimal ExpenseAmount { get; set; }
        public int ExpenseQuantity { get; set; }
        public string Remarks { get; set; }
        public decimal ExpenseTotal { get; set; }
    }
}
