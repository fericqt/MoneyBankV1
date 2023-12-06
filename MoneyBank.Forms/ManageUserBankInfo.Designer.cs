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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserBankInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cTextBoxBasic5 = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
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
            this.dgvUserInfo = new FerPROJ.Design.Controls.CDatagridview();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInformationDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLabelTitle3 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUserBank = new FerPROJ.Design.Controls.CDatagridview();
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
            this.dgvUserBankAccount = new FerPROJ.Design.Controls.CDatagridview();
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationDTOBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBankDTOBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBankAccount)).BeginInit();
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
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserDTO);
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
            this.panel7.Controls.Add(this.dgvUserInfo);
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
            this.toolStripSeparator6,
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
            this.tsbRemoveUserInfo.Click += new System.EventHandler(this.tsbRemoveUserInfo_Click);
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.AllowUserToOrderColumns = true;
            this.dgvUserInfo.AllowUserToResizeRows = false;
            this.dgvUserInfo.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            this.dgvUserInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUserInfo.AutoGenerateColumns = false;
            this.dgvUserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.relationshipDataGridViewTextBoxColumn});
            this.dgvUserInfo.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvUserInfo.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvUserInfo.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvUserInfo.DataSource = this.userInformationDTOBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserInfo.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserInfo.EnableHeadersVisualStyles = false;
            this.dgvUserInfo.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUserInfo.Location = new System.Drawing.Point(0, 24);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUserInfo.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(435, 171);
            this.dgvUserInfo.TabIndex = 0;
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
            this.panel5.Controls.Add(this.dgvUserBank);
            this.panel5.Controls.Add(this.toolStrip1);
            this.panel5.Location = new System.Drawing.Point(4, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(653, 144);
            this.panel5.TabIndex = 1;
            // 
            // dgvUserBank
            // 
            this.dgvUserBank.AllowUserToAddRows = false;
            this.dgvUserBank.AllowUserToDeleteRows = false;
            this.dgvUserBank.AllowUserToOrderColumns = true;
            this.dgvUserBank.AllowUserToResizeRows = false;
            this.dgvUserBank.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dgvUserBank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserBank.AutoGenerateColumns = false;
            this.dgvUserBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserBank.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserBank.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvUserBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserBank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankNameDataGridViewTextBoxColumn,
            this.bankAccountNoDataGridViewTextBoxColumn,
            this.bankTypeDataGridViewTextBoxColumn});
            this.dgvUserBank.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvUserBank.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvUserBank.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvUserBank.DataSource = this.userBankDTOBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserBank.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUserBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserBank.EnableHeadersVisualStyles = false;
            this.dgvUserBank.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUserBank.Location = new System.Drawing.Point(0, 24);
            this.dgvUserBank.Name = "dgvUserBank";
            this.dgvUserBank.ReadOnly = true;
            this.dgvUserBank.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserBank.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUserBank.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvUserBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserBank.Size = new System.Drawing.Size(651, 118);
            this.dgvUserBank.TabIndex = 1;
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
            this.toolStripSeparator4,
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
            this.tsbRemoveBank.Click += new System.EventHandler(this.tsbRemoveBank_Click);
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
            this.panel6.Controls.Add(this.dgvUserBankAccount);
            this.panel6.Controls.Add(this.toolStrip2);
            this.panel6.Location = new System.Drawing.Point(5, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(653, 199);
            this.panel6.TabIndex = 2;
            // 
            // dgvUserBankAccount
            // 
            this.dgvUserBankAccount.AllowUserToAddRows = false;
            this.dgvUserBankAccount.AllowUserToDeleteRows = false;
            this.dgvUserBankAccount.AllowUserToOrderColumns = true;
            this.dgvUserBankAccount.AllowUserToResizeRows = false;
            this.dgvUserBankAccount.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvUserBankAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserBankAccount.AutoGenerateColumns = false;
            this.dgvUserBankAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserBankAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserBankAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvUserBankAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserBankAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserBankAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserBankAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserBankAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankAccountNoDataGridViewTextBoxColumn1,
            this.bankNameDataGridViewTextBoxColumn1,
            this.remainingBalanceDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn});
            this.dgvUserBankAccount.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvUserBankAccount.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvUserBankAccount.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvUserBankAccount.DataSource = this.userBankAccountDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserBankAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserBankAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserBankAccount.EnableHeadersVisualStyles = false;
            this.dgvUserBankAccount.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUserBankAccount.Location = new System.Drawing.Point(0, 25);
            this.dgvUserBankAccount.Name = "dgvUserBankAccount";
            this.dgvUserBankAccount.ReadOnly = true;
            this.dgvUserBankAccount.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserBankAccount.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserBankAccount.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvUserBankAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserBankAccount.Size = new System.Drawing.Size(651, 172);
            this.dgvUserBankAccount.TabIndex = 1;
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
            this.toolStripSeparator5,
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
            this.tsbRemoveBankAccount.Click += new System.EventHandler(this.tsbRemoveBankAccount_Click);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationDTOBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBankDTOBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBankAccount)).EndInit();
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
        private FerPROJ.Design.Controls.CDatagridview dgvUserBank;
        private FerPROJ.Design.Controls.CDatagridview dgvUserBankAccount;
        private BindingSource userBankAccountDTOBindingSource;
        private BindingSource userBankDTOBindingSource;
        private Panel panel7;
        private ToolStrip toolStrip3;
        private ToolStripButton tsbAddUserInfo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbRemoveUserInfo;
        private FerPROJ.Design.Controls.CDatagridview dgvUserInfo;
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
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
    }
}