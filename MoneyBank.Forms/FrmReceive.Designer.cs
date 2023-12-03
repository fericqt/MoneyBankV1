using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class FrmReceive {
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
            dgvReceive = new FerPROJ.Design.Controls.CDatagridview();
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receiveTransNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankAccountNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalReceiveAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receiveDTOBindingSource = new BindingSource(components);
            PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receiveDTOBindingSource).BeginInit();
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
            PanelMain4.Controls.Add(dgvReceive);
            PanelMain4.Size = new Size(985, 439);
            PanelMain4.Controls.SetChildIndex(dgvReceive, 0);
            // 
            // dgvReceive
            // 
            dgvReceive.AllowUserToAddRows = false;
            dgvReceive.AllowUserToDeleteRows = false;
            dgvReceive.AllowUserToOrderColumns = true;
            dgvReceive.AllowUserToResizeRows = false;
            dgvReceive.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dgvReceive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvReceive.AutoGenerateColumns = false;
            dgvReceive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceive.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReceive.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvReceive.BorderStyle = BorderStyle.None;
            dgvReceive.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvReceive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceive.Columns.AddRange(new DataGridViewColumn[] { dateReferenceDataGridViewTextBoxColumn, receiveTransNoDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, bankAccountNoDataGridViewTextBoxColumn, totalReceiveAmountDataGridViewTextBoxColumn });
            dgvReceive.CustomHeaderFontStyle = new Font("Poppins", 12F);
            dgvReceive.CustomHeaderForeColor = Color.Black;
            dgvReceive.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvReceive.DataSource = receiveDTOBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvReceive.DefaultCellStyle = dataGridViewCellStyle7;
            dgvReceive.Dock = DockStyle.Fill;
            dgvReceive.EnableHeadersVisualStyles = false;
            dgvReceive.HeaderColor = Color.WhiteSmoke;
            dgvReceive.Location = new Point(0, 47);
            dgvReceive.Name = "dgvReceive";
            dgvReceive.ReadOnly = true;
            dgvReceive.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvReceive.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvReceive.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvReceive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceive.Size = new Size(985, 310);
            dgvReceive.TabIndex = 5;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveTransNoDataGridViewTextBoxColumn
            // 
            receiveTransNoDataGridViewTextBoxColumn.DataPropertyName = "ReceiveTransNo";
            receiveTransNoDataGridViewTextBoxColumn.HeaderText = "ReceiveTransNo";
            receiveTransNoDataGridViewTextBoxColumn.Name = "receiveTransNoDataGridViewTextBoxColumn";
            receiveTransNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankAccountNoDataGridViewTextBoxColumn
            // 
            bankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.Name = "bankAccountNoDataGridViewTextBoxColumn";
            bankAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalReceiveAmountDataGridViewTextBoxColumn
            // 
            totalReceiveAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalReceiveAmount";
            totalReceiveAmountDataGridViewTextBoxColumn.HeaderText = "TotalReceiveAmount";
            totalReceiveAmountDataGridViewTextBoxColumn.Name = "totalReceiveAmountDataGridViewTextBoxColumn";
            totalReceiveAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveDTOBindingSource
            // 
            receiveDTOBindingSource.DataSource = typeof(DTO.ReceiveDTO);
            // 
            // FrmReceive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 539);
            Name = "FrmReceive";
            Text = "FrmReceive";
            PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReceive).EndInit();
            ((System.ComponentModel.ISupportInitialize)receiveDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvReceive;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveTransNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankAccountNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalReceiveAmountDataGridViewTextBoxColumn;
        private BindingSource receiveDTOBindingSource;
    }
}