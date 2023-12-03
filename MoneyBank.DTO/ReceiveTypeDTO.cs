using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ReceiveTypeDTO : CValidator {
        public int IdTrack { get; set; }

        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string ReceiveNo { get; set; }

        public string ReceiveType { get; set; }
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
