using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageExpenseType {
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
            this.cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.expenseTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(249, 1);
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
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic1);
            this.PanelMain3.Size = new System.Drawing.Size(484, 71);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(21, 23);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(110, 25);
            this.cLabelDesc1.TabIndex = 1;
            this.cLabelDesc1.Text = "Expense Type:";
            // 
            // cTextBoxBasic1
            // 
            this.cTextBoxBasic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseTypeDTOBindingSource, "ExpenseName", true));
            this.cTextBoxBasic1.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic1.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic1.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.Location = new System.Drawing.Point(137, 23);
            this.cTextBoxBasic1.Name = "cTextBoxBasic1";
            this.cTextBoxBasic1.Size = new System.Drawing.Size(325, 23);
            this.cTextBoxBasic1.TabIndex = 0;
            // 
            // expenseTypeDTOBindingSource
            // 
            this.expenseTypeDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ExpenseTypeDTO);
            // 
            // ManageExpenseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 225);
            this.Name = "ManageExpenseType";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "Manage Expense Type";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic1;
        private BindingSource expenseTypeDTOBindingSource;
    }
}