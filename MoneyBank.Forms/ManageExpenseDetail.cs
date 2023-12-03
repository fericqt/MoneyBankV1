using FerPROJ.Design.Class;
using MoneyBank.Base.Forms;
using MoneyBank.DTO;
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
    public partial class ManageExpenseDetail : MyManageFormBase {

        public ExpenseDetailDTO myDTO { get; set; } = new ExpenseDetailDTO();

        public ManageExpenseDetail() {
            InitializeComponent();
        }
        protected override void LoadComponents() {
            using (var data = new ExpenseTypeData()) {
                data.LoadComboBox(cmbExpenseName);
            }
            switch (CurrentFormMode) {
                case FormMode.Update:
                    break;

            }
            expenseDetailDTOBindingSource.DataSource = myDTO;
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
