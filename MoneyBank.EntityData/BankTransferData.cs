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
    public class BankTransferData : BaseDBEntity<moneybankEntities, Conn, BankTransferDTO, int>, IEntityData<tblbanktransfer, int> {
        public BankTransferData() {
        }

        public BankTransferData(moneybankEntities ts) : base(ts) {
        }

        public BankTransferData(Conn conn) : base(conn) {
        }

        public IEnumerable<tblbanktransfer> GetAll() {
            return _ts.tblbanktransfers.ToList();
        }

        public tblbanktransfer GetById(int id) {
            return _ts.tblbanktransfers.FirstOrDefault(c => c.IdTrack == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("BT", _tableName);
        }

        public void LoadComboBox(ComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo) {
            _conn.FillDGV(dgv, SelectAll(dateFrom, dateTo));
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<BankTransferDTO>(SearchValue));
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

        protected override void DeleteData(int id) {
            throw new NotImplementedException();
        }

        protected override void SaveData(BankTransferDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<BankTransferDTO, tblbanktransfer>().GetMappingResult(myDTO);
                    tbl.TransNo = GetNewID();
                    _ts.tblbanktransfers.Add(tbl);
                    //
                    var tblFrom = new UserData(_ts).GetById(myDTO.UserIDFrom);
                    var tblTo = new UserData(_ts).GetById(myDTO.UserIDTo);
                    //
                    var tblFromBank = tblFrom.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == myDTO.BankAccountNoFrom);
                    var tblToBank = tblTo.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == myDTO.BankAccountNoTo);
                    //
                    var tblFromBankEndingNo = tblFromBank.BankAccountNo.Substring((tblFromBank.BankAccountNo.Length - 4), 4);
                    var tblToBankEndingNo = tblToBank.BankAccountNo.Substring((tblToBank.BankAccountNo.Length - 4), 4);
                    //
                    var bankFrom = new TransactionDTO {
                        ReferenceTransNo = tbl.TransNo,
                        BankAccountNo = myDTO.BankAccountNoFrom,
                        Description = $"Transfer To {tblTo.FullName} using {tblFromBank.BankName} ending no. of {tblFromBankEndingNo} " +
                                      $"From your {tblFromBank.BankName} ending no. of {tblFromBankEndingNo} amounting of {myDTO.Amount}",
                        Added = 0,
                        Deducted = -myDTO.Amount,
                        OldBalance = (decimal)tblFromBank.RemainingBalance,
                        NewBalance = (decimal)tblFromBank.RemainingBalance - myDTO.Amount,
                        Remarks = myDTO.Remarks,
                        UserId = myDTO.UserIDFrom
                    };
                    new TransactionData(_ts).SaveDTO(bankFrom);
                    //
                    var bankTo = new TransactionDTO {
                        ReferenceTransNo = tbl.TransNo,
                        BankAccountNo = myDTO.BankAccountNoTo,
                        Description = $"Received from {tblFrom.FullName} using {tblFromBank.BankName} ending no. of {tblFromBankEndingNo} " +
                                      $"To your {tblToBank.BankName} ending no of {tblToBankEndingNo} amounting of {myDTO.Amount}",
                        Added = myDTO.Amount,
                        Deducted = 0,
                        OldBalance = (decimal)tblToBank.RemainingBalance,
                        NewBalance = (decimal)tblToBank.RemainingBalance + myDTO.Amount,
                        Remarks = myDTO.Remarks,
                        UserId = myDTO.UserIDTo
                    };
                    new TransactionData(_ts).SaveDTO(bankTo);
                    //
                    tblFromBank.AmountDeducted = -myDTO.Amount;
                    tblFromBank.DateUpdated = DateTime.Now;
                    tblFromBank.AmountAdded = 0;
                    tblFromBank.CurrentBalance = tblFromBank.RemainingBalance;
                    tblFromBank.RemainingBalance = tblFromBank.RemainingBalance - myDTO.Amount;
                    //
                    tblToBank.AmountDeducted = 0;
                    tblToBank.DateUpdated = DateTime.Now;
                    tblToBank.AmountAdded = myDTO.Amount;
                    tblToBank.CurrentBalance = tblToBank.RemainingBalance;
                    tblToBank.RemainingBalance = tblToBank.RemainingBalance + myDTO.Amount;
                    //
                    _ts.SaveChanges();
                    trans.Commit();

                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }

        protected override void SetTables() {
            _tableName = "tblbanktransfer";
        }

        protected override void UpdateData(BankTransferDTO myDTO) {
            throw new NotImplementedException();
        }
    }
}
