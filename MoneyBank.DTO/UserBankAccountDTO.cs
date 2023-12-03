using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class UserBankAccountDTO: CValidator {
        public int IdTrack { get; set; }

        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string UserId { get; set; }

        public string BankAccountNo { get; set; }

        public decimal CurrentBalance { get; set; } = 0;

        public decimal AmountAdded { get; set; } = 0;

        public decimal AmountDeducted { get; set; } = 0;

        public decimal RemainingBalance => CurrentBalance + AmountAdded + AmountDeducted;

        public DateTime? DateUpdated { get; set; } = DateTime.Now;

        public string BankName { get; set; }

        public override bool DataValidation() {
            if (Error != null) {
                return false;
            }
            return true;
        }
    }
}
