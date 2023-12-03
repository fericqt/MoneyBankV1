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
            this.cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.receiveDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic5 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbReceiveName = new FerPROJ.Design.Controls.CComboBoxBasic();
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
            this.PanelMain3.Controls.Add(this.cmbReceiveName);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic5);
            this.PanelMain3.Controls.Add(this.cLabelDesc5);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic4);
            this.PanelMain3.Controls.Add(this.cLabelDesc4);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic3);
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.cTextBoxBasic2);
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(470, 264);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(44, 20);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(113, 25);
            this.cLabelDesc1.TabIndex = 0;
            this.cLabelDesc1.Text = "ReceiveName:";
            // 
            // cTextBoxBasic2
            // 
            this.cTextBoxBasic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "Remarks", true));
            this.cTextBoxBasic2.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic2.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic2.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.Location = new System.Drawing.Point(159, 57);
            this.cTextBoxBasic2.Multiline = true;
            this.cTextBoxBasic2.Name = "cTextBoxBasic2";
            this.cTextBoxBasic2.Size = new System.Drawing.Size(271, 79);
            this.cTextBoxBasic2.TabIndex = 3;
            // 
            // receiveDetailDTOBindingSource
            // 
            this.receiveDetailDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ReceiveDetailDTO);
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(44, 57);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(75, 25);
            this.cLabelDesc2.TabIndex = 2;
            this.cLabelDesc2.Text = "Remarks:";
            // 
            // cTextBoxBasic3
            // 
            this.cTextBoxBasic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "ReceiveQuantity", true));
            this.cTextBoxBasic3.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic3.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic3.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.Location = new System.Drawing.Point(273, 152);
            this.cTextBoxBasic3.Name = "cTextBoxBasic3";
            this.cTextBoxBasic3.Size = new System.Drawing.Size(157, 23);
            this.cTextBoxBasic3.TabIndex = 5;
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(44, 152);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(39, 25);
            this.cLabelDesc3.TabIndex = 4;
            this.cLabelDesc3.Text = "Qty:";
            // 
            // cTextBoxBasic4
            // 
            this.cTextBoxBasic4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "ReceiveAmount", true));
            this.cTextBoxBasic4.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic4.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic4.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.Location = new System.Drawing.Point(273, 189);
            this.cTextBoxBasic4.Name = "cTextBoxBasic4";
            this.cTextBoxBasic4.Size = new System.Drawing.Size(157, 23);
            this.cTextBoxBasic4.TabIndex = 7;
            // 
            // cLabelDesc4
            // 
            this.cLabelDesc4.AutoSize = true;
            this.cLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc4.Location = new System.Drawing.Point(44, 189);
            this.cLabelDesc4.Name = "cLabelDesc4";
            this.cLabelDesc4.Size = new System.Drawing.Size(70, 25);
            this.cLabelDesc4.TabIndex = 6;
            this.cLabelDesc4.Text = "Amount:";
            // 
            // cTextBoxBasic5
            // 
            this.cTextBoxBasic5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "ReceiveAmountTotal", true));
            this.cTextBoxBasic5.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic5.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic5.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic5.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic5.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic5.Location = new System.Drawing.Point(273, 226);
            this.cTextBoxBasic5.Name = "cTextBoxBasic5";
            this.cTextBoxBasic5.Size = new System.Drawing.Size(157, 23);
            this.cTextBoxBasic5.TabIndex = 9;
            // 
            // cLabelDesc5
            // 
            this.cLabelDesc5.AutoSize = true;
            this.cLabelDesc5.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc5.Location = new System.Drawing.Point(44, 226);
            this.cLabelDesc5.Name = "cLabelDesc5";
            this.cLabelDesc5.Size = new System.Drawing.Size(49, 25);
            this.cLabelDesc5.TabIndex = 8;
            this.cLabelDesc5.Text = "Total:";
            // 
            // cmbReceiveName
            // 
            this.cmbReceiveName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDetailDTOBindingSource, "ReceiveItemName", true));
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
            // ManageReceiveDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 418);
            this.Name = "ManageReceiveDetail";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "ManageReceiveDetails";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic5;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc5;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic4;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private BindingSource receiveDetailDTOBindingSource;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbReceiveName;
    }
}