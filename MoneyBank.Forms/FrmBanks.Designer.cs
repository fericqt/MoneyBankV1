using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class FrmBanks {
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
            dgvBanks = new FerPROJ.Design.Controls.CDatagridview();
            userDTOBindingSource = new BindingSource(components);
            bankDTOBindingSource = new BindingSource(components);
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankSwiftcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankProviderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankDTOBindingSource).BeginInit();
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
            PanelMain4.Controls.Add(dgvBanks);
            PanelMain4.Size = new Size(915, 350);
            PanelMain4.Controls.SetChildIndex(dgvBanks, 0);
            // 
            // dgvBanks
            // 
            dgvBanks.AllowUserToAddRows = false;
            dgvBanks.AllowUserToDeleteRows = false;
            dgvBanks.AllowUserToOrderColumns = true;
            dgvBanks.AllowUserToResizeRows = false;
            dgvBanks.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvBanks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBanks.AutoGenerateColumns = false;
            dgvBanks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBanks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBanks.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvBanks.BorderStyle = BorderStyle.None;
            dgvBanks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBanks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBanks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanks.Columns.AddRange(new DataGridViewColumn[] { dateReferenceDataGridViewTextBoxColumn, bankNameDataGridViewTextBoxColumn, bankSwiftcodeDataGridViewTextBoxColumn, bankLocationDataGridViewTextBoxColumn, bankProviderDataGridViewTextBoxColumn });
            dgvBanks.CustomHeaderFontStyle = new Font("Poppins", 12F);
            dgvBanks.CustomHeaderForeColor = Color.Black;
            dgvBanks.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvBanks.DataSource = bankDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBanks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBanks.EnableHeadersVisualStyles = false;
            dgvBanks.HeaderColor = Color.WhiteSmoke;
            dgvBanks.Location = new Point(5, 41);
            dgvBanks.Name = "dgvBanks";
            dgvBanks.ReadOnly = true;
            dgvBanks.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBanks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBanks.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvBanks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBanks.Size = new Size(907, 221);
            dgvBanks.TabIndex = 5;
            // 
            // userDTOBindingSource
            // 
            userDTOBindingSource.DataSource = typeof(DTO.UserDTO);
            // 
            // bankDTOBindingSource
            // 
            bankDTOBindingSource.DataSource = typeof(DTO.BankDTO);
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankSwiftcodeDataGridViewTextBoxColumn
            // 
            bankSwiftcodeDataGridViewTextBoxColumn.DataPropertyName = "BankSwiftcode";
            bankSwiftcodeDataGridViewTextBoxColumn.HeaderText = "BankSwiftcode";
            bankSwiftcodeDataGridViewTextBoxColumn.Name = "bankSwiftcodeDataGridViewTextBoxColumn";
            bankSwiftcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankLocationDataGridViewTextBoxColumn
            // 
            bankLocationDataGridViewTextBoxColumn.DataPropertyName = "BankLocation";
            bankLocationDataGridViewTextBoxColumn.HeaderText = "BankLocation";
            bankLocationDataGridViewTextBoxColumn.Name = "bankLocationDataGridViewTextBoxColumn";
            bankLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankProviderDataGridViewTextBoxColumn
            // 
            bankProviderDataGridViewTextBoxColumn.DataPropertyName = "BankProvider";
            bankProviderDataGridViewTextBoxColumn.HeaderText = "BankProvider";
            bankProviderDataGridViewTextBoxColumn.Name = "bankProviderDataGridViewTextBoxColumn";
            bankProviderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmBanks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Name = "FrmBanks";
            Text = "FrmBanks";
            PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBanks).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvBanks;
        private BindingSource userDTOBindingSource;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankSwiftcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankLocationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankProviderDataGridViewTextBoxColumn;
        private BindingSource bankDTOBindingSource;
    }
}