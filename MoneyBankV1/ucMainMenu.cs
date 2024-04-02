using FerPROJ.DBHelper.Generate;
using MoneyBank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBankV1 {
    public partial class ucMainMenu : UserControl {
        public ucMainMenu() {
            InitializeComponent();
        }

        private void LnkLblManageUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListUsers(out string sout);
        }

        private void LnkLblReceiveTypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListReceiveType();
        }

        private void LnkLblReceiveTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListReceive();
        }

        private void LnkLblExpenseType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListExpenseType();
        }

        private void LnkLblExpenseTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListExpense();
        }

        private void LnkLblBankType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListBanks();
        }

        private void LnkLblBankTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ManageForm().ManageBankTransfer();
        }

        private void LnkLblBankAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new FormLayer.ListForm().ListUsers(out string sout);
        }

        private void LnkLblCreateDatabaseClass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var frm = new ManageCreateTableClass()) {
                frm.ShowDialog();
            }
        }

        private void LnkLblVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormLayer.ManageForm().ManageVersion();
        }
    }
}
