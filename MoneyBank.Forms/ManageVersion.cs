using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.Entity;
using MoneyBank.EntityData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBank.Forms
{
    public partial class ManageVersion : MyManageFormBase
    {
        VersionDTO myDTO = new VersionDTO();
        public ManageVersion()
        {
            InitializeComponent();
        }
        protected override void LoadComponents()
        {
            switch (CurrentFormMode)
            {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var data = new VersionData())
                    {
                        var tbl = data.GetById(1);
                        if (tbl != null)
                        {
                            myDTO = new CMapping<tblversion, VersionDTO>().GetMappingResult(tbl);
                        }
                    }
                    break;
                default:
                    break;
            }
            versionDTOBindingSource.DataSource = myDTO;
        }
        protected override bool OnSaveData()
        {
            using (var data = new VersionData())
            {
                data.SaveDTO(myDTO);
                return true;
            }
        }
        protected override bool OnUpdateData()
        {
            using (var data = new VersionData())
            {
                data.UpdateDTO(myDTO);
                return true;
            }
        }
    }
}
