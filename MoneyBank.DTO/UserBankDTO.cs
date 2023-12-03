using FerPROJ.DBHelper.Class;
using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class UserBankDTO : CValidator {
        public int IdTrack { get; set; }

        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string UserId { get; set; }

        public string BankName { get; set; }

        public string BankAccountNo { get; set; } = CGet.RandomBankNo();

        public string BankType { get; set; }

        public override bool DataValidation() {
            if (Error != null) {
                return false;
            }
            return true;
        }
    }
}
