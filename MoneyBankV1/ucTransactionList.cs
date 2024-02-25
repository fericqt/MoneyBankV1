using FerPROJ.Design.Class;
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

namespace MoneyBankV2 {
    public partial class ucTransactionList : UserControl {
        public ucTransactionList() {
            InitializeComponent();          
            dgvTransaction.SetWrapMode(DataGridViewTriState.False);
            dgvTransaction.SetColumnSizing();
        }
        private void ucTransactionList_Load(object sender, EventArgs e) {
            RefreshData();
        }

        private void rsbRefresh_Click(object sender, EventArgs e) {
            RefreshData();
        }
        private void RefreshData() {
            using (var data = new TransactionData()) {
                data.LoadList(dgvTransaction, searchCTextBoxBasic.Text);
            }
        }
        private void RefreshDataSearch() {
            using (var data = new TransactionData()) {
                data.LoadList(dgvTransaction, dtpFrom.Value, dtpTo.Value, searchCTextBoxBasic.Text);
            }
        }
        private void RefreshDataDate() {
            using (var data = new TransactionData()) {
                data.LoadList(dgvTransaction, dtpFrom.Value, dtpTo.Value);
            }
        }

        private void searchCTextBoxBasic_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                RefreshDataSearch();
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e) {
            RefreshDataDate();
        }
    }
}
