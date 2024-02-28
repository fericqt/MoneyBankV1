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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReceiveTypes = new FerPROJ.Design.Controls.CDatagridview();
            this.receiveTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveTypeDTOBindingSource)).BeginInit();
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
            this.PanelMain4.Controls.Add(this.dgvReceiveTypes);
            this.PanelMain4.Size = new System.Drawing.Size(864, 382);
            this.PanelMain4.Controls.SetChildIndex(this.dgvReceiveTypes, 0);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3);
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.SearchTextBox.Size = new System.Drawing.Size(305, 31);
            // 
            // dgvReceiveTypes
            // 
            this.dgvReceiveTypes.AllowUserToAddRows = false;
            this.dgvReceiveTypes.AllowUserToDeleteRows = false;
            this.dgvReceiveTypes.AllowUserToOrderColumns = true;
            this.dgvReceiveTypes.AllowUserToResizeRows = false;
            this.dgvReceiveTypes.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvReceiveTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiveTypes.AutoGenerateColumns = false;
            this.dgvReceiveTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiveTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceiveTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReceiveTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceiveTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiveTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceiveTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiveTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrackDataGridViewTextBoxColumn,
            this.receiveTypeDataGridViewTextBoxColumn,
            this.dateReferenceDataGridViewTextBoxColumn});
            this.dgvReceiveTypes.CustomHeaderFontStyle = new System.Drawing.Font("Poppins", 12F);
            this.dgvReceiveTypes.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvReceiveTypes.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvReceiveTypes.DataSource = this.receiveTypeDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiveTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceiveTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceiveTypes.EnableHeadersVisualStyles = false;
            this.dgvReceiveTypes.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReceiveTypes.Location = new System.Drawing.Point(0, 41);
            this.dgvReceiveTypes.Name = "dgvReceiveTypes";
            this.dgvReceiveTypes.ReadOnly = true;
            this.dgvReceiveTypes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiveTypes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceiveTypes.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvReceiveTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiveTypes.Size = new System.Drawing.Size(864, 270);
            this.dgvReceiveTypes.TabIndex = 5;
            // 
            // receiveTypeDTOBindingSource
            // 
            this.receiveTypeDTOBindingSource.DataSource = typeof(MoneyBank.DTO.ReceiveTypeDTO);
            // 
            // idTrackDataGridViewTextBoxColumn
            // 
            this.idTrackDataGridViewTextBoxColumn.DataPropertyName = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.HeaderText = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.Name = "idTrackDataGridViewTextBoxColumn";
            this.idTrackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveTypeDataGridViewTextBoxColumn
            // 
            this.receiveTypeDataGridViewTextBoxColumn.DataPropertyName = "ReceiveType";
            this.receiveTypeDataGridViewTextBoxColumn.HeaderText = "ReceiveType";
            this.receiveTypeDataGridViewTextBoxColumn.Name = "receiveTypeDataGridViewTextBoxColumn";
            this.receiveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            this.dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            this.dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            this.dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            this.dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmReceiveTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 465);
            this.Name = "FrmReceiveTypes";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FrmReceiveTypes";
            this.PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveTypeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CDatagridview dgvReceiveTypes;
        private DataGridViewTextBoxColumn receiveNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTrackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiveTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private BindingSource receiveTypeDTOBindingSource;
    }
}