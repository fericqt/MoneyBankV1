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
    public partial class FrmExpense : MyFormListWithSearchBase {
        public FrmExpense() {
            InitializeComponent();
        }
        protected override void RefreshData() {
            using (var data = new ExpenseData()) {
                data.LoadList(dgvExpense, SearchTextBox.Text);
            }
        }
        protected override bool AddNewItem() {
            return new FormLayer.ManageForm().ManageExpense("", FerPROJ.Design.Forms.FrmManage.FormMode.Add);
        }
        protected override bool DeleteItem() {
            if(dgvExpense.GetSelectedValue(expenseTransNoDataGridViewTextBoxColumn.Index, out string sout)) {
                using (var data = new ExpenseData()) {
                    data.Delete(sout);
                    return true;
                }
            }return false;
        }
    }
}
