using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ReceiveDetailDTO : CValidator {
        public int IdTrack { get; set; }
        public string TransNo { get; set; }
        public string Description { get; set; }
        public decimal Amount => Price * Qty;
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string ReceiveType { get; set; }
        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
