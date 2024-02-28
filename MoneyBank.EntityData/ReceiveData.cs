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
            return _ts.tblreceives.FirstOrDefault(c => c.TransNo == id);
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
            _conn.FillDGV(dgv, SelectAll<ReceiveDTO>(SearchValue) + Status());
        }

        public void LoadList(DataGridView dgv, string id, string SearchValue = "%") {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<ReceiveDTO>(dateFrom, dateTo, SearchValue) + Status());
        }

        public void LoadList(DataGridView dgv, string id, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
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
                    foreach (var item in tbl.tblreceivedetails) {
                        sbDesc.Append($"{item.Description}, ");
                    }
                    var transItem = new TransactionDTO {
                        ReferenceTransNo = tbl.TransNo,
                        BankAccountNo = tbl.BankAccountNo,
                        Description = sbDesc.ToString(),
                        Added = 0,
                        Deducted = -(decimal)tbl.TotalAmount,
                        OldBalance = (decimal)tblBankAcc.RemainingBalance,
                        NewBalance = (decimal)(tblBankAcc.RemainingBalance - tbl.TotalAmount),
                        Remarks = "Cancelled Received Transaction",
                        UserId = tbl.UserID,
                    };
                    new TransactionData(_ts).SaveDTO(transItem);
                    //
                    tblBankAcc.AmountAdded = 0;
                    tblBankAcc.DateUpdated = DateTime.Now;
                    tblBankAcc.AmountDeducted = -tbl.TotalAmount;
                    tblBankAcc.CurrentBalance = tblBankAcc.RemainingBalance;
                    tblBankAcc.RemainingBalance = tblBankAcc.RemainingBalance - tbl.TotalAmount;
                    //
                    _ts.SaveChanges();
                    trans.Commit();

                } catch (Exception) {
                    trans.Rollback();
                    throw;
                }

            }
        }

        protected override void SaveData(ReceiveDTO myDTO) {
            using (var trans = _ts.Database.BeginTransaction()) {
                try {
                    var tbl = new CMapping<ReceiveDTO, tblreceive>().GetMappingResult(myDTO);
                    tbl.tblreceivedetails = new CMappingList<ReceiveDetailDTO, tblreceivedetail>().GetMappingResultList(myDTO.ReceiveList);
                    //
                    var tblu = new UserData(_ts).GetById(myDTO.UserID);
                    var tblBankAcc = tblu.tbluserbankaccounts.FirstOrDefault(c => c.BankAccountNo == myDTO.BankAccountNo);
                    //
                    StringBuilder sbDesc = new StringBuilder();
                    foreach (var item in myDTO.ReceiveList) {
                        sbDesc.Append($"{item.Description}, ");
                    }
                    TransactionDTO transItem = new TransactionDTO {
                        ReferenceTransNo = myDTO.TransNo,
                        BankAccountNo = myDTO.BankAccountNo,
                        Description = sbDesc.ToString(),
                        Added = (decimal)myDTO.TotalAmount,
                        Deducted = 0,
                        OldBalance = (decimal)tblBankAcc.RemainingBalance,
                        NewBalance = (decimal)(tblBankAcc.RemainingBalance + myDTO.TotalAmount),
                        Remarks = myDTO.Remarks,
                        UserId = myDTO.UserID
                    };
                    new TransactionData(_ts).SaveDTO(transItem);
                    //
                    tblBankAcc.AmountDeducted = 0;
                    tblBankAcc.DateUpdated = DateTime.Now;
                    tblBankAcc.AmountAdded = myDTO.TotalAmount;
                    tblBankAcc.CurrentBalance = tblBankAcc.RemainingBalance;
                    tblBankAcc.RemainingBalance = tblBankAcc.RemainingBalance + myDTO.TotalAmount;
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
        private void ValidateDelete(tblreceive tbl) {
            if (tbl.Status == CEnum.Status.CANCELLED.ToString()) {
                throw new ArgumentException("Transaction has already been cancelled!");
            }
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo) {
            throw new NotImplementedException();
        }
    }
}
