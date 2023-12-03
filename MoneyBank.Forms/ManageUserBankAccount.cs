using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.EntityData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    public partial class ManageUserBankAccount : MyManageFormBase {
        public UserBankAccountDTO myDTO = new UserBankAccountDTO();
        public List<UserBankDTO> BankList = new List<UserBankDTO>();
        public ManageUserBankAccount() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    cmbBankAccount.FillComboBox("BankName", "BankAccountNo", BankList);
                    break;
            }
            userBankAccountDTOBindingSource.DataSource = myDTO;

        }
        protected override bool OnSaveData() {
            if (myDTO.DataValidation()) {
                return true;
            } else {
                CShowMessage.Warning(myDTO.Error, "Warning");
                return false;
            }
        }
    }
}
