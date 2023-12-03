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
    public partial class ManageUserBank : MyManageFormBase {
        public UserBankDTO myDTO = new UserBankDTO();
        public ManageUserBank() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            using (var data = new BankData()) {
                data.LoadComboBox(cmbBankName);
            }
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    break;
            }
            userBankDTOBindingSource.DataSource = myDTO;
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
