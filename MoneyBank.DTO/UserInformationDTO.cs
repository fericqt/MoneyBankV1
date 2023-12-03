using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class UserInformationDTO : CValidator {
        public int IdTrack { get; set; }
        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string UserId { get; set; }

        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }
        public string Relationship { get; set; } 

        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
