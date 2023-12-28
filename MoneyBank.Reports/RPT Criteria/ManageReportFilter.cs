using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
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

namespace MoneyBank.Reports.RPT_Criteria {
    public partial class ManageReportFilter : FrmManage2 {

        public DateTime Manage_DateFrom;
        public DateTime Manage_DateTo;
        //
        public bool ShowDate;
        public bool ShowUserID;
        public bool ShowBank;
        //
        public string Manage_BankAccountNo;
        public string Manage_UserID;
        public ManageReportFilter() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch(CurrentFormMode) {
                case FormMode.Add:
                    if (ShowUserID) {
                        using (var data = new UserData()) {
                            data.LoadComboBox(cmbUsername);
                        }
                        pnlUsername.Visible = true;
                    }
                    if (ShowBank) {
                        using (var data = new UserData()) {
                            data.LoadComboBox(cmbBank, cmbUsername.Text);
                        }
                        pnlUsername.Visible = true;
                    }
                    if (ShowDate) {
                        pnlDateRange.Visible = true;
                    }
                    break;
            }
        }
        protected override bool OnSaveData() {
            if (ShowDate) {
                Manage_DateFrom = dtpDateF.Value;
                Manage_DateTo = dtpDateT.Value;
            }
            if (ShowBank) {
                Manage_BankAccountNo = cmbBankUser.SelectedValue.ToString();
            }
            if (ShowUserID) {
                Manage_UserID = cmbUsername.Text;
            }
            return true;
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbUsername.SelectedIndex > -1) {
                using (var data = new UserData()) {
                    data.LoadComboBox(cmbBankUser, cmbUsername.Text);
                }
            }
        }
    }
}
