using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
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
    public partial class FrmUsers : MyFormListWithSearchBase {
        public FrmUsers() {
            InitializeComponent();
        }
        protected override void RefreshData() {
            using (var data = new UserData()) {
                data.LoadList(dgvUsers);
            }
        }
        protected override bool UpdateItem() {
            if (CDGVSetting.GetSelectedValue(dgvUsers, userIdDataGridViewTextBoxColumn.Index, out string sout)) {
                return new FormLayer.ManageForm().ManageBankInfo(sout, FerPROJ.Design.Forms.FrmManage.FormMode.Update);
            }
            return false;
        }
        protected override bool DeleteItem() {
            if (CDGVSetting.GetSelectedValue(dgvUsers, userIdDataGridViewTextBoxColumn.Index, out string sout)) {
                using (var data = new UserData()) {
                    data.Delete(sout);
                    return true;
                }
            }
            return false;
        }
        protected override bool AddNewItem() {
            return new FormLayer.ManageForm().ManageUser("", FerPROJ.Design.Forms.FrmManage.FormMode.Add);
        }
        protected override bool GetSelectedData() {
            if (CDGVSetting.GetSelectedValue(dgvUsers, userIdDataGridViewTextBoxColumn.Index, out string sout)) {
                Form_IdTrack = sout;
                return true;
            }
            return false;
        }
    }
}
