using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.Entity;
using MoneyBank.EntityData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    public partial class ManageLogin : MyManageFormBase {

        UserDTO myDTO = new UserDTO();

        public ManageLogin() {
            InitializeComponent();
            CurrentFormMode = FormMode.Add;
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
            }
            userDTOBindingSource.DataSource = myDTO;
       }
        protected override bool OnSaveData() {
            using (var ex = new moneybankEntities()) {
                var tbl = ex.tblusers.FirstOrDefault(c => c.Username == myDTO.Username && c.Password == myDTO.Password);
                if (tbl != null) {
                    var tblv = new VersionData(ex).GetById(1);
                    string[] parts = tblv.Version.Split('.');
                    string vResult = string.Join(".", parts.Select(p => int.Parse(p).ToString()));
                    //
                    if (CStaticVariable.Version != vResult)
                    {
                        CShowMessage.Info("New version is available!");
                        return false;
                    }
                    CStaticVariable.Username = tbl.Username;
                    CStaticVariable.UserLevel = tbl.UserLevel;
                    CStaticVariable.UserID = tbl.UserID;
                    //
                    tbl.DateLastLogin = DateTime.Now;
                    ex.SaveChanges();
                    return true;
                } else {
                    CShowMessage.Warning("Username & Password does not match!", "Warning");
                    return false;
                }
            }
        }
        protected override bool OnSaveNewData() {
            return new FormLayer.ManageForm().ManageUser("", FormMode.Add);
        }
        protected override void InitializeKeyboardShortcuts() {
            keyboardShortcuts[Keys.F1] = ConnectDB; 
        }
        private void ConnectDB() {
            CConf.ConnectToDatabase();
        }
    }
}
