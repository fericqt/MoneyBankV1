using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class TransactionDTO : CValidator {
        public uint IdTrack { get; set; }

        public string TransNo { get; set; } 

        public string ReferenceTransNo { get; set; } 

        public string BankAccountNo { get; set; } 

        public string Description { get; set; } 
        public decimal Added { get; set; }

        public decimal Deducted { get; set; }

        public decimal OldBalance { get; set; }

        public decimal NewBalance { get; set; }

        public string Remarks { get; set; } 

        public DateTime DateReference { get; set; } = DateTime.Now;

        public string UserId { get; set; } 
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
