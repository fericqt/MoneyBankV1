﻿using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageReceive {
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
            System.Windows.Forms.Label remarksLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReceive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.dgvReceiveDetails = new FerPROJ.Design.Controls.CDatagridview();
            this.idTrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.receiveDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbBank = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc6 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc7 = new FerPROJ.Design.Controls.CLabelDesc();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cLabelDesc8 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc9 = new FerPROJ.Design.Controls.CLabelDesc();
            this.llUserID = new System.Windows.Forms.LinkLabel();
            this.remarksCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            remarksLabel = new System.Windows.Forms.Label();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDetailDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(577, 1);
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
            this.PanelMain3.AutoScroll = true;
            this.PanelMain3.Controls.Add(remarksLabel);
            this.PanelMain3.Controls.Add(this.remarksCTextBoxBasic);
            this.PanelMain3.Controls.Add(this.llUserID);
            this.PanelMain3.Controls.Add(this.panel2);
            this.PanelMain3.Controls.Add(this.cLabelDesc7);
            this.PanelMain3.Controls.Add(this.cLabelDesc6);
            this.PanelMain3.Controls.Add(this.cLabelDesc4);
            this.PanelMain3.Controls.Add(this.cmbBank);
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.cLabelDesc2);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Controls.Add(this.panel1);
            this.PanelMain3.Size = new System.Drawing.Size(812, 410);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(21, 332);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 10;
            remarksLabel.Text = "Remarks:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvReceiveDetails);
            this.panel1.Location = new System.Drawing.Point(21, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 229);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "toolStripButton1";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbRemove.Text = "toolStripButton1";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // dgvReceiveDetails
            // 
            this.dgvReceiveDetails.AllowUserToAddRows = false;
            this.dgvReceiveDetails.AllowUserToDeleteRows = false;
            this.dgvReceiveDetails.AllowUserToOrderColumns = true;
            this.dgvReceiveDetails.AllowUserToResizeRows = false;
            this.dgvReceiveDetails.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dgvReceiveDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceiveDetails.AutoGenerateColumns = false;
            this.dgvReceiveDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiveDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceiveDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReceiveDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceiveDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiveDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReceiveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiveDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrackDataGridViewTextBoxColumn,
            this.transNoDataGridViewTextBoxColumn,
            this.ReceiveType,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvReceiveDetails.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvReceiveDetails.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvReceiveDetails.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvReceiveDetails.DataSource = this.receiveDetailDTOBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiveDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReceiveDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReceiveDetails.EnableHeadersVisualStyles = false;
            this.dgvReceiveDetails.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReceiveDetails.Location = new System.Drawing.Point(0, 28);
            this.dgvReceiveDetails.Name = "dgvReceiveDetails";
            this.dgvReceiveDetails.ReadOnly = true;
            this.dgvReceiveDetails.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiveDetails.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReceiveDetails.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvReceiveDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiveDetails.Size = new System.Drawing.Size(767, 199);
            this.dgvReceiveDetails.TabIndex = 0;
            // 
            // idTrackDataGridViewTextBoxColumn
            // 
            this.idTrackDataGridViewTextBoxColumn.DataPropertyName = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.HeaderText = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.Name = "idTrackDataGridViewTextBoxColumn";
            this.idTrackDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrackDataGridViewTextBoxColumn.Visible = false;
            // 
            // transNoDataGridViewTextBoxColumn
            // 
            this.transNoDataGridViewTextBoxColumn.DataPropertyName = "TransNo";
            this.transNoDataGridViewTextBoxColumn.HeaderText = "TransNo";
            this.transNoDataGridViewTextBoxColumn.Name = "transNoDataGridViewTextBoxColumn";
            this.transNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.transNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ReceiveType
            // 
            this.ReceiveType.DataPropertyName = "ReceiveType";
            this.ReceiveType.HeaderText = "ReceiveType";
            this.ReceiveType.Name = "ReceiveType";
            this.ReceiveType.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveDetailDTOBindingSource
            // 
            this.receiveDetailDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ReceiveDetailDTO);
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(512, 53);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(72, 25);
            this.cLabelDesc1.TabIndex = 1;
            this.cLabelDesc1.Text = "TransNo:";
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDTOBindingSource, "TransNo", true));
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(642, 53);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc2.TabIndex = 2;
            this.cLabelDesc2.Text = "---";
            // 
            // receiveDTOBindingSource
            // 
            this.receiveDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ReceiveDTO);
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(21, 55);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(112, 25);
            this.cLabelDesc3.TabIndex = 3;
            this.cLabelDesc3.Text = "Bank Account:";
            // 
            // cmbBank
            // 
            this.cmbBank.DataBindings.Add(new System.Windows.Forms.Binding("PropertyTextValue", this.receiveDTOBindingSource, "BankAccountNo", true));
            this.cmbBank.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.receiveDTOBindingSource, "BankAccountNo", true));
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.ForeColor = System.Drawing.Color.Black;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(139, 54);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.PropertyText = "";
            this.cmbBank.PropertyTextValue = "";
            this.cmbBank.Size = new System.Drawing.Size(213, 21);
            this.cmbBank.TabIndex = 4;
            // 
            // cLabelDesc4
            // 
            this.cLabelDesc4.AutoSize = true;
            this.cLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc4.Location = new System.Drawing.Point(512, 23);
            this.cLabelDesc4.Name = "cLabelDesc4";
            this.cLabelDesc4.Size = new System.Drawing.Size(125, 25);
            this.cLabelDesc4.TabIndex = 5;
            this.cLabelDesc4.Text = "Date Reference:";
            // 
            // cLabelDesc6
            // 
            this.cLabelDesc6.AutoSize = true;
            this.cLabelDesc6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDTOBindingSource, "DateReference", true));
            this.cLabelDesc6.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc6.Location = new System.Drawing.Point(642, 24);
            this.cLabelDesc6.Name = "cLabelDesc6";
            this.cLabelDesc6.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc6.TabIndex = 7;
            this.cLabelDesc6.Text = "---";
            // 
            // cLabelDesc7
            // 
            this.cLabelDesc7.AutoSize = true;
            this.cLabelDesc7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDTOBindingSource, "UserId", true));
            this.cLabelDesc7.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc7.Location = new System.Drawing.Point(134, 23);
            this.cLabelDesc7.Name = "cLabelDesc7";
            this.cLabelDesc7.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc7.TabIndex = 8;
            this.cLabelDesc7.Text = "---";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cLabelDesc8);
            this.panel2.Controls.Add(this.cLabelDesc9);
            this.panel2.Location = new System.Drawing.Point(573, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 61);
            this.panel2.TabIndex = 9;
            // 
            // cLabelDesc8
            // 
            this.cLabelDesc8.AutoSize = true;
            this.cLabelDesc8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDTOBindingSource, "TotalAmount", true));
            this.cLabelDesc8.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc8.Location = new System.Drawing.Point(62, 17);
            this.cLabelDesc8.Name = "cLabelDesc8";
            this.cLabelDesc8.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc8.TabIndex = 11;
            this.cLabelDesc8.Text = "---";
            // 
            // cLabelDesc9
            // 
            this.cLabelDesc9.AutoSize = true;
            this.cLabelDesc9.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc9.Location = new System.Drawing.Point(15, 17);
            this.cLabelDesc9.Name = "cLabelDesc9";
            this.cLabelDesc9.Size = new System.Drawing.Size(49, 25);
            this.cLabelDesc9.TabIndex = 10;
            this.cLabelDesc9.Text = "Total:";
            // 
            // llUserID
            // 
            this.llUserID.AutoSize = true;
            this.llUserID.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUserID.Location = new System.Drawing.Point(24, 23);
            this.llUserID.Name = "llUserID";
            this.llUserID.Size = new System.Drawing.Size(57, 23);
            this.llUserID.TabIndex = 10;
            this.llUserID.TabStop = true;
            this.llUserID.Text = "User ID:";
            this.llUserID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUserID_LinkClicked);
            // 
            // remarksCTextBoxBasic
            // 
            this.remarksCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDTOBindingSource, "Remarks", true));
            this.remarksCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.remarksCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.remarksCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.remarksCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.remarksCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxBasic.Location = new System.Drawing.Point(77, 333);
            this.remarksCTextBoxBasic.Multiline = true;
            this.remarksCTextBoxBasic.Name = "remarksCTextBoxBasic";
            this.remarksCTextBoxBasic.Size = new System.Drawing.Size(275, 56);
            this.remarksCTextBoxBasic.TabIndex = 11;
            // 
            // ManageReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 564);
            this.Name = "ManageReceive";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ManageReceive";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDetailDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbBank;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private Panel panel2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc7;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc6;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc8;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc9;
        private FerPROJ.Design.Controls.CDatagridview dgvReceiveDetails;
        private BindingSource receiveDetailDTOBindingSource;
        private BindingSource receiveDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbRemove;
        private DataGridViewTextBoxColumn receiveItemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveAmountTotalDataGridViewTextBoxColumn;
        private LinkLabel llUserID;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridViewTextBoxColumn idTrackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ReceiveType;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private FerPROJ.Design.Controls.CTextBoxBasic remarksCTextBoxBasic;
    }
}