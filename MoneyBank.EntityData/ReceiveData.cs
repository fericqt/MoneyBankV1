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
    public class ReceiveData : BaseDBEntity<moneybankEntities, Conn, ReceiveDTO, string>, IEntityData<tblreceive, string> {
        public ReceiveData() {
        }

        public ReceiveData(moneybankEntities ts) : base(ts) {
        }

        public ReceiveData(Conn conn) : base(conn) {
        }

        public IEnumerable<tblreceive> GetAll() {
            throw new NotImplementedException();
        }

        public tblreceive GetById(string id) {
            return _ts.tblreceives.FirstOrDefault(c => c.ReceiveTransNo == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("RT", _tableName);
        }

        public void LoadComboBox(ComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<ReceiveDTO>(SearchValue));
        }

        public void LoadList(DataGridView dgv, string id, string SearchValue = "%") {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<ReceiveDTO>(dateFrom, dateTo, SearchValue));
        }

        public void LoadList(DataGridView dgv, string id, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            throw new NotImplementedException();
        }

        protected override void DeleteData(string id) {
            ValidateDelete(id);
            var tbl = GetById(id);
            //
            ExpenseDTO myDTO = new ExpenseDTO();
            myDTO.ExpenseTransNo = new ExpenseData(_conn).GetNewID();
            myDTO.UserId = tbl.UserID;
            myDTO.BankAccountNo = tbl.BankAccountNo;
            //
            foreach (var item in tbl.tblreceivedetails) {
                var itemToAdd = new ExpenseDetailDTO {
                    ExpenseTransNo = myDTO.ExpenseTransNo,
                    ExpenseAmount = (decimal)item.ReceiveAmount,
                    ExpenseName = item.ReceiveItemName,
                    ExpenseQuantity = (int)item.ReceiveQuantity,
                    Remarks = $"Cancelled Received. Ref Transo:{tbl.ReceiveTransNo}.\n{item.Remarks}"                   
                };
                myDTO.ExpenseList.Add(itemToAdd);
            }
            new ExpenseData(_ts).SaveToDB(myDTO);
        }

        protected override void SaveData(ReceiveDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<ReceiveDTO, tblreceive>().GetMappingResult(myDTO);
                    tbl.tblreceivedetails = new CMappingList<ReceiveDetailDTO, tblreceivedetail>().GetMappingResultList(myDTO.ReceiveList);
                    //
                    var tblu = new UserData(_ts).GetById(myDTO.UserId);
                    var tblBankAcc = tblu.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == myDTO.BankAccountNo);
                    //
                    StringBuilder sbDesc = new StringBuilder();
                    foreach(var item in myDTO.ReceiveList) { 
                        sbDesc.Append($"{item.ReceiveItemName}. {item.Remarks}, ");
                    }
                    TransactionDTO transItem = new TransactionDTO {
                        ReferenceTransNo = myDTO.ReceiveTransNo,
                        BankAccountNo = myDTO.BankAccountNo,
                        Description = sbDesc.ToString(),
                        Added = (decimal)myDTO.TotalReceiveAmount,
                        Deducted = 0,
                        OldBalance = (decimal)tblBankAcc.RemainingBalance,
                        NewBalance = (decimal)(tblBankAcc.RemainingBalance + myDTO.TotalReceiveAmount),
                        Remarks = $"RefTrans: {myDTO.ReceiveTransNo}, Desc: {sbDesc.ToString()}",
                        UserId = myDTO.UserId
                    };
                    new TransactionData(_ts).SaveDTO(transItem);
                    //
                    tblBankAcc.AmountDeducted = 0;
                    tblBankAcc.DateUpdated = DateTime.Now;
                    tblBankAcc.AmountAdded = myDTO.TotalReceiveAmount;
                    tblBankAcc.CurrentBalance = tblBankAcc.RemainingBalance;
                    tblBankAcc.RemainingBalance = tblBankAcc.RemainingBalance + myDTO.TotalReceiveAmount;
                    //
                    _ts.tblreceives.Add(tbl);
                    _ts.SaveChanges();
                    trans.Commit();
                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }

        protected override void SetTables() {
            _tableName = "tblreceive";
            _tableDetailsName = "tblreceivedetails";
        }

        protected override void UpdateData(ReceiveDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<ReceiveDTO, tblreceive>().GetMappingResult(myDTO);
                    foreach (var item in myDTO.ReceiveList) {
                        var itemToAdd = new CMapping<ReceiveDetailDTO, tblreceivedetail>().GetMappingResult(item);
                        tbl.tblreceivedetails.Add(itemToAdd);
                    }
                    //
                    _ts.tblreceives.AddOrUpdate(tbl);
                    _ts.SaveChanges();
                    trans.Commit();
                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }
        public void SaveToDB(ReceiveDTO myDTO) {
            SaveData(myDTO);
        }
        private void ValidateDelete(string id) {
            var tbl = new ExpenseData(_ts).GetById(id);
            if (tbl != null) {
                throw new ArgumentException("Transaction has already been cancelled!");
            }
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo) {
            throw new NotImplementedException();
        }
    }
}
