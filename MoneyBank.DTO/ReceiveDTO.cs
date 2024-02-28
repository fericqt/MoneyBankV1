using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ReceiveDTO : CValidator {
        public DateTime? DateReference { get; set; } = DateTime.Now;

        public string ReceiveTransNo { get; set; } 

        public string UserId { get; set; } = CStaticVariable.UserID;

        public string BankAccountNo { get; set; }

        public decimal TotalReceiveAmount => ReceiveList.Sum(c => c.ReceiveAmountTotal);
        public string Status => CEnum.Status.ACTIVE.ToString();

        public List<ReceiveDetailDTO> ReceiveList = new List<ReceiveDetailDTO>();

        public override bool DataValidation() {
            if(Error != null) {
                return false;
            }
            return true;
        }
    }
}
