using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ReceiveDetailDTO : CValidator {
        public int IdTrack { get; set; }

        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string ReceiveTransNo { get; set; }

        public string ReceiveItemName { get; set; }

        public decimal ReceiveAmount { get; set; } = 0;

        public int ReceiveQuantity { get; set; } = 0;

        public string Remarks { get; set; }

        public decimal ReceiveAmountTotal => ReceiveQuantity * ReceiveAmount;
        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
