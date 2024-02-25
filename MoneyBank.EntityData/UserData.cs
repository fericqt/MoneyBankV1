using FerPROJ.DBHelper.Base;
using FerPROJ.DBHelper.CRUD;
using FerPROJ.Design.Class;
using FerPROJ.Design.Controls;
using FerPROJ.Design.Interface;
using MoneyBank.DTO;
using MoneyBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBank.EntityData {
    public class UserData : BaseDBEntity<moneybankEntities, Conn, UserDTO, string>, IEntityData<tbluser, string> {
        public UserData() {
        }

        public UserData(moneybankEntities ts) : base(ts) {
        }

        public UserData(Conn conn) : base(conn) {
        }

        public IEnumerable<tbluser> GetAll() {
            throw new NotImplementedException();
        }

        public tbluser GetById(string id) {
            return _ts.tblusers.FirstOrDefault(c => c.UserID == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("UID", _tableName);
        }
        public void LoadComboBox(ComboBox cmb) {
            _conn.FillComboBox(cmb, "UserID", $"SELECT * FROM tbluser");
        }
        public void LoadComboBox(ComboBox cmb, string id) {
            _conn.FillComboBox(cmb, "BankName", "BankAccountNo", $"SELECT * FROM tbluserbank WHERE UserID = '{id}'");
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<UserDTO>(SearchValue));
        }

        public void LoadList(DataGridView dgv, string id, string SearchValue = "%") {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string id, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            throw new NotImplementedException();
        }
        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo) {
            throw new NotImplementedException();
        }

        protected override void DeleteData(string id) {
            var tblu = GetById(id);
            var tblt = new TransactionData(_ts).GetAll(id);
            //
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    _ts.tblusers.Remove(tblu);
                    _ts.tbluserbankaccounts.RemoveRange(tblu.tbluserbankaccounts);
                    _ts.tbluserbanks.RemoveRange(tblu.tbluserbanks);
                    _ts.tbluserinformations.RemoveRange(tblu.tbluserinformations);
                    _ts.tbltransactions.RemoveRange(tblt);
                    _ts.SaveChanges();
                    trans.Commit();
                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }

        protected override void SaveData(UserDTO myDTO) {
            var tblu = new CMapping<UserDTO, tbluser>().GetMappingResult(myDTO);
            tblu.UserID = GetNewID();
            _ts.tblusers.Add(tblu);
            _ts.SaveChanges();
        }

        protected override void SetTables() {
            _tableName = "tbluser";
        }

        protected override void UpdateData(UserDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tblOld = GetById(myDTO.UserId);
                    var tblNew = new CMapping<UserDTO, tbluser>().GetMappingResult(myDTO);

                    if (myDTO.BankList.Count > 0) {
                        tblNew.tbluserbanks = new CMappingList<UserBankDTO, tbluserbank>().GetMappingResultList(myDTO.BankList);
                    }
                    if (myDTO.BankAccountList.Count > 0) {
                        tblNew.tbluserbankaccounts = new CMappingList<UserBankAccountDTO, tbluserbankaccount>().GetMappingResultList(myDTO.BankAccountList);
                        foreach (var item in myDTO.BankAccountList) {
                            AddBeginningBalance(myDTO, item);
                        }
                    }
                    if (myDTO.UserInfoList.Count > 0) {
                        tblNew.tbluserinformations = new CMappingList<UserInformationDTO, tbluserinformation>().GetMappingResultList(myDTO.UserInfoList);
                    }
                    //
                    _ts.tblusers.Add(tblNew);
                    _ts.tblusers.Remove(tblOld);
                    _ts.tbluserbankaccounts.RemoveRange(tblOld.tbluserbankaccounts);
                    _ts.tbluserbanks.RemoveRange(tblOld.tbluserbanks);
                    _ts.tbluserinformations.RemoveRange(tblOld.tbluserinformations);
                    //
                    _ts.SaveChanges();
                    trans.Commit();
                    //
                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }

        private void AddBeginningBalance(UserDTO myDTO, UserBankAccountDTO item) {
            var tbl = _ts.tbltransactions.FirstOrDefault(c=>c.BankAccountNo == item.BankAccountNo);
            if (tbl == null) {
                TransactionDTO transItem = new TransactionDTO {
                    ReferenceTransNo = myDTO.UserId,
                    BankAccountNo = item.BankAccountNo,
                    Description = "Beginning Balance",
                    Added = item.CurrentBalance,
                    Deducted = 0,
                    OldBalance = 0,
                    NewBalance = item.CurrentBalance,
                    Remarks = $"UserID: {myDTO.UserId}, Desc: Beginning Balance",
                    UserId = myDTO.UserId
                };
                new TransactionData(_ts).SaveDTO(transItem);
            }
        }
    }
}
