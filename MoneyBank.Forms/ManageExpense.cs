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
    public partial class ManageExpense : MyManageFormBase {
        ExpenseDTO myDTO = new ExpenseDTO();
        public ManageExpense() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            LoadBank();
            switch (CurrentFormMode) {
                case FormMode.Add:
                    using (var data = new ExpenseData()) {
                        myDTO.ExpenseTransNo = data.GetNewID();
                    }
                    break;
                case FormMode.Update:
                    break;
            }
            expenseDetailDTOBindingSource.DataSource = myDTO.ExpenseList;
            expenseDTOBindingSource.DataSource = myDTO;
        }

        private void tsbAdd_Click(object sender, EventArgs e) {
            var item = new ExpenseDetailDTO();
            item.ExpenseTransNo = myDTO.ExpenseTransNo;
            if (new FormLayer.ManageForm().ManageExpenseDetails(item, FormMode.Add)) {
                myDTO.ExpenseList.Add(item);
            }
            Reset();

        }
        protected override bool OnUpdateData() {
            using (var data = new ExpenseData()) {
                data.UpdateDTO(myDTO);
                return true;
            }
        }
        protected override bool OnSaveData() {
            using (var data = new ExpenseData()) {
                data.SaveDTO(myDTO);
                return true;
            }
        }
        private void Reset() {
            expenseDTOBindingSource.ResetBindings(false);
            expenseDetailDTOBindingSource.ResetBindings(false);
        }

        private void llUserID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if(new FormLayer.ListForm().ListUsers(out string sout)) {
                myDTO.UserId = sout;
            }
            LoadBank();
            Reset();
        }
        private void LoadBank() {
            using (var data = new UserData()) {
                data.LoadComboBox(cmbBankAccount, myDTO.UserId);
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e) {
            var item = CDGVSetting.GetItemDTO<ExpenseDetailDTO>(dgvExpenseDetails);
            myDTO.ExpenseList.Remove(item);
            Reset();
        }
    }
}
