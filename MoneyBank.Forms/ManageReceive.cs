using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.Entity;
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
    public partial class ManageReceive : MyManageFormBase {
        ReceiveDTO myDTO = new ReceiveDTO();
        public ManageReceive() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    using (var data = new ReceiveData()) {
                        myDTO.ReceiveTransNo = data.GetNewID();
                    }
                    LoadBank();
                    break;
                case FormMode.Update:
                    using (var data = new ReceiveData()) {
                        var tbl = data.GetById(Manage_IdTrack);
                        myDTO = new CMapping<tblreceive, ReceiveDTO>().GetMappingResult(tbl);
                        myDTO.ReceiveList = new CMappingList<tblreceivedetail, ReceiveDetailDTO>().GetMappingResultList(tbl.tblreceivedetails);
                    }
                    break;
            }
            receiveDTOBindingSource.DataSource = myDTO;
            receiveDetailDTOBindingSource.DataSource = myDTO.ReceiveList;
        }

        private void tsbAdd_Click(object sender, EventArgs e) {
            var item = new ReceiveDetailDTO();
            item.ReceiveTransNo = myDTO.ReceiveTransNo;
            if (new FormLayer.ManageForm().ManageReceiveDetails(item, FormMode.Add)) {
                myDTO.ReceiveList.Add(item);
            }
            Reset();
        }
        private void Reset() {
            receiveDTOBindingSource.ResetBindings(false);
            receiveDetailDTOBindingSource.ResetBindings(false);
        }
        protected override bool OnSaveData() {
            using (var data = new ReceiveData()) {
                data.SaveDTO(myDTO);
                new TransactionReport().PreviewReport(TransactionReport.ReportList.ReceiveTransaction, myDTO.ReceiveTransNo);
                return true;
            }
        }
        protected override bool OnUpdateData() {
            using (var data = new ReceiveData()) {
                data.UpdateDTO(myDTO);
                return true;
            }
        }

        private void llUserID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (new FormLayer.ListForm().ListUsers(out string sout)) {
                myDTO.UserId = sout;
            }
            LoadBank();
            Reset();
        }
        private void LoadBank() {
            using (var data = new UserData()) {
                data.LoadComboBox(cmbBank, myDTO.UserId);
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e) {
            var item = CDGVSetting.GetItemDTO<ReceiveDetailDTO>(dgvReceiveDetails);
            myDTO.ReceiveList.Remove(item);
            Reset();
        }
    }
}
