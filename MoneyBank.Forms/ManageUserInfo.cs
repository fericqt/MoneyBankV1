using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
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
    public partial class ManageUserInfo : MyManageFormBase {
        public UserInformationDTO myDTO = new UserInformationDTO();
        public ManageUserInfo() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
            }
            userInformationDTOBindingSource.DataSource = myDTO;
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
