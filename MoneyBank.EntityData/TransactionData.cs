﻿using FerPROJ.DBHelper.Base;
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
    public class TransactionData : BaseDBEntity<moneybankEntities, Conn, TransactionDTO, string>, IEntityData<tbltransaction, string> {
        public TransactionData() {
        }

        public TransactionData(moneybankEntities ts) : base(ts) {
        }

        public TransactionData(Conn conn) : base(conn) {
        }

        public IEnumerable<tbltransaction> GetAll(string id) {
            return _ts.tbltransactions.Where(c=>c.UserID ==id);
        }

        public tbltransaction GetById(string id) {
            return _ts.tbltransactions.FirstOrDefault(c => c.TransNo == id);
        }
        public tbltransaction GetByUserId(string id) {
            return _ts.tbltransactions.FirstOrDefault(c => c.UserID == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("TR", _tableName);
        }

        public void LoadComboBox(ComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<TransactionDTO>(SearchValue)+OrderBy("DateReference", CEnum.Sort.DESC));
        }

        public void LoadList(DataGridView dgv, string id, string SearchValue = "%") {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<TransactionDTO>(dateFrom, dateTo, SearchValue)+OrderBy());
        }

        public void LoadList(DataGridView dgv, string id, DateTime dateFrom, DateTime dateTo, string SearchValue = "%") {
            throw new NotImplementedException();
        }
        public void LoadList(DataGridView dgv, DateTime dateFrom, DateTime dateTo) {
            _conn.FillDGV(dgv, SelectAll(dateFrom, dateTo)+OrderBy());
        }

        protected override void DeleteData(string id) {
            throw new NotImplementedException();
        }

        protected override void SaveData(TransactionDTO myDTO) {
            throw new NotImplementedException();
        }

        protected override void SetTables() {
            _tableName = "tbltransactions";
        }

        protected override void UpdateData(TransactionDTO myDTO) {
            throw new NotImplementedException();
        }
        public void SaveDTO(TransactionDTO myDTO) {
            var tbl = new CMapping<TransactionDTO, tbltransaction>().GetMappingResult(myDTO);
            tbl.TransNo = GetNewID();
            _ts.tbltransactions.Add(tbl);
            _ts.SaveChanges();
        }

        public IEnumerable<tbltransaction> GetAll() {
            throw new NotImplementedException();
        }
    }
}
