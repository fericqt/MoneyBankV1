//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyBank.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblbanktransfer
    {
        public long IdTrack { get; set; }
        public string TransNo { get; set; }
        public string UserIDFrom { get; set; }
        public string BankAccountNoFrom { get; set; }
        public string UserIDTo { get; set; }
        public string BankAccountNoTo { get; set; }
        public string Remarks { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public System.DateTime DateReference { get; set; }
    }
}
