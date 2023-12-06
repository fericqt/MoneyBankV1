using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.Entity;
using MoneyBank.EntityData;
using System;

namespace MoneyBank.Forms {
    public partial class ManageUserBankInfo : MyManageFormBase {
        UserDTO myDTO = new UserDTO();
        public ManageUserBankInfo() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var data = new UserData()) {
                        var tbl = data.GetById(Manage_IdTrack);
                        //
                        myDTO = new CMapping<tbluser, UserDTO>().GetMappingResult(tbl);
                        myDTO.BankList = new CMappingList<tbluserbank, UserBankDTO>().GetMappingResultList(tbl.tbluserbanks);
                        myDTO.UserInfoList = new CMappingList<tbluserinformation, UserInformationDTO>().GetMappingResultList(tbl.tbluserinformations);
                        myDTO.BankAccountList = new CMappingList<tbluserbankaccount, UserBankAccountDTO>().GetMappingResultList(tbl.tbluserbankaccounts);
                    }
                    break;

            }
            userDTOBindingSource.DataSource = myDTO;
            userBankAccountDTOBindingSource.DataSource = myDTO.BankAccountList;
            userInformationDTOBindingSource.DataSource = myDTO.UserInfoList;
            userBankDTOBindingSource.DataSource = myDTO.BankList;
        }
        protected override bool OnUpdateData() {
            using (var data = new UserData()) {
                data.UpdateDTO(myDTO);
                return true;
            }
        }

        private void tsbAddBank_Click(object sender, EventArgs e) {
            var item = new UserBankDTO();
            if (new FormLayer.ManageForm().ManageUserBank(item, FormMode.Add)) {
                item.UserId = myDTO.UserId;
                myDTO.BankList.Add(item);
            }
            Reset();
        }

        private void tsbAddBankAccount_Click(object sender, EventArgs e) {
            var item = new UserBankAccountDTO();
            if (new FormLayer.ManageForm().ManageUserBankAccount(item, myDTO.BankList, FormMode.Add)) {
                item.UserId = myDTO.UserId;
                myDTO.BankAccountList.Add(item);
            }
            Reset();
        }

        private void tsbAddUserInfo_Click(object sender, EventArgs e) {
            var item = new UserInformationDTO();
            if (new FormLayer.ManageForm().ManageUserInfo(item, FormMode.Add)) {
                item.UserId = myDTO.UserId;
                myDTO.UserInfoList.Add(item);
            }
            Reset();
        }
        private void Reset() {
            userDTOBindingSource.ResetBindings(false);
            userBankAccountDTOBindingSource.ResetBindings(false);
            userInformationDTOBindingSource.ResetBindings(false);
            userBankDTOBindingSource.ResetBindings(false);
        }

        private void tsbRemoveBank_Click(object sender, EventArgs e) {
            var item = CDGVSetting.GetItemDTO<UserBankDTO>(dgvUserBank);
            myDTO.BankList.Remove(item);
            Reset();
        }

        private void tsbRemoveBankAccount_Click(object sender, EventArgs e) {
            var item = CDGVSetting.GetItemDTO<UserBankAccountDTO>(dgvUserBankAccount);
            myDTO.BankAccountList.Remove(item);
            Reset();
        }

        private void tsbRemoveUserInfo_Click(object sender, EventArgs e) {
            var item = CDGVSetting.GetItemDTO<UserInformationDTO>(dgvUserInfo);
            myDTO.UserInfoList.Remove(item);
            Reset();
        }
    }
}
