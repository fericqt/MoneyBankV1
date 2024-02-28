using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO {
    public class ReceiveDTO : CValidator {
        public System.DateTime DateReference => DateTime.Now;
        public string UserID { get; set; }
        public string BankAccountNo { get; set; }
        public string TransNo { get; set; }
        public decimal TotalAmount => ReceiveList.Sum(c => c.Amount);
        public string Remarks { get; set; }
        //public string CancelledBy { get; set; }
        //public string CancelledDate { get; set; }
        //public string CancelledRemarks { get; set; }
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
