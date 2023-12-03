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
    public partial class FrmExpenseType : MyFormListWithSearchBase {
        public FrmExpenseType() {
            InitializeComponent();
        }
        protected override void RefreshData() {
            using (var data = new ExpenseTypeData()) {
                data.LoadList(dgvExpenseType, SearchTextBox.Text);
            }
        }
        protected override bool AddNewItem() {
            return new FormLayer.ManageForm().ManageExpenseType("", FerPROJ.Design.Forms.FrmManage.FormMode.Add);
        }
        protected override bool UpdateItem() {
            if (CDGVSetting.GetSelectedValue(dgvExpenseType, expenseNoDataGridViewTextBoxColumn.Index, out string sout)) {
                return new FormLayer.ManageForm().ManageExpenseType(sout, FerPROJ.Design.Forms.FrmManage.FormMode.Update);
            }
            return false;
        }
        protected override bool DeleteItem() {
            if (CDGVSetting.GetSelectedValue(dgvExpenseType, expenseNoDataGridViewTextBoxColumn.Index, out string sout)) {
                using (var data = new ExpenseTypeData()) {
                    data.Delete(sout);
                    return true;
                }
            }
            return false;
        }

    }
}
