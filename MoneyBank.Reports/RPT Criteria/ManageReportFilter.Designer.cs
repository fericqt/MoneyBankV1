namespace MoneyBank.Reports.RPT_Criteria {
    partial class ManageReportFilter {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBankName = new System.Windows.Forms.Panel();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbBankName = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.pnlUserID = new System.Windows.Forms.Panel();
            this.cmbUserID = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBankName.SuspendLayout();
            this.pnlUserID.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(253, 1);
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.FlatAppearance.BorderSize = 0;
            this.baseButtonSave.Text = "OK";
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            this.PanelMain3.Controls.Add(this.tableLayoutPanel1);
            this.PanelMain3.Size = new System.Drawing.Size(488, 128);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBankName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlUserID, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlBankName
            // 
            this.pnlBankName.Controls.Add(this.cLabelDesc3);
            this.pnlBankName.Controls.Add(this.cmbBankName);
            this.pnlBankName.Location = new System.Drawing.Point(3, 61);
            this.pnlBankName.Name = "pnlBankName";
            this.pnlBankName.Size = new System.Drawing.Size(482, 54);
            this.pnlBankName.TabIndex = 4;
            this.pnlBankName.Visible = false;
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(13, 14);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(95, 25);
            this.cLabelDesc3.TabIndex = 0;
            this.cLabelDesc3.Text = "Bank Name:";
            // 
            // cmbBankName
            // 
            this.cmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankName.ForeColor = System.Drawing.Color.Black;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(119, 15);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.PropertyText = "";
            this.cmbBankName.PropertyTextValue = "";
            this.cmbBankName.Size = new System.Drawing.Size(336, 21);
            this.cmbBankName.TabIndex = 1;
            // 
            // pnlUserID
            // 
            this.pnlUserID.Controls.Add(this.cmbUserID);
            this.pnlUserID.Controls.Add(this.cLabelDesc2);
            this.pnlUserID.Location = new System.Drawing.Point(3, 3);
            this.pnlUserID.Name = "pnlUserID";
            this.pnlUserID.Size = new System.Drawing.Size(482, 52);
            this.pnlUserID.TabIndex = 0;
            this.pnlUserID.Visible = false;
            // 
            // cmbUserID
            // 
            this.cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserID.ForeColor = System.Drawing.Color.Black;
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(119, 15);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.PropertyText = "";
            this.cmbUserID.PropertyTextValue = "";
            this.cmbUserID.Size = new System.Drawing.Size(336, 21);
            this.cmbUserID.TabIndex = 3;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(18, 15);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(62, 25);
            this.cLabelDesc2.TabIndex = 2;
            this.cLabelDesc2.Text = "User ID:";
            // 
            // ManageReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 284);
            this.HideSaveNew = true;
            this.Name = "ManageReportFilter";
            this.OnSaveName = "OK";
            this.Text = "ManageReportFilter";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBankName.ResumeLayout(false);
            this.pnlBankName.PerformLayout();
            this.pnlUserID.ResumeLayout(false);
            this.pnlUserID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlUserID;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbUserID;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private System.Windows.Forms.Panel pnlBankName;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbBankName;
    }
}