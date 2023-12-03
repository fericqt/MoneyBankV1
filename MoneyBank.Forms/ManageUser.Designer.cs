using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageUser {
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
            this.cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userLevelComboBox = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(214, 1);
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
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.userLevelComboBox);
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic2);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic1);
            this.PanelMain3.Size = new System.Drawing.Size(449, 172);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cTextBoxBasic1
            // 
            this.cTextBoxBasic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Username", true));
            this.cTextBoxBasic1.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic1.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic1.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.Location = new System.Drawing.Point(138, 28);
            this.cTextBoxBasic1.Name = "cTextBoxBasic1";
            this.cTextBoxBasic1.Size = new System.Drawing.Size(225, 23);
            this.cTextBoxBasic1.TabIndex = 0;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserDTO);
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(52, 28);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(86, 25);
            this.cLabelDesc1.TabIndex = 1;
            this.cLabelDesc1.Text = "Username:";
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(52, 65);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(80, 25);
            this.cLabelDesc2.TabIndex = 3;
            this.cLabelDesc2.Text = "Password:";
            // 
            // cTextBoxBasic2
            // 
            this.cTextBoxBasic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Password", true));
            this.cTextBoxBasic2.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic2.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic2.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.Location = new System.Drawing.Point(138, 65);
            this.cTextBoxBasic2.Name = "cTextBoxBasic2";
            this.cTextBoxBasic2.Size = new System.Drawing.Size(225, 23);
            this.cTextBoxBasic2.TabIndex = 2;
            this.cTextBoxBasic2.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.userDTOBindingSource;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "UserLevel", true));
            this.userLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userLevelComboBox.ForeColor = System.Drawing.Color.Black;
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Location = new System.Drawing.Point(138, 106);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.PropertyText = "";
            this.userLevelComboBox.PropertyTextValue = "";
            this.userLevelComboBox.Size = new System.Drawing.Size(225, 21);
            this.userLevelComboBox.TabIndex = 4;
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(52, 106);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(77, 25);
            this.cLabelDesc3.TabIndex = 5;
            this.cLabelDesc3.Text = "UserLevel";
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 326);
            this.HideSaveNew = true;
            this.Name = "ManageUser";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "ManageUser";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic1;
        private BindingSource userDTOBindingSource;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic2;
        private ErrorProvider errorProvider1;
        private FerPROJ.Design.Controls.CComboBoxBasic userLevelComboBox;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
    }
}