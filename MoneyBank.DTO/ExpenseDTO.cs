using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ExpenseDTO : CValidator {
        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string UserId { get; set; } = CStaticVariable.UserID;

        public string ExpenseTransNo { get; set; } 

        public string BankAccountNo { get; set; }
        public string Status => CEnum.Status.ACTIVE.ToString();

        public decimal TotalExpenseAmount => ExpenseList.Sum(c=>c.ExpenseTotal);
        public List<ExpenseDetailDTO> ExpenseList = new List<ExpenseDetailDTO>();
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
