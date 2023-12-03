using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
using MoneyBank.Entity;
using MoneyBank.EntityData;

namespace MoneyBank.Forms {
    public partial class ManageExpenseType : MyManageFormBase {
        ExpenseTypeDTO myDTO = new ExpenseTypeDTO();
        public ManageExpenseType() {
            InitializeComponent();
        }
        protected override bool OnSaveData() {
            using (var data = new ExpenseTypeData()) {
                data.SaveDTO(myDTO);
                return true;
            }
        }
        protected override bool OnUpdateData() {
            using (var data = new ExpenseTypeData()) {
                data.UpdateDTO(myDTO);
                return true;
            }
        }
        protected override void LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var data = new ExpenseTypeData()) {
                        myDTO = new CMapping<tblexpensetype, ExpenseTypeDTO>().GetMappingResult(data.GetById(Manage_IdTrack));
                    }
                    break;
            }
            expenseTypeDTOBindingSource.DataSource = myDTO;
        }
    }
}
