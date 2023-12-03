using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    public class ReceiveModel {
        public DateTime DateReference { get; set; }
        public string ReceiveTransNo { get; set; }
        public string UserID { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }
        public string BankType { get; set; }
        public decimal TotalReceiveAmount { get; set; }
    }
}
