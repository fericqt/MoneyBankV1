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
    public partial class ManageBankTransfer : MyManageFormBase {
        BankTransferDTO myDTO = new BankTransferDTO();
        public ManageBankTransfer() {
            InitializeComponent();
            CurrentFormMode = FormMode.Add;
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
            }
            bankTransferDTOBindingSource.DataSource = myDTO;
        }

        private void llUserIDFrom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (new FormLayer.ListForm().ListUsers(out string sout)) {
                myDTO.UserIDFrom = sout;
                using (var data = new UserData()) {
                    data.LoadComboBox(bankAccountNoFromCComboBoxBasic, sout);
                }
                Reset();
            }
        }

        private void llUserIDTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (new FormLayer.ListForm().ListUsers(out string sout)) {
                myDTO.UserIDTo = sout;
                using (var data = new UserData()) {
                    data.LoadComboBox(bankAccountNoToCComboBoxBasic, sout);
                }
                Reset();
            }
        }
        private void Reset() {
            bankTransferDTOBindingSource.ResetBindings(false);
        }

        private void bankAccountNoFromCComboBoxBasic_SelectedIndexChanged(object sender, EventArgs e) {
            if(bankAccountNoFromCComboBoxBasic.SelectedIndex > -1) {
                using (var data = new UserData()) {
                    var tbl = data.GetById(myDTO.UserIDFrom).tbluserbankaccounts.FirstOrDefault(c=>c.BankAccountNo == bankAccountNoFromCComboBoxBasic.SelectedValue.ToString());
                    myDTO.RemainingBalance = (decimal)(tbl != null ? tbl.RemainingBalance : 0);
                }
            }
        }
        protected override bool OnSaveData() {
            using (var data = new BankData()) {
                data.BankTransfer(myDTO);
                return true;
            }
        }
    }
}
