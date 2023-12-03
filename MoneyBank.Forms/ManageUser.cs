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
    public partial class ManageUser : MyManageFormBase {

        UserDTO myDTO = new UserDTO();

        public ManageUser() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            userLevelComboBox.FillComboBoxEnum<CEnum.UserLevel>();
            //
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
            }
            userDTOBindingSource.DataSource = myDTO;
        }

        protected override bool OnSaveData() {
            using (var data = new UserData()) {
                data.SaveDTO(myDTO);
                return true;
            }
        }
    }

}
