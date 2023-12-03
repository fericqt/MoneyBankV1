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

namespace MoneyBankV2 {
    public partial class ucManagement : UserControl {
        public ucManagement() {
            InitializeComponent();
        }

        private void btnBank_Click(object sender, EventArgs e) {
            new FormLayer.ListForm().ListBanks();
        }

        private void btnBankAccount_Click(object sender, EventArgs e) {
            new FormLayer.ListForm().ListUsers(out string sout);
        }

        private void btnExpenseType_Click(object sender, EventArgs e) {
            new FormLayer.ListForm().ListExpenseType();
        }

        private void btnReceiveType_Click(object sender, EventArgs e) {
            new FormLayer.ListForm().ListReceiveType();
        }

        private void btnManageExpenses_Click(object sender, EventArgs e) {
            new FormLayer.ListForm().ListExpense();
        }

        private void btnManageReceives_Click(object sender, EventArgs e) {
            new FormLayer.ListForm().ListReceive();
        }

    }
}
