using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO
{
    public class UserDTO : CValidator
    {
        public DateTime? DateReference { get; set; } = DateTime.Now;
        [Required]
        public string Username { get; set; }
        [Required]

        public string Password { get; set; }

        public string UserId { get; set; } 

        public DateTime? DateLastLogin { get; set; } = DateTime.Now;
        [Required]
        public string UserLevel { get; set; }
        public string FullName { get; set; }
        public string Status => CEnum.Status.ACTIVE.ToString();

        public List<UserBankDTO> BankList = new List<UserBankDTO>();
        public List<UserInformationDTO> UserInfoList = new List<UserInformationDTO>();
        public List<UserBankAccountDTO> BankAccountList = new List<UserBankAccountDTO>();
        
        public override bool DataValidation()
        {
            throw new NotImplementedException();
        }
    }
}
