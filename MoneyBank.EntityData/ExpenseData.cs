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
    public class ExpenseData : BaseDBEntity<moneybankEntities, Conn, ExpenseDTO, string>, IEntityData<tblexpense, string> {
        public ExpenseData() {
        }

        public ExpenseData(moneybankEntities ts) : base(ts) {
        }

        public ExpenseData(Conn conn) : base(conn) {
        }

        public IEnumerable<tblexpense> GetAll() {
            throw new NotImplementedException();
        }

        public tblexpense GetById(string id) {
            return _ts.tblexpenses.FirstOrDefault(c => c.ExpenseTransNo == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("ET", _tableName);
        }

        public void LoadComboBox(ComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<ExpenseDTO>(SearchValue));
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
            ValidateDelete(id);
            var tbl = GetById(id);
            //
            ReceiveDTO myDTO = new ReceiveDTO();
            myDTO.ReceiveTransNo = new ReceiveData(_conn).GetNewID();
            myDTO.UserId = tbl.UserID;
            myDTO.BankAccountNo = tbl.BankAccountNo;
            //
            foreach (var item in tbl.tblexpensedetails) {
                var itemToAdd = new ReceiveDetailDTO {
                    ReceiveTransNo = myDTO.ReceiveTransNo,
                    ReceiveAmount = (decimal)item.ExpenseAmount,
                    ReceiveItemName = item.ExpenseName,
                    ReceiveQuantity = (int)item.ExpenseQuantity,
                    Remarks = $"Cancelled Expense. Ref Transo:{tbl.ExpenseTransNo}.\n{item.Remarks}"
                };
                myDTO.ReceiveList.Add(itemToAdd);
            }           
            new ReceiveData(_ts).SaveToDB(myDTO);           
        }

        protected override void SaveData(ExpenseDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<ExpenseDTO, tblexpense>().GetMappingResult(myDTO);
                    tbl.tblexpensedetails = new CMappingList<ExpenseDetailDTO, tblexpensedetail>().GetMappingResultList(myDTO.ExpenseList);
                    //
                    var tblu = new UserData(_ts).GetById(myDTO.UserId);
                    var tblBankAcc = tblu.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == myDTO.BankAccountNo);
                    //
                    StringBuilder sbDesc = new StringBuilder();
                    foreach (var item in myDTO.ExpenseList) {
                        sbDesc.Append($"{item.ExpenseName}. {item.Remarks}, ");
                    }
                    TransactionDTO transItem = new TransactionDTO {
                        ReferenceTransNo = myDTO.ExpenseTransNo,
                        BankAccountNo = myDTO.BankAccountNo,
                        Description = sbDesc.ToString(),
                        Added = 0,
                        Deducted = -(decimal)myDTO.TotalExpenseAmount,
                        OldBalance = (decimal)tblBankAcc.RemainingBalance,
                        NewBalance = (decimal)(tblBankAcc.RemainingBalance - myDTO.TotalExpenseAmount),
                        Remarks = $"RefTrans: {myDTO.ExpenseTransNo}, Desc: {sbDesc.ToString()}",
                        UserId = myDTO.UserId
                    };
                    new TransactionData(_ts).SaveDTO(transItem);
                    //
                    tblBankAcc.AmountAdded = 0;
                    tblBankAcc.DateUpdated = DateTime.Now;
                    tblBankAcc.AmountDeducted = -myDTO.TotalExpenseAmount;
                    tblBankAcc.CurrentBalance = tblBankAcc.RemainingBalance;
                    tblBankAcc.RemainingBalance = tblBankAcc.RemainingBalance - myDTO.TotalExpenseAmount;
                    _ts.tblexpenses.Add(tbl);
                    _ts.SaveChanges();
                    trans.Commit();

                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }

        protected override void SetTables() {
            _tableName = "tblexpense";
            _tableDetailsName = "tblexpensedetails";
        }

        protected override void UpdateData(ExpenseDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<ExpenseDTO, tblexpense>().GetMappingResult(myDTO);
                    foreach (var item in myDTO.ExpenseList) {
                        var tbld = new CMapping<ExpenseDetailDTO, tblexpensedetail>().GetMappingResult(item);
                        tbl.tblexpensedetails.Add(tbld);
                    }
                    //
                    _ts.tblexpenses.AddOrUpdate(tbl);
                    _ts.SaveChanges();
                    trans.Commit();

                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }
        public void SaveToDB(ExpenseDTO myDTO) {
            SaveData(myDTO);
        }
        private void ValidateDelete(string id) {
            var tbl = new ReceiveData(_ts).GetById(id);
            if (tbl != null) {
                throw new ArgumentException("Transaction has already been cancelled!");
            }
        }
    }
}
