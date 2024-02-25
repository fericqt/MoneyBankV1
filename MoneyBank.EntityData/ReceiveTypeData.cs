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
    public class ReceiveTypeData : BaseDBEntity<moneybankEntities, Conn, ReceiveTypeDTO, string>, IEntityData<tblreceivetype, string> {
        public ReceiveTypeData() {
        }

        public ReceiveTypeData(moneybankEntities ts) : base(ts) {
        }

        public IEnumerable<tblreceivetype> GetAll() {
            throw new NotImplementedException();
        }

        public tblreceivetype GetById(string id) {
            return _ts.tblreceivetypes.FirstOrDefault(c => c.ReceiveNo == id);
        }

        public string GetNewID() {
            return _conn.GetNewStringID("RCT", _tableName);
        }

        public void LoadComboBox(ComboBox cmb) {
            _conn.FillComboBox(cmb, "ReceiveType", "ReceiveNo", SelectAll());
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
            _ts.tblreceivetypes.Remove(tbl);
            _ts.SaveChanges();
        }

        protected override void SaveData(ReceiveTypeDTO myDTO) {
            var tbl = new CMapping<ReceiveTypeDTO, tblreceivetype>().GetMappingResult(myDTO);
            tbl.ReceiveNo = GetNewID();
            _ts.tblreceivetypes.Add(tbl);
            _ts.SaveChanges();
        }

        protected override void SetTables() {
            _tableName = "tblreceivetype";
        }

        protected override void UpdateData(ReceiveTypeDTO myDTO) {
            var tbl = new CMapping<ReceiveTypeDTO, tblreceivetype>().GetMappingResult(myDTO);
            _ts.tblreceivetypes.AddOrUpdate(tbl);
            _ts.SaveChanges();
        }
    }
}
