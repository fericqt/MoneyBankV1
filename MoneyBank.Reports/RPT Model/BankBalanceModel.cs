using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class BankBalanceModel {
        public int IdTrack { get; set; }
        public DateTime DateReference { get; set; }
        public string UserID { get; set; }
        public string BankAccountNo { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal AmountAdded { get; set; }
        public decimal AmountDeducted { get; set; }
        public decimal RemainingBalance { get; set; }
        public DateTime DateUpdated { get; set; }
        public string BankName { get; set; }
        public string TransNo { get; set; }
        public string ReferenceTransNo { get; set; }
        public string Description { get; set; }
        public decimal Added { get; set; }
        public decimal Deducted { get; set; }
        public decimal OldBalance { get; set; }
        public decimal NewBalance { get; set; }
        public string Remarks { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateLastLogin { get; set; }
        public string UserLevel { get; set; }
        public string FullName { get; set; }
    }
}
