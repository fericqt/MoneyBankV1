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
    public partial class ManageReceiveType : MyManageFormBase {
        ReceiveTypeDTO myDTO = new ReceiveTypeDTO();
        public ManageReceiveType() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var data = new ReceiveTypeData()) {
                        myDTO = new CMapping<tblreceivetype, ReceiveTypeDTO>().GetMappingResult(data.GetById(Manage_IdTrack));
                    }
                    break;
            }
            receiveTypeDTOBindingSource.DataSource = myDTO;
        }
        protected override bool OnSaveData() {
            using (var data = new ReceiveTypeData()) {
                data.SaveDTO(myDTO);
                return true;
            }
        }
        protected override bool OnUpdateData() {
            using (var data = new ReceiveTypeData()) {
                data.UpdateDTO(myDTO);
                return true;
            }
        }

    }
}
