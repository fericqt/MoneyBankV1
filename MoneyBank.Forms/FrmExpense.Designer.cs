using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class FrmExpense {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvExpense = new FerPROJ.Design.Controls.CDatagridview();
            expenseDTOBindingSource = new BindingSource(components);
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseTransNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankAccountNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalExpenseAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // baseButtonSelect
            // 
            baseButtonSelect.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain4
            // 
            PanelMain4.Controls.Add(dgvExpense);
            PanelMain4.Size = new Size(1130, 444);
            PanelMain4.Controls.SetChildIndex(dgvExpense, 0);
            // 
            // dgvExpense
            // 
            dgvExpense.AllowUserToAddRows = false;
            dgvExpense.AllowUserToDeleteRows = false;
            dgvExpense.AllowUserToOrderColumns = true;
            dgvExpense.AllowUserToResizeRows = false;
            dgvExpense.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvExpense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExpense.AutoGenerateColumns = false;
            dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpense.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExpense.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvExpense.BorderStyle = BorderStyle.None;
            dgvExpense.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Columns.AddRange(new DataGridViewColumn[] { dateReferenceDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, expenseTransNoDataGridViewTextBoxColumn, bankAccountNoDataGridViewTextBoxColumn, totalExpenseAmountDataGridViewTextBoxColumn });
            dgvExpense.CustomHeaderFontStyle = new Font("Poppins", 12F);
            dgvExpense.CustomHeaderForeColor = Color.Black;
            dgvExpense.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvExpense.DataSource = expenseDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvExpense.DefaultCellStyle = dataGridViewCellStyle3;
            dgvExpense.Dock = DockStyle.Fill;
            dgvExpense.EnableHeadersVisualStyles = false;
            dgvExpense.HeaderColor = Color.WhiteSmoke;
            dgvExpense.Location = new Point(0, 47);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.ReadOnly = true;
            dgvExpense.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvExpense.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvExpense.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpense.Size = new Size(1130, 315);
            dgvExpense.TabIndex = 5;
            // 
            // expenseDTOBindingSource
            // 
            expenseDTOBindingSource.DataSource = typeof(DTO.ExpenseDTO);
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseTransNoDataGridViewTextBoxColumn
            // 
            expenseTransNoDataGridViewTextBoxColumn.DataPropertyName = "ExpenseTransNo";
            expenseTransNoDataGridViewTextBoxColumn.HeaderText = "ExpenseTransNo";
            expenseTransNoDataGridViewTextBoxColumn.Name = "expenseTransNoDataGridViewTextBoxColumn";
            expenseTransNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankAccountNoDataGridViewTextBoxColumn
            // 
            bankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.Name = "bankAccountNoDataGridViewTextBoxColumn";
            bankAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalExpenseAmountDataGridViewTextBoxColumn
            // 
            totalExpenseAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalExpenseAmount";
            totalExpenseAmountDataGridViewTextBoxColumn.HeaderText = "TotalExpenseAmount";
            totalExpenseAmountDataGridViewTextBoxColumn.Name = "totalExpenseAmountDataGridViewTextBoxColumn";
            totalExpenseAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 544);
            Name = "FrmExpense";
            Text = "FrmExpense";
            PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvExpense;
        private BindingSource expenseDTOBindingSource;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseTransNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankAccountNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalExpenseAmountDataGridViewTextBoxColumn;
    }
}