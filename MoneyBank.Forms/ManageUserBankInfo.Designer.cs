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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserBankInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbAddUserInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveUserInfo = new System.Windows.Forms.ToolStripButton();
            this.cDatagridview3 = new FerPROJ.Design.Controls.CDatagridview();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInformationDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelTitle3 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cDatagridview1 = new FerPROJ.Design.Controls.CDatagridview();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBankDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddBank = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveBank = new System.Windows.Forms.ToolStripButton();
            this.cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cDatagridview2 = new FerPROJ.Design.Controls.CDatagridview();
            this.bankAccountNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBankAccountDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAddBankAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveBankAccount = new System.Windows.Forms.ToolStripButton();
            this.cLabelTitle2 = new FerPROJ.Design.Controls.CLabelTitle();
            this.cTextBoxBasic5 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDatagridview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDatagridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBankDTOBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDatagridview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBankAccountDTOBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(868, 1);
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
            this.PanelMain3.Controls.Add(this.panel3);
            this.PanelMain3.Controls.Add(this.panel2);
            this.PanelMain3.Controls.Add(this.panel1);
            this.PanelMain3.Size = new System.Drawing.Size(1103, 426);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cTextBoxBasic5);
            this.panel1.Controls.Add(this.cLabelDesc5);
            this.panel1.Controls.Add(this.cTextBoxBasic4);
            this.panel1.Controls.Add(this.cTextBoxBasic3);
            this.panel1.Controls.Add(this.cTextBoxBasic2);
            this.panel1.Controls.Add(this.cTextBoxBasic1);
            this.panel1.Controls.Add(this.cLabelDesc4);
            this.panel1.Controls.Add(this.cLabelDesc3);
            this.panel1.Controls.Add(this.cLabelDesc2);
            this.panel1.Controls.Add(this.cLabelDesc1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 426);
            this.panel1.TabIndex = 0;
            // 
            // cTextBoxBasic4
            // 
            this.cTextBoxBasic4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "DateLastLogin", true));
            this.cTextBoxBasic4.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic4.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic4.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic4.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic4.Location = new System.Drawing.Point(145, 158);
            this.cTextBoxBasic4.Name = "cTextBoxBasic4";
            this.cTextBoxBasic4.Size = new System.Drawing.Size(248, 23);
            this.cTextBoxBasic4.TabIndex = 4;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserDTO);
            // 
            // cTextBoxBasic3
            // 
            this.cTextBoxBasic3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "UserLevel", true));
            this.cTextBoxBasic3.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic3.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic3.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic3.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic3.Location = new System.Drawing.Point(145, 122);
            this.cTextBoxBasic3.Name = "cTextBoxBasic3";
            this.cTextBoxBasic3.Size = new System.Drawing.Size(248, 23);
            this.cTextBoxBasic3.TabIndex = 3;
            // 
            // cTextBoxBasic2
            // 
            this.cTextBoxBasic2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Username", true));
            this.cTextBoxBasic2.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic2.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic2.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic2.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic2.Location = new System.Drawing.Point(145, 89);
            this.cTextBoxBasic2.Name = "cTextBoxBasic2";
            this.cTextBoxBasic2.Size = new System.Drawing.Size(248, 23);
            this.cTextBoxBasic2.TabIndex = 2;
            // 
            // cTextBoxBasic1
            // 
            this.cTextBoxBasic1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "UserId", true));
            this.cTextBoxBasic1.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.Enabled = false;
            this.cTextBoxBasic1.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic1.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic1.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic1.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic1.Location = new System.Drawing.Point(145, 29);
            this.cTextBoxBasic1.Name = "cTextBoxBasic1";
            this.cTextBoxBasic1.Size = new System.Drawing.Size(248, 23);
            this.cTextBoxBasic1.TabIndex = 0;
            // 
            // cLabelDesc4
            // 
            this.cLabelDesc4.AutoSize = true;
            this.cLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc4.Location = new System.Drawing.Point(20, 156);
            this.cLabelDesc4.Name = "cLabelDesc4";
            this.cLabelDesc4.Size = new System.Drawing.Size(119, 25);
            this.cLabelDesc4.TabIndex = 4;
            this.cLabelDesc4.Text = "Date Last Login:";
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(20, 122);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(77, 25);
            this.cLabelDesc3.TabIndex = 3;
            this.cLabelDesc3.Text = "UserLevel";
            // 
            // cLabelDesc2
            // 
            this.cLabelDesc2.AutoSize = true;
            this.cLabelDesc2.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc2.Location = new System.Drawing.Point(20, 91);
            this.cLabelDesc2.Name = "cLabelDesc2";
            this.cLabelDesc2.Size = new System.Drawing.Size(86, 25);
            this.cLabelDesc2.TabIndex = 2;
            this.cLabelDesc2.Text = "Username:";
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(20, 29);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(58, 25);
            this.cLabelDesc1.TabIndex = 1;
            this.cLabelDesc1.Text = "UserID:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.cLabelTitle3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 232);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.toolStrip3);
            this.panel7.Controls.Add(this.cDatagridview3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(437, 197);
            this.panel7.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddUserInfo,
            this.toolStripSeparator3,
            this.tsbRemoveUserInfo});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(435, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbAddUserInfo
            // 
            this.tsbAddUserInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddUserInfo.Image")));
            this.tsbAddUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddUserInfo.Name = "tsbAddUserInfo";
            this.tsbAddUserInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbAddUserInfo.Text = "toolStripButton1";
            this.tsbAddUserInfo.Click += new System.EventHandler(this.tsbAddUserInfo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemoveUserInfo
            // 
            this.tsbRemoveUserInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveUserInfo.Image")));
            this.tsbRemoveUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveUserInfo.Name = "tsbRemoveUserInfo";
            this.tsbRemoveUserInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveUserInfo.Text = "toolStripButton1";
            // 
            // cDatagridview3
            // 
            this.cDatagridview3.AllowUserToAddRows = false;
            this.cDatagridview3.AllowUserToDeleteRows = false;
            this.cDatagridview3.AllowUserToOrderColumns = true;
            this.cDatagridview3.AllowUserToResizeRows = false;
            this.cDatagridview3.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.LightGray;
            this.cDatagridview3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.cDatagridview3.AutoGenerateColumns = false;
            this.cDatagridview3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cDatagridview3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cDatagridview3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cDatagridview3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cDatagridview3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDatagridview3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.cDatagridview3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDatagridview3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.relationshipDataGridViewTextBoxColumn});
            this.cDatagridview3.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.cDatagridview3.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.cDatagridview3.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.cDatagridview3.DataSource = this.userInformationDTOBindingSource;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cDatagridview3.DefaultCellStyle = dataGridViewCellStyle39;
            this.cDatagridview3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDatagridview3.EnableHeadersVisualStyles = false;
            this.cDatagridview3.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.cDatagridview3.Location = new System.Drawing.Point(0, 24);
            this.cDatagridview3.Name = "cDatagridview3";
            this.cDatagridview3.ReadOnly = true;
            this.cDatagridview3.RowHeadersVisible = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDatagridview3.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.cDatagridview3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cDatagridview3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cDatagridview3.Size = new System.Drawing.Size(435, 171);
            this.cDatagridview3.TabIndex = 0;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationshipDataGridViewTextBoxColumn
            // 
            this.relationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship";
            this.relationshipDataGridViewTextBoxColumn.HeaderText = "Relationship";
            this.relationshipDataGridViewTextBoxColumn.Name = "relationshipDataGridViewTextBoxColumn";
            this.relationshipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userInformationDTOBindingSource
            // 
            this.userInformationDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserInformationDTO);
            // 
            // cLabelTitle3
            // 
            this.cLabelTitle3.AutoSize = true;
            this.cLabelTitle3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.cLabelTitle3.Location = new System.Drawing.Point(3, 0);
            this.cLabelTitle3.Name = "cLabelTitle3";
            this.cLabelTitle3.Size = new System.Drawing.Size(143, 36);
            this.cLabelTitle3.TabIndex = 2;
            this.cLabelTitle3.Text = "User Info List";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.cLabelTitle1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(441, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 184);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cDatagridview1);
            this.panel5.Controls.Add(this.toolStrip1);
            this.panel5.Location = new System.Drawing.Point(4, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(653, 144);
            this.panel5.TabIndex = 1;
            // 
            // cDatagridview1
            // 
            this.cDatagridview1.AllowUserToAddRows = false;
            this.cDatagridview1.AllowUserToDeleteRows = false;
            this.cDatagridview1.AllowUserToOrderColumns = true;
            this.cDatagridview1.AllowUserToResizeRows = false;
            this.cDatagridview1.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.LightGray;
            this.cDatagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.cDatagridview1.AutoGenerateColumns = false;
            this.cDatagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cDatagridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cDatagridview1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cDatagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cDatagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDatagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.cDatagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDatagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankNameDataGridViewTextBoxColumn,
            this.bankAccountNoDataGridViewTextBoxColumn,
            this.bankTypeDataGridViewTextBoxColumn});
            this.cDatagridview1.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.cDatagridview1.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.cDatagridview1.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.cDatagridview1.DataSource = this.userBankDTOBindingSource;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cDatagridview1.DefaultCellStyle = dataGridViewCellStyle43;
            this.cDatagridview1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDatagridview1.EnableHeadersVisualStyles = false;
            this.cDatagridview1.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.cDatagridview1.Location = new System.Drawing.Point(0, 24);
            this.cDatagridview1.Name = "cDatagridview1";
            this.cDatagridview1.ReadOnly = true;
            this.cDatagridview1.RowHeadersVisible = false;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDatagridview1.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.cDatagridview1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cDatagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cDatagridview1.Size = new System.Drawing.Size(651, 118);
            this.cDatagridview1.TabIndex = 1;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankAccountNoDataGridViewTextBoxColumn
            // 
            this.bankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo";
            this.bankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo";
            this.bankAccountNoDataGridViewTextBoxColumn.Name = "bankAccountNoDataGridViewTextBoxColumn";
            this.bankAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankTypeDataGridViewTextBoxColumn
            // 
            this.bankTypeDataGridViewTextBoxColumn.DataPropertyName = "BankType";
            this.bankTypeDataGridViewTextBoxColumn.HeaderText = "BankType";
            this.bankTypeDataGridViewTextBoxColumn.Name = "bankTypeDataGridViewTextBoxColumn";
            this.bankTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBankDTOBindingSource
            // 
            this.userBankDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserBankDTO);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddBank,
            this.toolStripSeparator1,
            this.tsbRemoveBank});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddBank
            // 
            this.tsbAddBank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddBank.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddBank.Image")));
            this.tsbAddBank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddBank.Name = "tsbAddBank";
            this.tsbAddBank.Size = new System.Drawing.Size(23, 22);
            this.tsbAddBank.Text = "toolStripButton1";
            this.tsbAddBank.Click += new System.EventHandler(this.tsbAddBank_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemoveBank
            // 
            this.tsbRemoveBank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveBank.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveBank.Image")));
            this.tsbRemoveBank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveBank.Name = "tsbRemoveBank";
            this.tsbRemoveBank.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveBank.Text = "toolStripButton1";
            // 
            // cLabelTitle1
            // 
            this.cLabelTitle1.AutoSize = true;
            this.cLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.cLabelTitle1.Location = new System.Drawing.Point(4, 2);
            this.cLabelTitle1.Name = "cLabelTitle1";
            this.cLabelTitle1.Size = new System.Drawing.Size(106, 36);
            this.cLabelTitle1.TabIndex = 0;
            this.cLabelTitle1.Text = "Bank List";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.cLabelTitle2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(441, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 233);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cDatagridview2);
            this.panel6.Controls.Add(this.toolStrip2);
            this.panel6.Location = new System.Drawing.Point(5, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(653, 199);
            this.panel6.TabIndex = 2;
            // 
            // cDatagridview2
            // 
            this.cDatagridview2.AllowUserToAddRows = false;
            this.cDatagridview2.AllowUserToDeleteRows = false;
            this.cDatagridview2.AllowUserToOrderColumns = true;
            this.cDatagridview2.AllowUserToResizeRows = false;
            this.cDatagridview2.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.LightGray;
            this.cDatagridview2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.cDatagridview2.AutoGenerateColumns = false;
            this.cDatagridview2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cDatagridview2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cDatagridview2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cDatagridview2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cDatagridview2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDatagridview2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.cDatagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDatagridview2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankAccountNoDataGridViewTextBoxColumn1,
            this.bankNameDataGridViewTextBoxColumn1,
            this.remainingBalanceDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn});
            this.cDatagridview2.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.cDatagridview2.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.cDatagridview2.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.cDatagridview2.DataSource = this.userBankAccountDTOBindingSource;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cDatagridview2.DefaultCellStyle = dataGridViewCellStyle47;
            this.cDatagridview2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDatagridview2.EnableHeadersVisualStyles = false;
            this.cDatagridview2.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.cDatagridview2.Location = new System.Drawing.Point(0, 25);
            this.cDatagridview2.Name = "cDatagridview2";
            this.cDatagridview2.ReadOnly = true;
            this.cDatagridview2.RowHeadersVisible = false;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cDatagridview2.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.cDatagridview2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cDatagridview2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cDatagridview2.Size = new System.Drawing.Size(651, 172);
            this.cDatagridview2.TabIndex = 1;
            // 
            // bankAccountNoDataGridViewTextBoxColumn1
            // 
            this.bankAccountNoDataGridViewTextBoxColumn1.DataPropertyName = "BankAccountNo";
            this.bankAccountNoDataGridViewTextBoxColumn1.HeaderText = "BankAccountNo";
            this.bankAccountNoDataGridViewTextBoxColumn1.Name = "bankAccountNoDataGridViewTextBoxColumn1";
            this.bankAccountNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bankNameDataGridViewTextBoxColumn1
            // 
            this.bankNameDataGridViewTextBoxColumn1.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn1.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn1.Name = "bankNameDataGridViewTextBoxColumn1";
            this.bankNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // remainingBalanceDataGridViewTextBoxColumn
            // 
            this.remainingBalanceDataGridViewTextBoxColumn.DataPropertyName = "RemainingBalance";
            this.remainingBalanceDataGridViewTextBoxColumn.HeaderText = "RemainingBalance";
            this.remainingBalanceDataGridViewTextBoxColumn.Name = "remainingBalanceDataGridViewTextBoxColumn";
            this.remainingBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            this.dateUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBankAccountDTOBindingSource
            // 
            this.userBankAccountDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserBankAccountDTO);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddBankAccount,
            this.toolStripSeparator2,
            this.tsbRemoveBankAccount});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(651, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAddBankAccount
            // 
            this.tsbAddBankAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddBankAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddBankAccount.Image")));
            this.tsbAddBankAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddBankAccount.Name = "tsbAddBankAccount";
            this.tsbAddBankAccount.Size = new System.Drawing.Size(23, 22);
            this.tsbAddBankAccount.Text = "toolStripButton1";
            this.tsbAddBankAccount.Click += new System.EventHandler(this.tsbAddBankAccount_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemoveBankAccount
            // 
            this.tsbRemoveBankAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveBankAccount.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveBankAccount.Image")));
            this.tsbRemoveBankAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveBankAccount.Name = "tsbRemoveBankAccount";
            this.tsbRemoveBankAccount.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveBankAccount.Text = "toolStripButton1";
            // 
            // cLabelTitle2
            // 
            this.cLabelTitle2.AutoSize = true;
            this.cLabelTitle2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.cLabelTitle2.Location = new System.Drawing.Point(4, 0);
            this.cLabelTitle2.Name = "cLabelTitle2";
            this.cLabelTitle2.Size = new System.Drawing.Size(196, 36);
            this.cLabelTitle2.TabIndex = 1;
            this.cLabelTitle2.Text = "Bank Account List";
            // 
            // cTextBoxBasic5
            // 
            this.cTextBoxBasic5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "FullName", true));
            this.cTextBoxBasic5.DefaultForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic5.EnterColor = System.Drawing.Color.LightGray;
            this.cTextBoxBasic5.Font = new System.Drawing.Font("Poppins", 8F);
            this.cTextBoxBasic5.ForeColor = System.Drawing.Color.Black;
            this.cTextBoxBasic5.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.cTextBoxBasic5.Location = new System.Drawing.Point(145, 58);
            this.cTextBoxBasic5.Name = "cTextBoxBasic5";
            this.cTextBoxBasic5.Size = new System.Drawing.Size(248, 23);
            this.cTextBoxBasic5.TabIndex = 1;
            // 
            // cLabelDesc5
            // 
            this.cLabelDesc5.AutoSize = true;
            this.cLabelDesc5.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc5.Location = new System.Drawing.Point(20, 58);
            this.cLabelDesc5.Name = "cLabelDesc5";
            this.cLabelDesc5.Size = new System.Drawing.Size(57, 25);
            this.cLabelDesc5.TabIndex = 9;
            this.cLabelDesc5.Text = "Name:";
            // 
            // ManageUserBankInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 580);
            this.Name = "ManageUserBankInfo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ManageUserBanks";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDatagridview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDatagridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBankDTOBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDatagridview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBankAccountDTOBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

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
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic5;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc5;
    }
}