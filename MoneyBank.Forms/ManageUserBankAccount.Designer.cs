using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageUserBankAccount {
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
            this.cmbBankAccount = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.userBankAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBankAccountDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(197, 1);
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
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic1);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Controls.Add(this.cmbBankAccount);
            this.PanelMain3.Size = new System.Drawing.Size(432, 109);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cmbBankAccount
            // 
            this.cmbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBankAccountDTOBindingSource, "BankName", true));
            this.cmbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBankAccountDTOBindingSource, "BankAccountNo", true));
            this.cmbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("PropertyText", this.userBankAccountDTOBindingSource, "BankName", true));
            this.cmbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("PropertyTextValue", this.userBankAccountDTOBindingSource, "BankAccountNo", true));
            this.cmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankAccount.ForeColor = System.Drawing.Color.Black;
            this.cmbBankAccount.FormattingEnabled = true;
            this.cmbBankAccount.Location = new System.Drawing.Point(193, 23);
            this.cmbBankAccount.Name = "cmbBankAccount";
            this.cmbBankAccount.PropertyText = "";
            this.cmbBankAccount.PropertyTextValue = "";
            this.cmbBankAccount.Size = new System.Drawing.Size(220, 21);
            this.cmbBankAccount.TabIndex = 0;
            // 
            // userBankAccountDTOBindingSource
            // 
            this.userBankAccountDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserBankAccountDTO);
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(39, 23);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(112, 25);
            this.cLabelDesc1.TabIndex = 1;
            this.cLabelDesc1.Text = "Bank Account:";
            // 
            // cTextBoxBasic1
            // 
            this.cTextBoxBasic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBankAccountDTOBindingSource, "CurrentBalance", true));
            this.cTextBoxBasic1.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic1.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic1.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.Location = new System.Drawing.Point(193, 53);
            this.cTextBoxBasic1.Name = "cTextBoxBasic1";
            this.cTextBoxBasic1.Size = new System.Drawing.Size(220, 23);
            this.cTextBoxBasic1.TabIndex = 2;
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(39, 53);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(145, 25);
            this.cLabelDesc2.TabIndex = 3;
            this.cLabelDesc2.Text = "Beggining Balance:";
            // 
            // ManageUserBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 263);
            this.Name = "ManageUserBankAccount";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "ManageUserBankAccount";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBankAccountDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic1;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbBankAccount;
        private BindingSource userBankAccountDTOBindingSource;
    }
}