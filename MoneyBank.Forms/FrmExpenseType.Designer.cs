using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class FrmExpenseType {
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvExpenseType = new FerPROJ.Design.Controls.CDatagridview();
            expenseTypeDTOBindingSource = new BindingSource(components);
            idTrackDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenseType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseTypeDTOBindingSource).BeginInit();
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
            PanelMain4.Controls.Add(dgvExpenseType);
            PanelMain4.Size = new Size(1017, 460);
            PanelMain4.Controls.SetChildIndex(dgvExpenseType, 0);
            // 
            // dgvExpenseType
            // 
            dgvExpenseType.AllowUserToAddRows = false;
            dgvExpenseType.AllowUserToDeleteRows = false;
            dgvExpenseType.AllowUserToOrderColumns = true;
            dgvExpenseType.AllowUserToResizeRows = false;
            dgvExpenseType.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dgvExpenseType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvExpenseType.AutoGenerateColumns = false;
            dgvExpenseType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenseType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExpenseType.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvExpenseType.BorderStyle = BorderStyle.None;
            dgvExpenseType.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvExpenseType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvExpenseType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenseType.Columns.AddRange(new DataGridViewColumn[] { idTrackDataGridViewTextBoxColumn, dateReferenceDataGridViewTextBoxColumn, expenseNoDataGridViewTextBoxColumn, expenseNameDataGridViewTextBoxColumn });
            dgvExpenseType.CustomHeaderFontStyle = new Font("Poppins", 12F);
            dgvExpenseType.CustomHeaderForeColor = Color.Black;
            dgvExpenseType.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvExpenseType.DataSource = expenseTypeDTOBindingSource;
            dgvExpenseType.Dock = DockStyle.Fill;
            dgvExpenseType.EnableHeadersVisualStyles = false;
            dgvExpenseType.HeaderColor = Color.WhiteSmoke;
            dgvExpenseType.Location = new Point(0, 47);
            dgvExpenseType.Name = "dgvExpenseType";
            dgvExpenseType.ReadOnly = true;
            dgvExpenseType.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvExpenseType.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvExpenseType.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvExpenseType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenseType.Size = new Size(1017, 331);
            dgvExpenseType.TabIndex = 5;
            // 
            // expenseTypeDTOBindingSource
            // 
            expenseTypeDTOBindingSource.DataSource = typeof(DTO.ExpenseTypeDTO);
            // 
            // idTrackDataGridViewTextBoxColumn
            // 
            idTrackDataGridViewTextBoxColumn.DataPropertyName = "IdTrack";
            idTrackDataGridViewTextBoxColumn.HeaderText = "IdTrack";
            idTrackDataGridViewTextBoxColumn.Name = "idTrackDataGridViewTextBoxColumn";
            idTrackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseNoDataGridViewTextBoxColumn
            // 
            expenseNoDataGridViewTextBoxColumn.DataPropertyName = "ExpenseNo";
            expenseNoDataGridViewTextBoxColumn.HeaderText = "ExpenseNo";
            expenseNoDataGridViewTextBoxColumn.Name = "expenseNoDataGridViewTextBoxColumn";
            expenseNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseNameDataGridViewTextBoxColumn
            // 
            expenseNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenseName";
            expenseNameDataGridViewTextBoxColumn.HeaderText = "ExpenseName";
            expenseNameDataGridViewTextBoxColumn.Name = "expenseNameDataGridViewTextBoxColumn";
            expenseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmExpenseType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 560);
            Name = "FrmExpenseType";
            Text = "FrmExpenseType";
            PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpenseType).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseTypeDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvExpenseType;
        private DataGridViewTextBoxColumn idTrackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseNameDataGridViewTextBoxColumn;
        private BindingSource expenseTypeDTOBindingSource;
    }
}