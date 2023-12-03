using FerPROJ.DBHelper.CRUD;
using MoneyBank.Base.Forms;
using MoneyBank.Entity;
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
    public partial class ManageReportFilter : MyManageFormBase {
        public string Manage_BankAccountNo;
        public ManageReportFilter() {
            InitializeComponent();
            CurrentFormMode = FormMode.Add;
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    using (var data = new UserData()) {
                        data.LoadComboBox(cmbUserID);
                    }
                    break;

            }
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbUserID.SelectedIndex > -1) {
                using (var data = new UserData()) {
                    data.LoadComboBox(cmbBankName, cmbUserID.Text);
                }
            }
        }
        protected override bool OnSaveData() {
            Manage_BankAccountNo = cmbBankName.SelectedValue.ToString();
            return true;
        }
    }
}
