using FerPROJ.DBHelper.Base;
using FerPROJ.DBHelper.CRUD;
using FerPROJ.Design.Class;
using FerPROJ.Design.Controls;
using FerPROJ.Design.Interface;
using MoneyBank.DTO;
using MoneyBank.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBank.EntityData {
    public class BankData : BaseDBEntity<moneybankEntities, Conn, BankDTO, string>, IEntityData<tblbank, string> {
        public BankData() {
        }

        public BankData(moneybankEntities ts) : base(ts) {
        }

        public IEnumerable<tblbank> GetAll() {
            throw new NotImplementedException();
        }

        public tblbank GetById(string id) {
            return _ts.tblbanks.FirstOrDefault(c => c.BankSwiftcode == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("BN", _tableName);
        }
        public string GetBankTransferID() {
            return _conn.GetNewStringID("BT", "tbltransactions");
        }

        public void LoadComboBox(ComboBox cmb) {
            _conn.FillComboBox(cmb, "BankName", "BankSwiftcode", SelectAll());
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll());
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

        protected override void DeleteData(string id) {
            var tbl = GetById(id);
            _ts.tblbanks.Remove(tbl);
            _ts.SaveChanges();

        }

        protected override void SaveData(BankDTO myDTO) {
            var tbl = new CMapping<BankDTO, tblbank>().GetMappingResult(myDTO);
            _ts.tblbanks.Add(tbl);
            _ts.SaveChanges();
        }

        protected override void SetTables() {
            _tableName = "tblbank";
        }

        protected override void UpdateData(BankDTO myDTO) {
            var tblNew = new CMapping<BankDTO, tblbank>().GetMappingResult(myDTO);
            _ts.tblbanks.AddOrUpdate(tblNew);
            _ts.SaveChanges();

        }
        public void BankTransfer(BankTransferDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
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
                        ReferenceTransNo = GetBankTransferID(),
                        BankAccountNo = myDTO.BankAccountNoFrom,
                        Description = $"Transfer To {tblTo.FullName} using {tblFromBank.BankName} ending no. of {tblFromBankEndingNo}" +
                                      $"from your {tblFromBank.BankName} ending no. of {tblFromBankEndingNo} amounting of {myDTO.Amount}",
                        Added = 0,
                        Deducted = -myDTO.Amount,
                        OldBalance = (decimal)tblFromBank.RemainingBalance,
                        NewBalance = (decimal)tblFromBank.RemainingBalance - myDTO.Amount,
                        Remarks = myDTO.Remarks,
                        UserId = myDTO.UserIDFrom
                    };
                    new TransactionData(_ts, _conn).SaveDTO(bankFrom);
                    //
                    var bankTo = new TransactionDTO {
                        ReferenceTransNo = GetBankTransferID(),
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
                    new TransactionData(_ts, _conn).SaveDTO(bankTo);
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
    }
}
