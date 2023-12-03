using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class FrmReceiveTypes {
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
            dgvReceiveTypes = new FerPROJ.Design.Controls.CDatagridview();
            receiveTypeDTOBindingSource = new BindingSource(components);
            idTrackDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receiveNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            receiveTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceiveTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receiveTypeDTOBindingSource).BeginInit();
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
            PanelMain4.Controls.Add(dgvReceiveTypes);
            PanelMain4.Size = new Size(1004, 437);
            PanelMain4.Controls.SetChildIndex(dgvReceiveTypes, 0);
            // 
            // dgvReceiveTypes
            // 
            dgvReceiveTypes.AllowUserToAddRows = false;
            dgvReceiveTypes.AllowUserToDeleteRows = false;
            dgvReceiveTypes.AllowUserToOrderColumns = true;
            dgvReceiveTypes.AllowUserToResizeRows = false;
            dgvReceiveTypes.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvReceiveTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReceiveTypes.AutoGenerateColumns = false;
            dgvReceiveTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceiveTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReceiveTypes.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvReceiveTypes.BorderStyle = BorderStyle.None;
            dgvReceiveTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReceiveTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReceiveTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiveTypes.Columns.AddRange(new DataGridViewColumn[] { idTrackDataGridViewTextBoxColumn, dateReferenceDataGridViewTextBoxColumn, receiveNoDataGridViewTextBoxColumn, receiveTypeDataGridViewTextBoxColumn });
            dgvReceiveTypes.CustomHeaderFontStyle = new Font("Poppins", 12F);
            dgvReceiveTypes.CustomHeaderForeColor = Color.Black;
            dgvReceiveTypes.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvReceiveTypes.DataSource = receiveTypeDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReceiveTypes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReceiveTypes.Dock = DockStyle.Fill;
            dgvReceiveTypes.EnableHeadersVisualStyles = false;
            dgvReceiveTypes.HeaderColor = Color.WhiteSmoke;
            dgvReceiveTypes.Location = new Point(0, 47);
            dgvReceiveTypes.Name = "dgvReceiveTypes";
            dgvReceiveTypes.ReadOnly = true;
            dgvReceiveTypes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReceiveTypes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvReceiveTypes.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvReceiveTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiveTypes.Size = new Size(1004, 308);
            dgvReceiveTypes.TabIndex = 5;
            // 
            // receiveTypeDTOBindingSource
            // 
            receiveTypeDTOBindingSource.DataSource = typeof(DTO.ReceiveTypeDTO);
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
            // receiveNoDataGridViewTextBoxColumn
            // 
            receiveNoDataGridViewTextBoxColumn.DataPropertyName = "ReceiveNo";
            receiveNoDataGridViewTextBoxColumn.HeaderText = "ReceiveNo";
            receiveNoDataGridViewTextBoxColumn.Name = "receiveNoDataGridViewTextBoxColumn";
            receiveNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveTypeDataGridViewTextBoxColumn
            // 
            receiveTypeDataGridViewTextBoxColumn.DataPropertyName = "ReceiveType";
            receiveTypeDataGridViewTextBoxColumn.HeaderText = "ReceiveType";
            receiveTypeDataGridViewTextBoxColumn.Name = "receiveTypeDataGridViewTextBoxColumn";
            receiveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmReceiveTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 537);
            Name = "FrmReceiveTypes";
            Text = "FrmReceiveTypes";
            PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReceiveTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)receiveTypeDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvReceiveTypes;
        private DataGridViewTextBoxColumn idTrackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveTypeDataGridViewTextBoxColumn;
        private BindingSource receiveTypeDTOBindingSource;
    }
}