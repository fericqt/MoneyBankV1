using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class ExpenseDetailModel {
        public int IdTrack { get; set; }
        public string TransNo { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public string ExpenseType { get; set; }
    }
}
