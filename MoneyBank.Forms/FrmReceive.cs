using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.EntityData;
using MoneyBank.Reports;
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
    public partial class FrmReceive : MyFormListWithSearchBase {
        public FrmReceive() {
            InitializeComponent();
        }
        protected override bool AddNewItem() {
            return new FormLayer.ManageForm().ManageReceive("", FerPROJ.Design.Forms.FrmManage.FormMode.Add);
        }
        protected override void RefreshData() {
            using (var data = new ReceiveData()) {
                data.LoadList(dgvReceive, dateFrom, dateTo, searchValue);
            }
        }
        protected override bool UpdateItem() {
            if(CDGVSetting.GetSelectedValue(dgvReceive, receiveTransNoDataGridViewTextBoxColumn.Index, out string sout)) {
                return new FormLayer.ManageForm().ManageReceive(sout, FerPROJ.Design.Forms.FrmManage.FormMode.Update);
            }
            return false;
        }
        protected override bool DeleteItem() {
            if (CDGVSetting.GetSelectedValue(dgvReceive, receiveTransNoDataGridViewTextBoxColumn.Index, out string sout)) {
                using (var data = new ReceiveData()) {
                    data.Delete(sout);
                    return true;
                }
            }
            return false;
        }
        protected override void ViewItem() {
            if (CDGVSetting.GetSelectedValue(dgvReceive, receiveTransNoDataGridViewTextBoxColumn.Index, out string sout)) {
                new TransactionReport().PreviewReport(TransactionReport.ReportList.ReceiveTransaction, sout);
            }
        }
    }
}
