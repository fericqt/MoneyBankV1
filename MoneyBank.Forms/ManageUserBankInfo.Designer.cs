using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageUserBankInfo {
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserBankInfo));
            panel1 = new Panel();
            cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
            userDTOBindingSource = new BindingSource(components);
            cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            panel4 = new Panel();
            panel7 = new Panel();
            toolStrip3 = new ToolStrip();
            tsbAddUserInfo = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbRemoveUserInfo = new ToolStripButton();
            cDatagridview3 = new FerPROJ.Design.Controls.CDatagridview();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middlenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            relationshipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userInformationDTOBindingSource = new BindingSource(components);
            cLabelTitle3 = new FerPROJ.Design.Controls.CLabelTitle();
            panel2 = new Panel();
            panel5 = new Panel();
            cDatagridview1 = new FerPROJ.Design.Controls.CDatagridview();
            bankNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankAccountNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBankDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            tsbAddBank = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRemoveBank = new ToolStripButton();
            cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            panel3 = new Panel();
            panel6 = new Panel();
            cDatagridview2 = new FerPROJ.Design.Controls.CDatagridview();
            userBankAccountDTOBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            tsbAddBankAccount = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbRemoveBankAccount = new ToolStripButton();
            cLabelTitle2 = new FerPROJ.Design.Controls.CLabelTitle();
            bankAccountNoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bankNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            remainingBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateUpdatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basePnl2.SuspendLayout();
            PanelMain3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInformationDTOBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBankDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBankAccountDTOBindingSource).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // basePnl2
            // 
            basePnl2.Location = new Point(1008, 1);
            // 
            // baseButtonUpdate
            // 
            baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            baseButtonSave.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            PanelMain3.Controls.Add(panel3);
            PanelMain3.Controls.Add(panel2);
            PanelMain3.Controls.Add(panel1);
            PanelMain3.Size = new Size(1282, 487);
            // 
            // baseButtonAddNew
            // 
            baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cTextBoxBasic4);
            panel1.Controls.Add(cTextBoxBasic3);
            panel1.Controls.Add(cTextBoxBasic2);
            panel1.Controls.Add(cTextBoxBasic1);
            panel1.Controls.Add(cLabelDesc4);
            panel1.Controls.Add(cLabelDesc3);
            panel1.Controls.Add(cLabelDesc2);
            panel1.Controls.Add(cLabelDesc1);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 487);
            panel1.TabIndex = 0;
            // 
            // cTextBoxBasic4
            // 
            cTextBoxBasic4.BackColor = Color.WhiteSmoke;
            cTextBoxBasic4.DataBindings.Add(new Binding("Text", userDTOBindingSource, "DateLastLogin", true));
            cTextBoxBasic4.DefaultForeColor = Color.Black;
            cTextBoxBasic4.EnterColor = Color.LightGray;
            cTextBoxBasic4.Font = new Font("Poppins", 8F);
            cTextBoxBasic4.ForeColor = Color.Black;
            cTextBoxBasic4.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic4.Location = new Point(154, 146);
            cTextBoxBasic4.Name = "cTextBoxBasic4";
            cTextBoxBasic4.Size = new Size(289, 23);
            cTextBoxBasic4.TabIndex = 8;
            // 
            // userDTOBindingSource
            // 
            userDTOBindingSource.DataSource = typeof(DTO.UserDTO);
            // 
            // cTextBoxBasic3
            // 
            cTextBoxBasic3.BackColor = Color.WhiteSmoke;
            cTextBoxBasic3.DataBindings.Add(new Binding("Text", userDTOBindingSource, "UserLevel", true));
            cTextBoxBasic3.DefaultForeColor = Color.Black;
            cTextBoxBasic3.EnterColor = Color.LightGray;
            cTextBoxBasic3.Font = new Font("Poppins", 8F);
            cTextBoxBasic3.ForeColor = Color.Black;
            cTextBoxBasic3.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic3.Location = new Point(154, 105);
            cTextBoxBasic3.Name = "cTextBoxBasic3";
            cTextBoxBasic3.Size = new Size(289, 23);
            cTextBoxBasic3.TabIndex = 7;
            // 
            // cTextBoxBasic2
            // 
            cTextBoxBasic2.BackColor = Color.WhiteSmoke;
            cTextBoxBasic2.DataBindings.Add(new Binding("Text", userDTOBindingSource, "Username", true));
            cTextBoxBasic2.DefaultForeColor = Color.Black;
            cTextBoxBasic2.EnterColor = Color.LightGray;
            cTextBoxBasic2.Font = new Font("Poppins", 8F);
            cTextBoxBasic2.ForeColor = Color.Black;
            cTextBoxBasic2.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic2.Location = new Point(154, 69);
            cTextBoxBasic2.Name = "cTextBoxBasic2";
            cTextBoxBasic2.Size = new Size(289, 23);
            cTextBoxBasic2.TabIndex = 6;
            // 
            // cTextBoxBasic1
            // 
            cTextBoxBasic1.BackColor = Color.WhiteSmoke;
            cTextBoxBasic1.DataBindings.Add(new Binding("Text", userDTOBindingSource, "UserId", true));
            cTextBoxBasic1.DefaultForeColor = Color.Black;
            cTextBoxBasic1.Enabled = false;
            cTextBoxBasic1.EnterColor = Color.LightGray;
            cTextBoxBasic1.Font = new Font("Poppins", 8F);
            cTextBoxBasic1.ForeColor = Color.Black;
            cTextBoxBasic1.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic1.Location = new Point(154, 34);
            cTextBoxBasic1.Name = "cTextBoxBasic1";
            cTextBoxBasic1.Size = new Size(289, 23);
            cTextBoxBasic1.TabIndex = 5;
            // 
            // cLabelDesc4
            // 
            cLabelDesc4.AutoSize = true;
            cLabelDesc4.Font = new Font("Poppins", 10F);
            cLabelDesc4.Location = new Point(23, 144);
            cLabelDesc4.Name = "cLabelDesc4";
            cLabelDesc4.Size = new Size(119, 25);
            cLabelDesc4.TabIndex = 4;
            cLabelDesc4.Text = "Date Last Login:";
            // 
            // cLabelDesc3
            // 
            cLabelDesc3.AutoSize = true;
            cLabelDesc3.Font = new Font("Poppins", 10F);
            cLabelDesc3.Location = new Point(23, 105);
            cLabelDesc3.Name = "cLabelDesc3";
            cLabelDesc3.Size = new Size(77, 25);
            cLabelDesc3.TabIndex = 3;
            cLabelDesc3.Text = "UserLevel";
            // 
            // cLabelDesc2
            // 
            cLabelDesc2.AutoSize = true;
            cLabelDesc2.Font = new Font("Poppins", 10F);
            cLabelDesc2.Location = new Point(23, 69);
            cLabelDesc2.Name = "cLabelDesc2";
            cLabelDesc2.Size = new Size(86, 25);
            cLabelDesc2.TabIndex = 2;
            cLabelDesc2.Text = "Username:";
            // 
            // cLabelDesc1
            // 
            cLabelDesc1.AutoSize = true;
            cLabelDesc1.Font = new Font("Poppins", 10F);
            cLabelDesc1.Location = new Point(23, 34);
            cLabelDesc1.Name = "cLabelDesc1";
            cLabelDesc1.Size = new Size(58, 25);
            cLabelDesc1.TabIndex = 1;
            cLabelDesc1.Text = "UserID:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(cLabelTitle3);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(512, 267);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(toolStrip3);
            panel7.Controls.Add(cDatagridview3);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(510, 227);
            panel7.TabIndex = 3;
            // 
            // toolStrip3
            // 
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.Items.AddRange(new ToolStripItem[] { tsbAddUserInfo, toolStripSeparator3, tsbRemoveUserInfo });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(508, 25);
            toolStrip3.TabIndex = 1;
            toolStrip3.Text = "toolStrip3";
            // 
            // tsbAddUserInfo
            // 
            tsbAddUserInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAddUserInfo.Image = (Image)resources.GetObject("tsbAddUserInfo.Image");
            tsbAddUserInfo.ImageTransparentColor = Color.Magenta;
            tsbAddUserInfo.Name = "tsbAddUserInfo";
            tsbAddUserInfo.Size = new Size(23, 22);
            tsbAddUserInfo.Text = "toolStripButton1";
            tsbAddUserInfo.Click += tsbAddUserInfo_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // tsbRemoveUserInfo
            // 
            tsbRemoveUserInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbRemoveUserInfo.Image = (Image)resources.GetObject("tsbRemoveUserInfo.Image");
            tsbRemoveUserInfo.ImageTransparentColor = Color.Magenta;
            tsbRemoveUserInfo.Name = "tsbRemoveUserInfo";
            tsbRemoveUserInfo.Size = new Size(23, 22);
            tsbRemoveUserInfo.Text = "toolStripButton1";
            // 
            // cDatagridview3
            // 
            cDatagridview3.AllowUserToAddRows = false;
            cDatagridview3.AllowUserToDeleteRows = false;
            cDatagridview3.AllowUserToOrderColumns = true;
            cDatagridview3.AllowUserToResizeRows = false;
            cDatagridview3.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle9.BackColor = Color.LightGray;
            cDatagridview3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            cDatagridview3.AutoGenerateColumns = false;
            cDatagridview3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cDatagridview3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cDatagridview3.BackgroundColor = Color.FromArgb(240, 240, 240);
            cDatagridview3.BorderStyle = BorderStyle.None;
            cDatagridview3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            cDatagridview3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            cDatagridview3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cDatagridview3.Columns.AddRange(new DataGridViewColumn[] { firstnameDataGridViewTextBoxColumn, middlenameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn, relationshipDataGridViewTextBoxColumn });
            cDatagridview3.CustomHeaderFontStyle = new Font("Poppins", 12F);
            cDatagridview3.CustomHeaderForeColor = Color.Black;
            cDatagridview3.CustomRowFontStyle = new Font("Poppins", 10F);
            cDatagridview3.DataSource = userInformationDTOBindingSource;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            cDatagridview3.DefaultCellStyle = dataGridViewCellStyle11;
            cDatagridview3.Dock = DockStyle.Bottom;
            cDatagridview3.EnableHeadersVisualStyles = false;
            cDatagridview3.HeaderColor = Color.WhiteSmoke;
            cDatagridview3.Location = new Point(0, 28);
            cDatagridview3.Name = "cDatagridview3";
            cDatagridview3.ReadOnly = true;
            cDatagridview3.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            cDatagridview3.RowsDefaultCellStyle = dataGridViewCellStyle12;
            cDatagridview3.SelectionColor = Color.FromArgb(128, 128, 255);
            cDatagridview3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cDatagridview3.Size = new Size(508, 197);
            cDatagridview3.TabIndex = 0;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationshipDataGridViewTextBoxColumn
            // 
            relationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship";
            relationshipDataGridViewTextBoxColumn.HeaderText = "Relationship";
            relationshipDataGridViewTextBoxColumn.Name = "relationshipDataGridViewTextBoxColumn";
            relationshipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userInformationDTOBindingSource
            // 
            userInformationDTOBindingSource.DataSource = typeof(DTO.UserInformationDTO);
            // 
            // cLabelTitle3
            // 
            cLabelTitle3.AutoSize = true;
            cLabelTitle3.Font = new Font("Poppins", 15F, FontStyle.Bold);
            cLabelTitle3.Location = new Point(3, 0);
            cLabelTitle3.Name = "cLabelTitle3";
            cLabelTitle3.Size = new Size(143, 36);
            cLabelTitle3.TabIndex = 2;
            cLabelTitle3.Text = "User Info List";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(cLabelTitle1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(514, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 212);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(cDatagridview1);
            panel5.Controls.Add(toolStrip1);
            panel5.Location = new Point(5, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(762, 166);
            panel5.TabIndex = 1;
            // 
            // cDatagridview1
            // 
            cDatagridview1.AllowUserToAddRows = false;
            cDatagridview1.AllowUserToDeleteRows = false;
            cDatagridview1.AllowUserToOrderColumns = true;
            cDatagridview1.AllowUserToResizeRows = false;
            cDatagridview1.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            cDatagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            cDatagridview1.AutoGenerateColumns = false;
            cDatagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cDatagridview1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cDatagridview1.BackgroundColor = Color.FromArgb(240, 240, 240);
            cDatagridview1.BorderStyle = BorderStyle.None;
            cDatagridview1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            cDatagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            cDatagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cDatagridview1.Columns.AddRange(new DataGridViewColumn[] { bankNameDataGridViewTextBoxColumn, bankAccountNoDataGridViewTextBoxColumn, bankTypeDataGridViewTextBoxColumn });
            cDatagridview1.CustomHeaderFontStyle = new Font("Poppins", 12F);
            cDatagridview1.CustomHeaderForeColor = Color.Black;
            cDatagridview1.CustomRowFontStyle = new Font("Poppins", 10F);
            cDatagridview1.DataSource = userBankDTOBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            cDatagridview1.DefaultCellStyle = dataGridViewCellStyle7;
            cDatagridview1.Dock = DockStyle.Bottom;
            cDatagridview1.EnableHeadersVisualStyles = false;
            cDatagridview1.HeaderColor = Color.WhiteSmoke;
            cDatagridview1.Location = new Point(0, 28);
            cDatagridview1.Name = "cDatagridview1";
            cDatagridview1.ReadOnly = true;
            cDatagridview1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            cDatagridview1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            cDatagridview1.SelectionColor = Color.FromArgb(128, 128, 255);
            cDatagridview1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cDatagridview1.Size = new Size(760, 136);
            cDatagridview1.TabIndex = 1;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankAccountNoDataGridViewTextBoxColumn
            // 
            bankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.Name = "bankAccountNoDataGridViewTextBoxColumn";
            bankAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankTypeDataGridViewTextBoxColumn
            // 
            bankTypeDataGridViewTextBoxColumn.DataPropertyName = "BankType";
            bankTypeDataGridViewTextBoxColumn.HeaderText = "BankType";
            bankTypeDataGridViewTextBoxColumn.Name = "bankTypeDataGridViewTextBoxColumn";
            bankTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBankDTOBindingSource
            // 
            userBankDTOBindingSource.DataSource = typeof(DTO.UserBankDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAddBank, toolStripSeparator1, tsbRemoveBank });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(760, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddBank
            // 
            tsbAddBank.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAddBank.Image = (Image)resources.GetObject("tsbAddBank.Image");
            tsbAddBank.ImageTransparentColor = Color.Magenta;
            tsbAddBank.Name = "tsbAddBank";
            tsbAddBank.Size = new Size(23, 22);
            tsbAddBank.Text = "toolStripButton1";
            tsbAddBank.Click += tsbAddBank_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbRemoveBank
            // 
            tsbRemoveBank.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbRemoveBank.Image = (Image)resources.GetObject("tsbRemoveBank.Image");
            tsbRemoveBank.ImageTransparentColor = Color.Magenta;
            tsbRemoveBank.Name = "tsbRemoveBank";
            tsbRemoveBank.Size = new Size(23, 22);
            tsbRemoveBank.Text = "toolStripButton1";
            // 
            // cLabelTitle1
            // 
            cLabelTitle1.AutoSize = true;
            cLabelTitle1.Font = new Font("Poppins", 15F, FontStyle.Bold);
            cLabelTitle1.Location = new Point(5, 2);
            cLabelTitle1.Name = "cLabelTitle1";
            cLabelTitle1.Size = new Size(106, 36);
            cLabelTitle1.TabIndex = 0;
            cLabelTitle1.Text = "Bank List";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(cLabelTitle2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(514, 218);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 269);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(cDatagridview2);
            panel6.Controls.Add(toolStrip2);
            panel6.Location = new Point(6, 39);
            panel6.Name = "panel6";
            panel6.Size = new Size(761, 229);
            panel6.TabIndex = 2;
            // 
            // cDatagridview2
            // 
            cDatagridview2.AllowUserToAddRows = false;
            cDatagridview2.AllowUserToDeleteRows = false;
            cDatagridview2.AllowUserToOrderColumns = true;
            cDatagridview2.AllowUserToResizeRows = false;
            cDatagridview2.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            cDatagridview2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            cDatagridview2.AutoGenerateColumns = false;
            cDatagridview2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cDatagridview2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cDatagridview2.BackgroundColor = Color.FromArgb(240, 240, 240);
            cDatagridview2.BorderStyle = BorderStyle.None;
            cDatagridview2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            cDatagridview2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cDatagridview2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cDatagridview2.Columns.AddRange(new DataGridViewColumn[] { bankAccountNoDataGridViewTextBoxColumn1, bankNameDataGridViewTextBoxColumn1, remainingBalanceDataGridViewTextBoxColumn, dateUpdatedDataGridViewTextBoxColumn });
            cDatagridview2.CustomHeaderFontStyle = new Font("Poppins", 12F);
            cDatagridview2.CustomHeaderForeColor = Color.Black;
            cDatagridview2.CustomRowFontStyle = new Font("Poppins", 10F);
            cDatagridview2.DataSource = userBankAccountDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            cDatagridview2.DefaultCellStyle = dataGridViewCellStyle3;
            cDatagridview2.Dock = DockStyle.Bottom;
            cDatagridview2.EnableHeadersVisualStyles = false;
            cDatagridview2.HeaderColor = Color.WhiteSmoke;
            cDatagridview2.Location = new Point(0, 28);
            cDatagridview2.Name = "cDatagridview2";
            cDatagridview2.ReadOnly = true;
            cDatagridview2.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            cDatagridview2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            cDatagridview2.SelectionColor = Color.FromArgb(128, 128, 255);
            cDatagridview2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cDatagridview2.Size = new Size(759, 199);
            cDatagridview2.TabIndex = 1;
            // 
            // userBankAccountDTOBindingSource
            // 
            userBankAccountDTOBindingSource.DataSource = typeof(DTO.UserBankAccountDTO);
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbAddBankAccount, toolStripSeparator2, tsbRemoveBankAccount });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(759, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsbAddBankAccount
            // 
            tsbAddBankAccount.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAddBankAccount.Image = (Image)resources.GetObject("tsbAddBankAccount.Image");
            tsbAddBankAccount.ImageTransparentColor = Color.Magenta;
            tsbAddBankAccount.Name = "tsbAddBankAccount";
            tsbAddBankAccount.Size = new Size(23, 22);
            tsbAddBankAccount.Text = "toolStripButton1";
            tsbAddBankAccount.Click += tsbAddBankAccount_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbRemoveBankAccount
            // 
            tsbRemoveBankAccount.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbRemoveBankAccount.Image = (Image)resources.GetObject("tsbRemoveBankAccount.Image");
            tsbRemoveBankAccount.ImageTransparentColor = Color.Magenta;
            tsbRemoveBankAccount.Name = "tsbRemoveBankAccount";
            tsbRemoveBankAccount.Size = new Size(23, 22);
            tsbRemoveBankAccount.Text = "toolStripButton1";
            // 
            // cLabelTitle2
            // 
            cLabelTitle2.AutoSize = true;
            cLabelTitle2.Font = new Font("Poppins", 15F, FontStyle.Bold);
            cLabelTitle2.Location = new Point(5, 0);
            cLabelTitle2.Name = "cLabelTitle2";
            cLabelTitle2.Size = new Size(196, 36);
            cLabelTitle2.TabIndex = 1;
            cLabelTitle2.Text = "Bank Account List";
            // 
            // bankAccountNoDataGridViewTextBoxColumn1
            // 
            bankAccountNoDataGridViewTextBoxColumn1.DataPropertyName = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn1.HeaderText = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn1.Name = "bankAccountNoDataGridViewTextBoxColumn1";
            bankAccountNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bankNameDataGridViewTextBoxColumn1
            // 
            bankNameDataGridViewTextBoxColumn1.DataPropertyName = "BankName";
            bankNameDataGridViewTextBoxColumn1.HeaderText = "BankName";
            bankNameDataGridViewTextBoxColumn1.Name = "bankNameDataGridViewTextBoxColumn1";
            bankNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // remainingBalanceDataGridViewTextBoxColumn
            // 
            remainingBalanceDataGridViewTextBoxColumn.DataPropertyName = "RemainingBalance";
            remainingBalanceDataGridViewTextBoxColumn.HeaderText = "RemainingBalance";
            remainingBalanceDataGridViewTextBoxColumn.Name = "remainingBalanceDataGridViewTextBoxColumn";
            remainingBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            dateUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageUserBankInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 669);
            Name = "ManageUserBankInfo";
            Text = "ManageUserBanks";
            basePnl2.ResumeLayout(false);
            PanelMain3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview3).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInformationDTOBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBankDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBankAccountDTOBindingSource).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle1;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle2;
        private Panel panel4;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic4;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic3;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic2;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic1;
        private BindingSource userDTOBindingSource;
        private Panel panel5;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAddBank;
        private ToolStripButton tsbRemoveBank;
        private Panel panel6;
        private ToolStrip toolStrip2;
        private ToolStripButton tsbAddBankAccount;
        private ToolStripButton tsbRemoveBankAccount;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private FerPROJ.Design.Controls.CDatagridview cDatagridview1;
        private FerPROJ.Design.Controls.CDatagridview cDatagridview2;
        private BindingSource userBankAccountDTOBindingSource;
        private BindingSource userBankDTOBindingSource;
        private Panel panel7;
        private ToolStrip toolStrip3;
        private ToolStripButton tsbAddUserInfo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbRemoveUserInfo;
        private FerPROJ.Design.Controls.CDatagridview cDatagridview3;
        private BindingSource userInformationDTOBindingSource;
        private DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankAccountNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn relationshipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankAccountNoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn remainingBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
    }
}