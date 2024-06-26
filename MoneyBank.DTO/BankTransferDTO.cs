﻿using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class BankTransferDTO : CValidator {

        public long IdTrack { get; set; }
        public string TransNo { get; set; }
        public string UserIDFrom { get; set; }
        public string BankAccountNoFrom { get; set; }
        public string UserIDTo { get; set; }
        public string BankAccountNoTo { get; set; }
        public string Remarks { get; set; }
        public decimal Amount { get; set; }
        public string Status => CEnum.Status.ACTIVE.ToString();
        public DateTime DateReference => DateTime.Now;
        public decimal RemainingBalance { get; set; }

        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
