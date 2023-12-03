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
        }
        private void ucTransactionList_Load(object sender, EventArgs e) {
            using (var data = new TransactionData()) {
                data.LoadList(dgvTransaction);
            }
        }

        private void rsbRefresh_Click(object sender, EventArgs e) {
            ucTransactionList_Load(sender, e);  
        }
    }
}
