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

namespace MoneyBank.EntityData
{
    public class VersionData : BaseDBEntity<moneybankEntities, Conn, VersionDTO, long>,IEntityData<tblversion, long>
    {
        public VersionData()
        {
        }

        public VersionData(moneybankEntities ts) : base(ts)
        {
        }

        public VersionData(Conn conn) : base(conn)
        {
        }

        public IEnumerable<tblversion> GetAll()
        {
            return _ts.tblversions.ToList();
        }

        public tblversion GetById(long id)
        {
            return _ts.tblversions.FirstOrDefault(c=>c.IdTrack == id);
        }

        public string GetNewID()
        {
            throw new NotImplementedException();
        }
        protected override void DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        protected override void SaveData(VersionDTO myDTO)
        {
           var tbl = new CMapping<VersionDTO, tblversion>().GetMappingResult(myDTO);
            _ts.tblversions.Add(tbl);   
            _ts.SaveChanges();
        }

        protected override void SetTables()
        {
            _tableName = "tblversion";
        }

        protected override void UpdateData(VersionDTO myDTO)
        {
            var tbl = GetById(myDTO.IdTrack);
            var tblNew = new CMapping<VersionDTO, tblversion>().GetMappingResult(myDTO);
            if(tbl.Version == tblNew.Version)
            {
                throw new ArgumentException("No changes have been made to the version.\nPlease update the version.");
            }
            var oUpdate = $"Version: {tbl.Version}\n{tbl.NewUpdates}";
            tblNew.OldUpdates = $"{oUpdate} \n\n{tbl.OldUpdates}";
            _ts.tblversions.AddOrUpdate(tblNew);
            _ts.SaveChanges();
        }
    }
}
