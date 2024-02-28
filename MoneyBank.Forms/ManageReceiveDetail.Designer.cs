using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageReceiveDetail {
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
            this.receiveDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbReceiveName = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.descriptionCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.amountCLabelDesc = new FerPROJ.Design.Controls.CLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(235, 1);
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
            this.PanelMain3.Controls.Add(this.amountCLabelDesc);
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.descriptionCTextBoxBasic);
            this.PanelMain3.Controls.Add(this.cmbReceiveName);
            this.PanelMain3.Controls.Add(this.cLabelDesc5);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic4);
            this.PanelMain3.Controls.Add(this.cLabelDesc4);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic3);
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(470, 204);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(44, 17);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(109, 25);
            this.cLabelDesc1.TabIndex = 0;
            this.cLabelDesc1.Text = "Receive Type:";
            // 
            // receiveDetailDTOBindingSource
            // 
            this.receiveDetailDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ReceiveDetailDTO);
            // 
            // cTextBoxBasic3
            // 
            this.cTextBoxBasic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "Qty", true));
            this.cTextBoxBasic3.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic3.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic3.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.Location = new System.Drawing.Point(273, 96);
            this.cTextBoxBasic3.Name = "cTextBoxBasic3";
            this.cTextBoxBasic3.Size = new System.Drawing.Size(157, 23);
            this.cTextBoxBasic3.TabIndex = 5;
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(44, 96);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(39, 25);
            this.cLabelDesc3.TabIndex = 4;
            this.cLabelDesc3.Text = "Qty:";
            // 
            // cTextBoxBasic4
            // 
            this.cTextBoxBasic4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "Price", true));
            this.cTextBoxBasic4.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic4.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic4.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.Location = new System.Drawing.Point(273, 125);
            this.cTextBoxBasic4.Name = "cTextBoxBasic4";
            this.cTextBoxBasic4.Size = new System.Drawing.Size(157, 23);
            this.cTextBoxBasic4.TabIndex = 7;
            // 
            // cLabelDesc4
            // 
            this.cLabelDesc4.AutoSize = true;
            this.cLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc4.Location = new System.Drawing.Point(44, 125);
            this.cLabelDesc4.Name = "cLabelDesc4";
            this.cLabelDesc4.Size = new System.Drawing.Size(70, 25);
            this.cLabelDesc4.TabIndex = 6;
            this.cLabelDesc4.Text = "Amount:";
            // 
            // cLabelDesc5
            // 
            this.cLabelDesc5.AutoSize = true;
            this.cLabelDesc5.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc5.Location = new System.Drawing.Point(44, 162);
            this.cLabelDesc5.Name = "cLabelDesc5";
            this.cLabelDesc5.Size = new System.Drawing.Size(49, 25);
            this.cLabelDesc5.TabIndex = 8;
            this.cLabelDesc5.Text = "Total:";
            // 
            // cmbReceiveName
            // 
            this.cmbReceiveName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "ReceiveType", true));
            this.cmbReceiveName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiveName.ForeColor = System.Drawing.Color.Black;
            this.cmbReceiveName.FormattingEnabled = true;
            this.cmbReceiveName.Location = new System.Drawing.Point(159, 20);
            this.cmbReceiveName.Name = "cmbReceiveName";
            this.cmbReceiveName.PropertyText = "";
            this.cmbReceiveName.PropertyTextValue = "";
            this.cmbReceiveName.Size = new System.Drawing.Size(271, 21);
            this.cmbReceiveName.TabIndex = 10;
            // 
            // descriptionCTextBoxBasic
            // 
            this.descriptionCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "Description", true));
            this.descriptionCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.descriptionCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.descriptionCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.descriptionCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.descriptionCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionCTextBoxBasic.Location = new System.Drawing.Point(159, 47);
            this.descriptionCTextBoxBasic.Multiline = true;
            this.descriptionCTextBoxBasic.Name = "descriptionCTextBoxBasic";
            this.descriptionCTextBoxBasic.Size = new System.Drawing.Size(271, 43);
            this.descriptionCTextBoxBasic.TabIndex = 11;
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(44, 47);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(93, 25);
            this.cLabelDesc2.TabIndex = 12;
            this.cLabelDesc2.Text = "Description:";
            // 
            // amountCLabelDesc
            // 
            this.amountCLabelDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "Amount", true));
            this.amountCLabelDesc.Font = new System.Drawing.Font("Poppins", 10F);
            this.amountCLabelDesc.Location = new System.Drawing.Point(273, 162);
            this.amountCLabelDesc.Name = "amountCLabelDesc";
            this.amountCLabelDesc.Size = new System.Drawing.Size(157, 23);
            this.amountCLabelDesc.TabIndex = 13;
            this.amountCLabelDesc.Text = "cLabelDesc6";
            // 
            // ManageReceiveDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 358);
            this.Name = "ManageReceiveDetail";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ManageReceiveDetails";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc5;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic4;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private BindingSource receiveDetailDTOBindingSource;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbReceiveName;
        private FerPROJ.Design.Controls.CLabelDesc amountCLabelDesc;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CTextBoxBasic descriptionCTextBoxBasic;
    }
}