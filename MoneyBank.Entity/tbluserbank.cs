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
    
    public partial class tbluserbank
    {
        public int IdTrack { get; set; }
        public Nullable<System.DateTime> DateReference { get; set; }
        public string UserID { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankType { get; set; }
    
        public virtual tbluser tbluser { get; set; }
    }
}
