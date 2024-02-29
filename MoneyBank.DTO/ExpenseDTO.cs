using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ExpenseDTO : CValidator {
        public System.DateTime DateReference => DateTime.Now;
        public string UserID { get; set; } = CStaticVariable.UserID;
        public string BankAccountNo { get; set; }
        public string TransNo { get; set; }
        public decimal TotalAmount => ExpenseList.Sum(c => c.Amount);
        [Required]
        public string Remarks { get; set; }
        //public string CancelledBy { get; set; }
        //public string CancelledDate { get; set; }
        //public string CancelledRemarks { get; set; }
        public string Status => CEnum.Status.ACTIVE.ToString();
        public List<ExpenseDetailDTO> ExpenseList = new List<ExpenseDetailDTO>();
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
