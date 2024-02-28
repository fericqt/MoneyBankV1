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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExpenseType = new FerPROJ.Design.Controls.CDatagridview();
            this.expenseTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTypeDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idTrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseButtonSelect
            // 
            this.baseButtonSelect.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain4
            // 
            this.PanelMain4.Controls.Add(this.dgvExpenseType);
            this.PanelMain4.Size = new System.Drawing.Size(875, 402);
            this.PanelMain4.Controls.SetChildIndex(this.dgvExpenseType, 0);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3);
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.SearchTextBox.Size = new System.Drawing.Size(305, 31);
            // 
            // dgvExpenseType
            // 
            this.dgvExpenseType.AllowUserToAddRows = false;
            this.dgvExpenseType.AllowUserToDeleteRows = false;
            this.dgvExpenseType.AllowUserToOrderColumns = true;
            this.dgvExpenseType.AllowUserToResizeRows = false;
            this.dgvExpenseType.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvExpenseType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenseType.AutoGenerateColumns = false;
            this.dgvExpenseType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpenseType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvExpenseType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenseType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenseType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenseType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrackDataGridViewTextBoxColumn,
            this.expenseNameDataGridViewTextBoxColumn,
            this.dateReferenceDataGridViewTextBoxColumn});
            this.dgvExpenseType.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvExpenseType.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvExpenseType.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvExpenseType.DataSource = this.expenseTypeDTOBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseType.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpenseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseType.EnableHeadersVisualStyles = false;
            this.dgvExpenseType.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpenseType.Location = new System.Drawing.Point(0, 41);
            this.dgvExpenseType.Name = "dgvExpenseType";
            this.dgvExpenseType.ReadOnly = true;
            this.dgvExpenseType.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenseType.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpenseType.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvExpenseType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenseType.Size = new System.Drawing.Size(875, 290);
            this.dgvExpenseType.TabIndex = 5;
            // 
            // expenseTypeDTOBindingSource
            // 
            this.expenseTypeDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ExpenseTypeDTO);
            // 
            // expenseTypeDTOBindingSource1
            // 
            this.expenseTypeDTOBindingSource1.DataSource = typeof(MoneyBank.DTO.ExpenseTypeDTO);
            // 
            // idTrackDataGridViewTextBoxColumn
            // 
            this.idTrackDataGridViewTextBoxColumn.DataPropertyName = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.HeaderText = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.Name = "idTrackDataGridViewTextBoxColumn";
            this.idTrackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseNameDataGridViewTextBoxColumn
            // 
            this.expenseNameDataGridViewTextBoxColumn.DataPropertyName = "ExpenseName";
            this.expenseNameDataGridViewTextBoxColumn.HeaderText = "ExpenseName";
            this.expenseNameDataGridViewTextBoxColumn.Name = "expenseNameDataGridViewTextBoxColumn";
            this.expenseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            this.dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            this.dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            this.dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            this.dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmExpenseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Name = "FrmExpenseType";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FrmExpenseType";
            this.PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvExpenseType;
        private BindingSource expenseTypeDTOBindingSource;
        private DataGridViewTextBoxColumn expenseNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTrackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private BindingSource expenseTypeDTOBindingSource1;
    }
}