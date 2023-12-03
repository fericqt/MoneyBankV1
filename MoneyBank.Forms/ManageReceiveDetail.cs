using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.EntityData;


namespace MoneyBank.Forms {
    public partial class ManageReceiveDetail : MyManageFormBase {
        public ReceiveDetailDTO myDTO { get; set; } = new ReceiveDetailDTO();
        public ManageReceiveDetail() {
            InitializeComponent();
        }
        protected override void LoadComponents() {

            using (var data = new ReceiveTypeData()) {
                data.LoadComboBox(cmbReceiveName);
            }
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    break;
            }
            receiveDetailDTOBindingSource.DataSource = myDTO;
        }
        protected override bool OnSaveData() {
            if (myDTO.DataValidation()) {
                return true;
            }
            CShowMessage.Warning(myDTO.Error, "Warning");
            return false;
        }
    }
}
