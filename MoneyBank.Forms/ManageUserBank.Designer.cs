using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageUserBank {
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
            this.userBankDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbBankName = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBankDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(227, 1);
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
            this.PanelMain3.Controls.Add(this.cmbBankName);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic3);
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic2);
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(462, 145);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(28, 21);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(88, 25);
            this.cLabelDesc1.TabIndex = 0;
            this.cLabelDesc1.Text = "BankName";
            // 
            // userBankDTOBindingSource
            // 
            this.userBankDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserBankDTO);
            // 
            // cTextBoxBasic2
            // 
            this.cTextBoxBasic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBankDTOBindingSource, "BankAccountNo", true));
            this.cTextBoxBasic2.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic2.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic2.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.Location = new System.Drawing.Point(172, 60);
            this.cTextBoxBasic2.Name = "cTextBoxBasic2";
            this.cTextBoxBasic2.Size = new System.Drawing.Size(226, 23);
            this.cTextBoxBasic2.TabIndex = 3;
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(28, 60);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(138, 25);
            this.cLabelDesc2.TabIndex = 2;
            this.cLabelDesc2.Text = "Bank Account No.:";
            // 
            // cTextBoxBasic3
            // 
            this.cTextBoxBasic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBankDTOBindingSource, "BankType", true));
            this.cTextBoxBasic3.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic3.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic3.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.Location = new System.Drawing.Point(172, 96);
            this.cTextBoxBasic3.Name = "cTextBoxBasic3";
            this.cTextBoxBasic3.Size = new System.Drawing.Size(226, 23);
            this.cTextBoxBasic3.TabIndex = 5;
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(28, 96);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(87, 25);
            this.cLabelDesc3.TabIndex = 4;
            this.cLabelDesc3.Text = "Bank Type:";
            // 
            // cmbBankName
            // 
            this.cmbBankName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBankDTOBindingSource, "BankName", true));
            this.cmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankName.ForeColor = System.Drawing.Color.Black;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(172, 21);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.PropertyText = "";
            this.cmbBankName.PropertyTextValue = "";
            this.cmbBankName.Size = new System.Drawing.Size(226, 21);
            this.cmbBankName.TabIndex = 6;
            // 
            // ManageUserBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 299);
            this.Name = "ManageUserBank";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "ManageUserBank";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBankDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private BindingSource userBankDTOBindingSource;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbBankName;
    }
}