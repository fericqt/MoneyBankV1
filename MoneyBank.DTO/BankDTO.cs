using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class BankDTO : CValidator {
        public int IdTrack { get; set; }

        public DateTime DateReference => DateTime.Now;
        [Required]
        public string BankName { get; set; }
        [Required]
        public string BankSwiftcode { get; set; }
        [Required]
        public string BankLocation { get; set; }
        [Required]
        public string BankProvider { get; set; }
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
