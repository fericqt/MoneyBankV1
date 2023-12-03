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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExpense));
            cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            expenseDTOBindingSource = new BindingSource(components);
            panel1 = new Panel();
            cDatagridview1 = new FerPROJ.Design.Controls.CDatagridview();
            IdTrack = new DataGridViewTextBoxColumn();
            expenseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseDetailDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            panel2 = new Panel();
            cLabelDesc8 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc7 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc5 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc6 = new FerPROJ.Design.Controls.CLabelDesc();
            cmbBankAccount = new FerPROJ.Design.Controls.CComboBoxBasic();
            cLabelDesc9 = new FerPROJ.Design.Controls.CLabelDesc();
            llUserID = new LinkLabel();
            basePnl2.SuspendLayout();
            PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expenseDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseDetailDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // basePnl2
            // 
            basePnl2.Location = new Point(665, 1);
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
            PanelMain3.Controls.Add(llUserID);
            PanelMain3.Controls.Add(cLabelDesc9);
            PanelMain3.Controls.Add(cmbBankAccount);
            PanelMain3.Controls.Add(cLabelDesc6);
            PanelMain3.Controls.Add(cLabelDesc5);
            PanelMain3.Controls.Add(cLabelDesc4);
            PanelMain3.Controls.Add(panel2);
            PanelMain3.Controls.Add(panel1);
            PanelMain3.Controls.Add(cLabelDesc3);
            PanelMain3.Controls.Add(cLabelDesc1);
            PanelMain3.Size = new Size(939, 440);
            // 
            // baseButtonAddNew
            // 
            baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cLabelDesc1
            // 
            cLabelDesc1.AutoSize = true;
            cLabelDesc1.Font = new Font("Poppins", 10F);
            cLabelDesc1.Location = new Point(46, 31);
            cLabelDesc1.Name = "cLabelDesc1";
            cLabelDesc1.Size = new Size(72, 25);
            cLabelDesc1.TabIndex = 0;
            cLabelDesc1.Text = "TransNo:";
            // 
            // cLabelDesc3
            // 
            cLabelDesc3.AutoSize = true;
            cLabelDesc3.Font = new Font("Poppins", 10F);
            cLabelDesc3.Location = new Point(652, 31);
            cLabelDesc3.Name = "cLabelDesc3";
            cLabelDesc3.Size = new Size(125, 25);
            cLabelDesc3.TabIndex = 2;
            cLabelDesc3.Text = "Date Reference:";
            // 
            // expenseDTOBindingSource
            // 
            expenseDTOBindingSource.DataSource = typeof(DTO.ExpenseDTO);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cDatagridview1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(46, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 259);
            panel1.TabIndex = 3;
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
            cDatagridview1.Columns.AddRange(new DataGridViewColumn[] { IdTrack, expenseNameDataGridViewTextBoxColumn, expenseAmountDataGridViewTextBoxColumn, expenseQuantityDataGridViewTextBoxColumn, remarksDataGridViewTextBoxColumn, expenseTotalDataGridViewTextBoxColumn });
            cDatagridview1.CustomHeaderFontStyle = new Font("Poppins", 12F);
            cDatagridview1.CustomHeaderForeColor = Color.Black;
            cDatagridview1.CustomRowFontStyle = new Font("Poppins", 10F);
            cDatagridview1.DataSource = expenseDetailDTOBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            cDatagridview1.DefaultCellStyle = dataGridViewCellStyle7;
            cDatagridview1.Dock = DockStyle.Fill;
            cDatagridview1.EnableHeadersVisualStyles = false;
            cDatagridview1.HeaderColor = Color.WhiteSmoke;
            cDatagridview1.Location = new Point(0, 25);
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
            cDatagridview1.Size = new Size(869, 232);
            cDatagridview1.TabIndex = 1;
            // 
            // IdTrack
            // 
            IdTrack.DataPropertyName = "IdTrack";
            IdTrack.HeaderText = "IdTrack";
            IdTrack.Name = "IdTrack";
            IdTrack.ReadOnly = true;
            IdTrack.Visible = false;
            // 
            // expenseNameDataGridViewTextBoxColumn
            // 
            expenseNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenseName";
            expenseNameDataGridViewTextBoxColumn.HeaderText = "ExpenseName";
            expenseNameDataGridViewTextBoxColumn.Name = "expenseNameDataGridViewTextBoxColumn";
            expenseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseAmountDataGridViewTextBoxColumn
            // 
            expenseAmountDataGridViewTextBoxColumn.DataPropertyName = "ExpenseAmount";
            expenseAmountDataGridViewTextBoxColumn.HeaderText = "ExpenseAmount";
            expenseAmountDataGridViewTextBoxColumn.Name = "expenseAmountDataGridViewTextBoxColumn";
            expenseAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseQuantityDataGridViewTextBoxColumn
            // 
            expenseQuantityDataGridViewTextBoxColumn.DataPropertyName = "ExpenseQuantity";
            expenseQuantityDataGridViewTextBoxColumn.HeaderText = "ExpenseQuantity";
            expenseQuantityDataGridViewTextBoxColumn.Name = "expenseQuantityDataGridViewTextBoxColumn";
            expenseQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseTotalDataGridViewTextBoxColumn
            // 
            expenseTotalDataGridViewTextBoxColumn.DataPropertyName = "ExpenseTotal";
            expenseTotalDataGridViewTextBoxColumn.HeaderText = "ExpenseTotal";
            expenseTotalDataGridViewTextBoxColumn.Name = "expenseTotalDataGridViewTextBoxColumn";
            expenseTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseDetailDTOBindingSource
            // 
            expenseDetailDTOBindingSource.DataSource = typeof(DTO.ExpenseDetailDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(869, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(23, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cLabelDesc8);
            panel2.Controls.Add(cLabelDesc7);
            panel2.Location = new Point(651, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 53);
            panel2.TabIndex = 4;
            // 
            // cLabelDesc8
            // 
            cLabelDesc8.AutoSize = true;
            cLabelDesc8.DataBindings.Add(new Binding("Text", expenseDTOBindingSource, "TotalExpenseAmount", true));
            cLabelDesc8.Font = new Font("Poppins", 10F);
            cLabelDesc8.Location = new Point(96, 13);
            cLabelDesc8.Name = "cLabelDesc8";
            cLabelDesc8.Size = new Size(36, 25);
            cLabelDesc8.TabIndex = 9;
            cLabelDesc8.Text = "---";
            // 
            // cLabelDesc7
            // 
            cLabelDesc7.AutoSize = true;
            cLabelDesc7.Font = new Font("Poppins", 10F);
            cLabelDesc7.Location = new Point(13, 13);
            cLabelDesc7.Name = "cLabelDesc7";
            cLabelDesc7.Size = new Size(77, 25);
            cLabelDesc7.TabIndex = 8;
            cLabelDesc7.Text = "Net Total:";
            // 
            // cLabelDesc4
            // 
            cLabelDesc4.AutoSize = true;
            cLabelDesc4.DataBindings.Add(new Binding("Text", expenseDTOBindingSource, "ExpenseTransNo", true));
            cLabelDesc4.Font = new Font("Poppins", 10F);
            cLabelDesc4.Location = new Point(165, 31);
            cLabelDesc4.Name = "cLabelDesc4";
            cLabelDesc4.Size = new Size(36, 25);
            cLabelDesc4.TabIndex = 5;
            cLabelDesc4.Text = "---";
            // 
            // cLabelDesc5
            // 
            cLabelDesc5.AutoSize = true;
            cLabelDesc5.DataBindings.Add(new Binding("Text", expenseDTOBindingSource, "UserId", true));
            cLabelDesc5.Font = new Font("Poppins", 10F);
            cLabelDesc5.Location = new Point(783, 68);
            cLabelDesc5.Name = "cLabelDesc5";
            cLabelDesc5.Size = new Size(36, 25);
            cLabelDesc5.TabIndex = 6;
            cLabelDesc5.Text = "---";
            // 
            // cLabelDesc6
            // 
            cLabelDesc6.AutoSize = true;
            cLabelDesc6.DataBindings.Add(new Binding("Text", expenseDTOBindingSource, "DateReference", true));
            cLabelDesc6.Font = new Font("Poppins", 10F);
            cLabelDesc6.Location = new Point(783, 31);
            cLabelDesc6.Name = "cLabelDesc6";
            cLabelDesc6.Size = new Size(36, 25);
            cLabelDesc6.TabIndex = 7;
            cLabelDesc6.Text = "---";
            // 
            // cmbBankAccount
            // 
            cmbBankAccount.DataBindings.Add(new Binding("PropertyTextValue", expenseDTOBindingSource, "BankAccountNo", true));
            cmbBankAccount.DataBindings.Add(new Binding("SelectedValue", expenseDTOBindingSource, "BankAccountNo", true));
            cmbBankAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBankAccount.ForeColor = Color.Black;
            cmbBankAccount.FormattingEnabled = true;
            cmbBankAccount.Location = new Point(165, 68);
            cmbBankAccount.Name = "cmbBankAccount";
            cmbBankAccount.PropertyText = "";
            cmbBankAccount.PropertyTextValue = "";
            cmbBankAccount.Size = new Size(211, 23);
            cmbBankAccount.TabIndex = 8;
            // 
            // cLabelDesc9
            // 
            cLabelDesc9.AutoSize = true;
            cLabelDesc9.Font = new Font("Poppins", 10F);
            cLabelDesc9.Location = new Point(47, 68);
            cLabelDesc9.Name = "cLabelDesc9";
            cLabelDesc9.Size = new Size(112, 25);
            cLabelDesc9.TabIndex = 9;
            cLabelDesc9.Text = "Bank Account:";
            // 
            // llUserID
            // 
            llUserID.AutoSize = true;
            llUserID.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llUserID.Location = new Point(652, 68);
            llUserID.Name = "llUserID";
            llUserID.Size = new Size(54, 23);
            llUserID.TabIndex = 10;
            llUserID.TabStop = true;
            llUserID.Text = "User ID";
            llUserID.LinkClicked += llUserID_LinkClicked;
            // 
            // ManageExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 622);
            HideSaveNew = true;
            Name = "ManageExpense";
            Text = "ManageExpense";
            basePnl2.ResumeLayout(false);
            PanelMain3.ResumeLayout(false);
            PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expenseDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cDatagridview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseDetailDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private Panel panel2;
        private Panel panel1;
        private FerPROJ.Design.Controls.CDatagridview cDatagridview1;
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
    }
}