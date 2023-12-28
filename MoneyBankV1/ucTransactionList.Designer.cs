using System.Drawing;
using System.Windows.Forms;

namespace MoneyBankV2 {
    partial class ucTransactionList {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTransactionList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTransactions = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTransaction = new FerPROJ.Design.Controls.CDatagridview();
            this.idTrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceTransNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cToolstrip1 = new FerPROJ.Design.Controls.CToolstrip();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTransactions.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 413);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTransactions);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTransactions
            // 
            this.tpTransactions.Controls.Add(this.dgvTransaction);
            this.tpTransactions.Controls.Add(this.toolStrip1);
            this.tpTransactions.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTransactions.Location = new System.Drawing.Point(4, 37);
            this.tpTransactions.Name = "tpTransactions";
            this.tpTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransactions.Size = new System.Drawing.Size(654, 370);
            this.tpTransactions.TabIndex = 0;
            this.tpTransactions.Text = "Transaction List";
            this.tpTransactions.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rsbRefresh
            // 
            this.rsbRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("rsbRefresh.Image")));
            this.rsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rsbRefresh.Name = "rsbRefresh";
            this.rsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.rsbRefresh.Text = "Refresh Data";
            this.rsbRefresh.Click += new System.EventHandler(this.rsbRefresh_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cToolstrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 370);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Receive List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrackDataGridViewTextBoxColumn,
            this.dateReferenceDataGridViewTextBoxColumn,
            this.transNoDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.referenceTransNoDataGridViewTextBoxColumn,
            this.bankAccountNoDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.addedDataGridViewTextBoxColumn,
            this.deductedDataGridViewTextBoxColumn,
            this.oldBalanceDataGridViewTextBoxColumn,
            this.newBalanceDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dgvTransaction.CustomHeaderFontStyle = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.dgvTransaction.CustomRowFontStyle = new System.Drawing.Font("Poppins", 10F);
            this.dgvTransaction.DataSource = this.transactionDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.EnableHeadersVisualStyles = false;
            this.dgvTransaction.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTransaction.Location = new System.Drawing.Point(3, 28);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransaction.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(648, 339);
            this.dgvTransaction.TabIndex = 0;
            // 
            // idTrackDataGridViewTextBoxColumn
            // 
            this.idTrackDataGridViewTextBoxColumn.DataPropertyName = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.HeaderText = "IdTrack";
            this.idTrackDataGridViewTextBoxColumn.Name = "idTrackDataGridViewTextBoxColumn";
            this.idTrackDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrackDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            this.dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            this.dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            this.dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            this.dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transNoDataGridViewTextBoxColumn
            // 
            this.transNoDataGridViewTextBoxColumn.DataPropertyName = "TransNo";
            this.transNoDataGridViewTextBoxColumn.HeaderText = "TransNo";
            this.transNoDataGridViewTextBoxColumn.Name = "transNoDataGridViewTextBoxColumn";
            this.transNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceTransNoDataGridViewTextBoxColumn
            // 
            this.referenceTransNoDataGridViewTextBoxColumn.DataPropertyName = "ReferenceTransNo";
            this.referenceTransNoDataGridViewTextBoxColumn.HeaderText = "ReferenceTransNo";
            this.referenceTransNoDataGridViewTextBoxColumn.Name = "referenceTransNoDataGridViewTextBoxColumn";
            this.referenceTransNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankAccountNoDataGridViewTextBoxColumn
            // 
            this.bankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo";
            this.bankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo";
            this.bankAccountNoDataGridViewTextBoxColumn.Name = "bankAccountNoDataGridViewTextBoxColumn";
            this.bankAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedDataGridViewTextBoxColumn
            // 
            this.addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            this.addedDataGridViewTextBoxColumn.HeaderText = "Added";
            this.addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            this.addedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductedDataGridViewTextBoxColumn
            // 
            this.deductedDataGridViewTextBoxColumn.DataPropertyName = "Deducted";
            this.deductedDataGridViewTextBoxColumn.HeaderText = "Deducted";
            this.deductedDataGridViewTextBoxColumn.Name = "deductedDataGridViewTextBoxColumn";
            this.deductedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldBalanceDataGridViewTextBoxColumn
            // 
            this.oldBalanceDataGridViewTextBoxColumn.DataPropertyName = "OldBalance";
            this.oldBalanceDataGridViewTextBoxColumn.HeaderText = "OldBalance";
            this.oldBalanceDataGridViewTextBoxColumn.Name = "oldBalanceDataGridViewTextBoxColumn";
            this.oldBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newBalanceDataGridViewTextBoxColumn
            // 
            this.newBalanceDataGridViewTextBoxColumn.DataPropertyName = "NewBalance";
            this.newBalanceDataGridViewTextBoxColumn.HeaderText = "NewBalance";
            this.newBalanceDataGridViewTextBoxColumn.Name = "newBalanceDataGridViewTextBoxColumn";
            this.newBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDTOBindingSource
            // 
            this.transactionDTOBindingSource.DataSource = typeof(MoneyBank.DTO.TransactionDTO);
            // 
            // cToolstrip1
            // 
            this.cToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cToolstrip1.Location = new System.Drawing.Point(3, 3);
            this.cToolstrip1.Name = "cToolstrip1";
            this.cToolstrip1.Size = new System.Drawing.Size(648, 25);
            this.cToolstrip1.TabIndex = 0;
            this.cToolstrip1.Text = "cToolstrip1";
            // 
            // ucTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucTransactionList";
            this.Size = new System.Drawing.Size(664, 413);
            this.Load += new System.EventHandler(this.ucTransactionList_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTransactions.ResumeLayout(false);
            this.tpTransactions.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tpTransactions;
        private BindingSource transactionDTOBindingSource;
        private FerPROJ.Design.Controls.CDatagridview dgvTransaction;
        private ToolStrip toolStrip1;
        private ToolStripButton rsbRefresh;
        private DataGridViewTextBoxColumn idTrackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn referenceTransNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bankAccountNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deductedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oldBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn newBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private TabPage tabPage1;
        private FerPROJ.Design.Controls.CToolstrip cToolstrip1;
    }
}
