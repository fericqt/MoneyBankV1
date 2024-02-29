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
            return _ts.tblexpenses.FirstOrDefault(c => c.TransNo == id);
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
            string sSelect = SelectAll<ExpenseDTO>(SearchValue) + Status();
            _conn.FillDGV(dgv, sSelect);
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
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = GetById(id);
                    ValidateDelete(tbl);
                    tbl.Status = CEnum.Status.CANCELLED.ToString();
                    tbl.CancelledBy = CStaticVariable.UserID;
                    tbl.CancelledDate = DateTime.Now;
                    tbl.CancelledRemarks = "";
                    //
                    var tblu = new UserData(_ts).GetById(tbl.UserID);
                    var tblBankAcc = tblu.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == tbl.BankAccountNo);
                    //
                    StringBuilder sbDesc = new StringBuilder();
                    foreach (var item in tbl.tblexpensedetails) {
                        sbDesc.Append($"{item.Description}, ");
                    }
                    var transItem = new TransactionDTO {
                        ReferenceTransNo = tbl.TransNo,
                        BankAccountNo = tbl.BankAccountNo,
                        Description = $"{tbl.Remarks} - {sbDesc.ToString()}",
                        Added = (decimal)tbl.TotalAmount,
                        Deducted = 0,
                        OldBalance = (decimal)tblBankAcc.RemainingBalance,
                        NewBalance = (decimal)(tblBankAcc.RemainingBalance + tbl.TotalAmount),
                        Remarks = "Cancelled Expense Transaction",
                        UserId = tbl.UserID,
                    };
                    new TransactionData(_ts).SaveDTO(transItem);
                    //
                    tblBankAcc.AmountDeducted = 0;
                    tblBankAcc.DateUpdated = DateTime.Now;
                    tblBankAcc.AmountAdded = tbl.TotalAmount;
                    tblBankAcc.CurrentBalance = tblBankAcc.RemainingBalance;
                    tblBankAcc.RemainingBalance = tblBankAcc.RemainingBalance + tbl.TotalAmount;
                    //
                    _ts.SaveChanges();
                    trans.Commit();


                }
                catch(Exception) {
                    trans.Rollback();
                    throw;
                }
            }
        }

        protected override void SaveData(ExpenseDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<ExpenseDTO, tblexpense>().GetMappingResult(myDTO);
                    tbl.tblexpensedetails = new CMappingList<ExpenseDetailDTO, tblexpensedetail>().GetMappingResultList(myDTO.ExpenseList);
                    //
                    var tblu = new UserData(_ts).GetById(myDTO.UserID);
                    var tblBankAcc = tblu.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == myDTO.BankAccountNo);
                    //
                    StringBuilder sbDesc = new StringBuilder();
                    foreach (var item in myDTO.ExpenseList) {
                        sbDesc.Append($"{item.ExpenseType} - {item.Description}, ");
                    }
                    TransactionDTO transItem = new TransactionDTO {
                        ReferenceTransNo = myDTO.TransNo,
                        BankAccountNo = myDTO.BankAccountNo,
                        Description = sbDesc.ToString(),
                        Added = 0,
                        Deducted = -myDTO.TotalAmount,
                        OldBalance = (decimal)tblBankAcc.RemainingBalance,
                        NewBalance = (decimal)(tblBankAcc.RemainingBalance - myDTO.TotalAmount),
                        Remarks = myDTO.Remarks,
                        UserId = myDTO.UserID
                    };
                    new TransactionData(_ts).SaveDTO(transItem);
                    //
                    tblBankAcc.AmountAdded = 0;
                    tblBankAcc.DateUpdated = DateTime.Now;
                    tblBankAcc.AmountDeducted = -myDTO.TotalAmount;
                    tblBankAcc.CurrentBalance = tblBankAcc.RemainingBalance;
                    tblBankAcc.RemainingBalance = tblBankAcc.RemainingBalance - myDTO.TotalAmount;
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
                    tbl.tblexpensedetails = new CMappingList<ExpenseDetailDTO, tblexpensedetail>().GetMappingResultList(myDTO.ExpenseList);
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
        private void ValidateDelete(tblexpense tbl) {
            if (tbl.Status == CEnum.Status.CANCELLED.ToString()) {
                throw new ArgumentException("Transaction has already been cancelled!");
            }
        }
    }
}
