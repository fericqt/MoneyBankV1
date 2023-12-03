using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class BankTransferDTO : CValidator {

        public string UserIDFrom { get; set; }
        public string UserIDTo { get; set; }
        public string BankAccountNoFrom { get; set; }
        public string BankAccountNoTo { get; set; }
        public string Remarks { get; set; }
        public string DateReference { get; set; }
        public decimal Amount { get; set; }
        public decimal RemainingBalance { get; set; }

        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
