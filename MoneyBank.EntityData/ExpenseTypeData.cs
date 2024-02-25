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
    public class ExpenseTypeData : BaseDBEntity<moneybankEntities, Conn, ExpenseTypeDTO, string>, IEntityData<tblexpensetype, string> {
        public ExpenseTypeData() {
        }

        public ExpenseTypeData(moneybankEntities ts) : base(ts) {
        }

        public IEnumerable<tblexpensetype> GetAll() {
            throw new NotImplementedException();
        }

        public tblexpensetype GetById(string id) {
            return _ts.tblexpensetypes.FirstOrDefault(c => c.ExpenseNo == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("EXT", _tableName);
        }

        public void LoadComboBox(ComboBox cmb) {
            _conn.FillComboBox(cmb, "ExpenseName", "ExpenseNo", SelectAll());
        }

        public void LoadComboBox(CComboBox cmb) {
            throw new NotImplementedException();
        }

        public void LoadList(DataGridView dgv, string SearchValue = "%") {
            _conn.FillDGV(dgv, SelectAll<ExpenseTypeDTO>(SearchValue));
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
            var tbl = GetById(id);
            _ts.tblexpensetypes.Remove(tbl);
            _ts.SaveChanges();
        }

        protected override void SaveData(ExpenseTypeDTO myDTO) {
            var tbl = new CMapping<ExpenseTypeDTO, tblexpensetype>().GetMappingResult(myDTO);
            tbl.ExpenseNo = GetNewID();
            _ts.tblexpensetypes.Add(tbl);
            _ts.SaveChanges();
        }

        protected override void SetTables() {
            _tableName = "tblexpensetype";
        }

        protected override void UpdateData(ExpenseTypeDTO myDTO) {
            var tbl = new CMapping<ExpenseTypeDTO, tblexpensetype>().GetMappingResult(myDTO);
            _ts.tblexpensetypes.AddOrUpdate(tbl);
            _ts.SaveChanges();
        }
    }
}
