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

namespace MoneyBank.Forms {
    public partial class ManageBank : MyManageFormBase {
        BankDTO myDTO = new BankDTO();
        public ManageBank() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var data = new BankData()) {
                        var tbl = data.GetById(Manage_IdTrack);
                        myDTO = new CMapping<tblbank, BankDTO>().GetMappingResult(tbl);                      
                    }
                    break;
            }
            bankDTOBindingSource.DataSource = myDTO;
        }
        protected override bool OnSaveData() {
            using (var data = new BankData()) {
                data.SaveDTO(myDTO);
                return true;
            }
        }
        protected override bool OnUpdateData() {
            using (var data = new BankData()) {
                data.UpdateDTO(myDTO);
                return true;
            }
        }
    }
}
