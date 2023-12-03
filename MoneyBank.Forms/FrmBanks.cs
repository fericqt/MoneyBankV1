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
    public partial class FrmBanks : MyFormListWithSearchBase {
        public FrmBanks() {
            InitializeComponent();
        }
        protected override void RefreshData() {
            using (var data = new BankData()) {
                data.LoadList(dgvBanks);
            }
        }
        protected override bool AddNewItem() {
            return new FormLayer.ManageForm().ManageBank("", FerPROJ.Design.Forms.FrmManage.FormMode.Add);

        }
        protected override bool UpdateItem() {
            if (CDGVSetting.GetSelectedValue(dgvBanks, bankSwiftcodeDataGridViewTextBoxColumn.Index, out string sout)) {
                return new FormLayer.ManageForm().ManageBank(sout, FerPROJ.Design.Forms.FrmManage.FormMode.Update);
            }return false;
        }
        protected override bool DeleteItem() {
            if (CDGVSetting.GetSelectedValue(dgvBanks, bankSwiftcodeDataGridViewTextBoxColumn.Index, out string sout)) {
                using (var data = new BankData()) {
                    data.Delete(sout);
                    return true;
                }
            }return false;
        }
    }
}
