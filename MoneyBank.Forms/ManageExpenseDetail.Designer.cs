using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageExpenseDetail {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbExpenseName = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.expenseDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(209, 1);
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            this.PanelMain3.Controls.Add(this.cTextBoxBasic4);
            this.PanelMain3.Controls.Add(this.cLabelDesc5);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic3);
            this.PanelMain3.Controls.Add(this.cLabelDesc4);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic2);
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic1);
            this.PanelMain3.Controls.Add(this.cmbExpenseName);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(444, 272);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(34, 29);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(118, 25);
            this.cLabelDesc1.TabIndex = 2;
            this.cLabelDesc1.Text = "Expense Name:";
            // 
            // cmbExpenseName
            // 
            this.cmbExpenseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDetailDTOBindingSource, "ExpenseName", true));
            this.cmbExpenseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseName.ForeColor = System.Drawing.Color.Black;
            this.cmbExpenseName.FormattingEnabled = true;
            this.cmbExpenseName.Location = new System.Drawing.Point(176, 27);
            this.cmbExpenseName.Name = "cmbExpenseName";
            this.cmbExpenseName.PropertyText = "";
            this.cmbExpenseName.PropertyTextValue = "";
            this.cmbExpenseName.Size = new System.Drawing.Size(237, 21);
            this.cmbExpenseName.TabIndex = 3;
            // 
            // expenseDetailDTOBindingSource
            // 
            this.expenseDetailDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ExpenseDetailDTO);
            // 
            // cTextBoxBasic1
            // 
            this.cTextBoxBasic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDetailDTOBindingSource, "Remarks", true));
            this.cTextBoxBasic1.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic1.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic1.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.Location = new System.Drawing.Point(176, 62);
            this.cTextBoxBasic1.Multiline = true;
            this.cTextBoxBasic1.Name = "cTextBoxBasic1";
            this.cTextBoxBasic1.Size = new System.Drawing.Size(237, 67);
            this.cTextBoxBasic1.TabIndex = 4;
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(34, 62);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(136, 25);
            this.cLabelDesc2.TabIndex = 5;
            this.cLabelDesc2.Text = "Expense Remarks:";
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(34, 145);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(100, 25);
            this.cLabelDesc3.TabIndex = 6;
            this.cLabelDesc3.Text = "Expense Qty:";
            // 
            // cTextBoxBasic2
            // 
            this.cTextBoxBasic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDetailDTOBindingSource, "ExpenseQuantity", true));
            this.cTextBoxBasic2.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic2.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic2.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.Location = new System.Drawing.Point(276, 143);
            this.cTextBoxBasic2.Name = "cTextBoxBasic2";
            this.cTextBoxBasic2.Size = new System.Drawing.Size(137, 23);
            this.cTextBoxBasic2.TabIndex = 7;
            // 
            // cTextBoxBasic3
            // 
            this.cTextBoxBasic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDetailDTOBindingSource, "ExpenseAmount", true));
            this.cTextBoxBasic3.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic3.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic3.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.Location = new System.Drawing.Point(276, 177);
            this.cTextBoxBasic3.Name = "cTextBoxBasic3";
            this.cTextBoxBasic3.Size = new System.Drawing.Size(137, 23);
            this.cTextBoxBasic3.TabIndex = 9;
            // 
            // cLabelDesc4
            // 
            this.cLabelDesc4.AutoSize = true;
            this.cLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc4.Location = new System.Drawing.Point(34, 179);
            this.cLabelDesc4.Name = "cLabelDesc4";
            this.cLabelDesc4.Size = new System.Drawing.Size(131, 25);
            this.cLabelDesc4.TabIndex = 8;
            this.cLabelDesc4.Text = "Expense Amount:";
            // 
            // cTextBoxBasic4
            // 
            this.cTextBoxBasic4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDetailDTOBindingSource, "ExpenseTotal", true));
            this.cTextBoxBasic4.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic4.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic4.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.Location = new System.Drawing.Point(276, 214);
            this.cTextBoxBasic4.Name = "cTextBoxBasic4";
            this.cTextBoxBasic4.Size = new System.Drawing.Size(137, 23);
            this.cTextBoxBasic4.TabIndex = 11;
            // 
            // cLabelDesc5
            // 
            this.cLabelDesc5.AutoSize = true;
            this.cLabelDesc5.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc5.Location = new System.Drawing.Point(34, 216);
            this.cLabelDesc5.Name = "cLabelDesc5";
            this.cLabelDesc5.Size = new System.Drawing.Size(110, 25);
            this.cLabelDesc5.TabIndex = 10;
            this.cLabelDesc5.Text = "Expense Total:";
            // 
            // ManageExpenseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 426);
            this.Name = "ManageExpenseDetail";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "ManageExpenseDetail";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic1;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbExpenseName;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic4;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc5;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private BindingSource expenseDetailDTOBindingSource;
    }
}