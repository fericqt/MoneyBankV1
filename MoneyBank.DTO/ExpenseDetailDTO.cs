using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ExpenseDetailDTO : CValidator {
        public int IdTrack { get; set; }

        public DateTime DateReference { get; set; } = DateTime.Now;

        public string ExpenseTransNo { get; set; }

        public string ExpenseName { get; set; }

        public decimal ExpenseAmount { get; set; } = 0;

        public int ExpenseQuantity { get; set; } = 0;

        public string Remarks { get; set; }

        public decimal ExpenseTotal => (decimal)(ExpenseQuantity * ExpenseAmount);
        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
