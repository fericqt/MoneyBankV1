using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageExpense {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExpense));
            this.cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvExpenseDetails = new FerPROJ.Design.Controls.CDatagridview();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cLabelDesc8 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc7 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cLabelDesc6 = new FerPROJ.Design.Controls.CLabelDesc();
            this.cmbBankAccount = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.cLabelDesc9 = new FerPROJ.Design.Controls.CLabelDesc();
            this.llUserID = new System.Windows.Forms.LinkLabel();
            this.expenseDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseDetails)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(574, 1);
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
            this.PanelMain3.Controls.Add(this.llUserID);
            this.PanelMain3.Controls.Add(this.cLabelDesc9);
            this.PanelMain3.Controls.Add(this.cmbBankAccount);
            this.PanelMain3.Controls.Add(this.cLabelDesc6);
            this.PanelMain3.Controls.Add(this.cLabelDesc5);
            this.PanelMain3.Controls.Add(this.cLabelDesc4);
            this.PanelMain3.Controls.Add(this.panel2);
            this.PanelMain3.Controls.Add(this.panel1);
            this.PanelMain3.Controls.Add(this.cLabelDesc3);
            this.PanelMain3.Controls.Add(this.cLabelDesc1);
            this.PanelMain3.Size = new System.Drawing.Size(809, 385);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            this.cLabelDesc1.AutoSize = true;
            this.cLabelDesc1.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc1.Location = new System.Drawing.Point(39, 27);
            this.cLabelDesc1.Name = "cLabelDesc1";
            this.cLabelDesc1.Size = new System.Drawing.Size(72, 25);
            this.cLabelDesc1.TabIndex = 0;
            this.cLabelDesc1.Text = "TransNo:";
            // 
            // cLabelDesc3
            // 
            this.cLabelDesc3.AutoSize = true;
            this.cLabelDesc3.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc3.Location = new System.Drawing.Point(540, 27);
            this.cLabelDesc3.Name = "cLabelDesc3";
            this.cLabelDesc3.Size = new System.Drawing.Size(125, 25);
            this.cLabelDesc3.TabIndex = 2;
            this.cLabelDesc3.Text = "Date Reference:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvExpenseDetails);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(39, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 225);
            this.panel1.TabIndex = 3;
            // 
            // dgvExpenseDetails
            // 
            this.dgvExpenseDetails.AllowUserToAddRows = false;
            this.dgvExpenseDetails.AllowUserToDeleteRows = false;
            this.dgvExpenseDetails.AllowUserToOrderColumns = true;
            this.dgvExpenseDetails.AllowUserToResizeRows = false;
            this.dgvExpenseDetails.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvExpenseDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenseDetails.AutoGenerateColumns = false;
            this.dgvExpenseDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpenseDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvExpenseDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenseDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrack,
            this.expenseNameDataGridViewTextBoxColumn,
            this.expenseAmountDataGridViewTextBoxColumn,
            this.expenseQuantityDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.expenseTotalDataGridViewTextBoxColumn});
            this.dgvExpenseDetails.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvExpenseDetails.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvExpenseDetails.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvExpenseDetails.DataSource = this.expenseDetailDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpenseDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseDetails.EnableHeadersVisualStyles = false;
            this.dgvExpenseDetails.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpenseDetails.Location = new System.Drawing.Point(0, 25);
            this.dgvExpenseDetails.Name = "dgvExpenseDetails";
            this.dgvExpenseDetails.ReadOnly = true;
            this.dgvExpenseDetails.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenseDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpenseDetails.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvExpenseDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenseDetails.Size = new System.Drawing.Size(745, 198);
            this.dgvExpenseDetails.TabIndex = 1;
            // 
            // IdTrack
            // 
            this.IdTrack.DataPropertyName = "IdTrack";
            this.IdTrack.HeaderText = "IdTrack";
            this.IdTrack.Name = "IdTrack";
            this.IdTrack.ReadOnly = true;
            this.IdTrack.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsbAdd,
            this.toolStripSeparator1,
            this.tsbRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cLabelDesc8);
            this.panel2.Controls.Add(this.cLabelDesc7);
            this.panel2.Location = new System.Drawing.Point(558, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 46);
            this.panel2.TabIndex = 4;
            // 
            // cLabelDesc8
            // 
            this.cLabelDesc8.AutoSize = true;
            this.cLabelDesc8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDTOBindingSource, "TotalExpenseAmount", true));
            this.cLabelDesc8.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc8.Location = new System.Drawing.Point(82, 11);
            this.cLabelDesc8.Name = "cLabelDesc8";
            this.cLabelDesc8.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc8.TabIndex = 9;
            this.cLabelDesc8.Text = "---";
            // 
            // cLabelDesc7
            // 
            this.cLabelDesc7.AutoSize = true;
            this.cLabelDesc7.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc7.Location = new System.Drawing.Point(11, 11);
            this.cLabelDesc7.Name = "cLabelDesc7";
            this.cLabelDesc7.Size = new System.Drawing.Size(77, 25);
            this.cLabelDesc7.TabIndex = 8;
            this.cLabelDesc7.Text = "Net Total:";
            // 
            // cLabelDesc4
            // 
            this.cLabelDesc4.AutoSize = true;
            this.cLabelDesc4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDTOBindingSource, "ExpenseTransNo", true));
            this.cLabelDesc4.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc4.Location = new System.Drawing.Point(153, 27);
            this.cLabelDesc4.Name = "cLabelDesc4";
            this.cLabelDesc4.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc4.TabIndex = 5;
            this.cLabelDesc4.Text = "---";
            // 
            // cLabelDesc5
            // 
            this.cLabelDesc5.AutoSize = true;
            this.cLabelDesc5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDTOBindingSource, "UserId", true));
            this.cLabelDesc5.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc5.Location = new System.Drawing.Point(671, 59);
            this.cLabelDesc5.Name = "cLabelDesc5";
            this.cLabelDesc5.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc5.TabIndex = 6;
            this.cLabelDesc5.Text = "---";
            // 
            // cLabelDesc6
            // 
            this.cLabelDesc6.AutoSize = true;
            this.cLabelDesc6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseDTOBindingSource, "DateReference", true));
            this.cLabelDesc6.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc6.Location = new System.Drawing.Point(671, 27);
            this.cLabelDesc6.Name = "cLabelDesc6";
            this.cLabelDesc6.Size = new System.Drawing.Size(36, 25);
            this.cLabelDesc6.TabIndex = 7;
            this.cLabelDesc6.Text = "---";
            // 
            // cmbBankAccount
            // 
            this.cmbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("PropertyTextValue", this.expenseDTOBindingSource, "BankAccountNo", true));
            this.cmbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.expenseDTOBindingSource, "BankAccountNo", true));
            this.cmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankAccount.ForeColor = System.Drawing.Color.Black;
            this.cmbBankAccount.FormattingEnabled = true;
            this.cmbBankAccount.Location = new System.Drawing.Point(158, 59);
            this.cmbBankAccount.Name = "cmbBankAccount";
            this.cmbBankAccount.PropertyText = "";
            this.cmbBankAccount.PropertyTextValue = "";
            this.cmbBankAccount.Size = new System.Drawing.Size(181, 21);
            this.cmbBankAccount.TabIndex = 8;
            // 
            // cLabelDesc9
            // 
            this.cLabelDesc9.AutoSize = true;
            this.cLabelDesc9.Font = new System.Drawing.Font("Poppins", 10F);
            this.cLabelDesc9.Location = new System.Drawing.Point(40, 59);
            this.cLabelDesc9.Name = "cLabelDesc9";
            this.cLabelDesc9.Size = new System.Drawing.Size(112, 25);
            this.cLabelDesc9.TabIndex = 9;
            this.cLabelDesc9.Text = "Bank Account:";
            // 
            // llUserID
            // 
            this.llUserID.AutoSize = true;
            this.llUserID.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUserID.Location = new System.Drawing.Point(541, 59);
            this.llUserID.Name = "llUserID";
            this.llUserID.Size = new System.Drawing.Size(54, 23);
            this.llUserID.TabIndex = 10;
            this.llUserID.TabStop = true;
            this.llUserID.Text = "User ID";
            // 
            // expenseDTOBindingSource
            // 
            this.expenseDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ExpenseDTO);
            // 
            // expenseNameDataGridViewTextBoxColumn
            // 
            this.expenseNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenseName";
            this.expenseNameDataGridViewTextBoxColumn.HeaderText = "ExpenseName";
            this.expenseNameDataGridViewTextBoxColumn.Name = "expenseNameDataGridViewTextBoxColumn";
            this.expenseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseAmountDataGridViewTextBoxColumn
            // 
            this.expenseAmountDataGridViewTextBoxColumn.DataPropertyName = "ExpenseAmount";
            this.expenseAmountDataGridViewTextBoxColumn.HeaderText = "ExpenseAmount";
            this.expenseAmountDataGridViewTextBoxColumn.Name = "expenseAmountDataGridViewTextBoxColumn";
            this.expenseAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseQuantityDataGridViewTextBoxColumn
            // 
            this.expenseQuantityDataGridViewTextBoxColumn.DataPropertyName = "ExpenseQuantity";
            this.expenseQuantityDataGridViewTextBoxColumn.HeaderText = "ExpenseQuantity";
            this.expenseQuantityDataGridViewTextBoxColumn.Name = "expenseQuantityDataGridViewTextBoxColumn";
            this.expenseQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseTotalDataGridViewTextBoxColumn
            // 
            this.expenseTotalDataGridViewTextBoxColumn.DataPropertyName = "ExpenseTotal";
            this.expenseTotalDataGridViewTextBoxColumn.HeaderText = "ExpenseTotal";
            this.expenseTotalDataGridViewTextBoxColumn.Name = "expenseTotalDataGridViewTextBoxColumn";
            this.expenseTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseDetailDTOBindingSource
            // 
            this.expenseDetailDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ExpenseDetailDTO);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(23, 22);
            this.tsbRemove.Text = "Remove";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ManageExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 539);
            this.HideSaveNew = true;
            this.Name = "ManageExpense";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ManageExpense";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseDetails)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private Panel panel2;
        private Panel panel1;
        private FerPROJ.Design.Controls.CDatagridview dgvExpenseDetails;
        private BindingSource expenseDetailDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc6;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc5;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc8;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc7;
        private BindingSource expenseDTOBindingSource;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc9;
        private FerPROJ.Design.Controls.CComboBoxBasic cmbBankAccount;
        private DataGridViewTextBoxColumn IdTrack;
        private DataGridViewTextBoxColumn expenseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseTotalDataGridViewTextBoxColumn;
        private LinkLabel llUserID;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRemove;
    }
}