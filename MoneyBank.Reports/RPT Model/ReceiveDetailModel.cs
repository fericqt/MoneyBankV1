using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class ReceiveDetailModel {
        public int IdTrack { get; set; }
        public DateTime DateReference { get; set; }
        public string ReceiveTransNo { get; set; }
        public string ReceiveItemName { get; set; }
        public decimal ReceiveAmount { get; set; }
        public int ReceiveQuantity { get; set; }
        public string Remarks { get; set; }
        public decimal ReceiveAmountTotal { get; set; }
    }
}
