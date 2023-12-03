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
    }
}
