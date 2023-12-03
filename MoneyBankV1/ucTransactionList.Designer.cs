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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTransactionList));
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tpTransactions = new TabPage();
            dgvTransaction = new FerPROJ.Design.Controls.CDatagridview();
            transactionDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            rsbRefresh = new ToolStripButton();
            idTrackDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            referenceTransNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankAccountNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deductedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oldBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            newBalanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 477);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTransactions);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(773, 475);
            tabControl1.TabIndex = 0;
            // 
            // tpTransactions
            // 
            tpTransactions.Controls.Add(dgvTransaction);
            tpTransactions.Controls.Add(toolStrip1);
            tpTransactions.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpTransactions.Location = new Point(4, 24);
            tpTransactions.Name = "tpTransactions";
            tpTransactions.Padding = new Padding(3);
            tpTransactions.Size = new Size(765, 447);
            tpTransactions.TabIndex = 0;
            tpTransactions.Text = "Transaction List";
            tpTransactions.UseVisualStyleBackColor = true;
            // 
            // dgvTransaction
            // 
            dgvTransaction.AllowUserToAddRows = false;
            dgvTransaction.AllowUserToDeleteRows = false;
            dgvTransaction.AllowUserToOrderColumns = true;
            dgvTransaction.AllowUserToResizeRows = false;
            dgvTransaction.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaction.AutoGenerateColumns = false;
            dgvTransaction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransaction.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvTransaction.BorderStyle = BorderStyle.None;
            dgvTransaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.Columns.AddRange(new DataGridViewColumn[] { idTrackDataGridViewTextBoxColumn, dateReferenceDataGridViewTextBoxColumn, transNoDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, referenceTransNoDataGridViewTextBoxColumn, bankAccountNoDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, addedDataGridViewTextBoxColumn, deductedDataGridViewTextBoxColumn, oldBalanceDataGridViewTextBoxColumn, newBalanceDataGridViewTextBoxColumn, remarksDataGridViewTextBoxColumn });
            dgvTransaction.CustomHeaderFontStyle = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvTransaction.CustomHeaderForeColor = Color.Black;
            dgvTransaction.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvTransaction.DataSource = transactionDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransaction.Dock = DockStyle.Fill;
            dgvTransaction.EnableHeadersVisualStyles = false;
            dgvTransaction.HeaderColor = Color.WhiteSmoke;
            dgvTransaction.Location = new Point(3, 28);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.ReadOnly = true;
            dgvTransaction.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTransaction.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaction.Size = new Size(759, 416);
            dgvTransaction.TabIndex = 0;
            // 
            // transactionDTOBindingSource
            // 
            transactionDTOBindingSource.DataSource = typeof(MoneyBank.DTO.TransactionDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { rsbRefresh });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(759, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // rsbRefresh
            // 
            rsbRefresh.Image = (Image)resources.GetObject("rsbRefresh.Image");
            rsbRefresh.ImageTransparentColor = Color.Magenta;
            rsbRefresh.Name = "rsbRefresh";
            rsbRefresh.Size = new Size(93, 22);
            rsbRefresh.Text = "Refresh Data";
            rsbRefresh.Click += rsbRefresh_Click;
            // 
            // idTrackDataGridViewTextBoxColumn
            // 
            idTrackDataGridViewTextBoxColumn.DataPropertyName = "IdTrack";
            idTrackDataGridViewTextBoxColumn.HeaderText = "IdTrack";
            idTrackDataGridViewTextBoxColumn.Name = "idTrackDataGridViewTextBoxColumn";
            idTrackDataGridViewTextBoxColumn.ReadOnly = true;
            idTrackDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transNoDataGridViewTextBoxColumn
            // 
            transNoDataGridViewTextBoxColumn.DataPropertyName = "TransNo";
            transNoDataGridViewTextBoxColumn.HeaderText = "TransNo";
            transNoDataGridViewTextBoxColumn.Name = "transNoDataGridViewTextBoxColumn";
            transNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceTransNoDataGridViewTextBoxColumn
            // 
            referenceTransNoDataGridViewTextBoxColumn.DataPropertyName = "ReferenceTransNo";
            referenceTransNoDataGridViewTextBoxColumn.HeaderText = "ReferenceTransNo";
            referenceTransNoDataGridViewTextBoxColumn.Name = "referenceTransNoDataGridViewTextBoxColumn";
            referenceTransNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankAccountNoDataGridViewTextBoxColumn
            // 
            bankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo";
            bankAccountNoDataGridViewTextBoxColumn.Name = "bankAccountNoDataGridViewTextBoxColumn";
            bankAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedDataGridViewTextBoxColumn
            // 
            addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            addedDataGridViewTextBoxColumn.HeaderText = "Added";
            addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            addedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductedDataGridViewTextBoxColumn
            // 
            deductedDataGridViewTextBoxColumn.DataPropertyName = "Deducted";
            deductedDataGridViewTextBoxColumn.HeaderText = "Deducted";
            deductedDataGridViewTextBoxColumn.Name = "deductedDataGridViewTextBoxColumn";
            deductedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldBalanceDataGridViewTextBoxColumn
            // 
            oldBalanceDataGridViewTextBoxColumn.DataPropertyName = "OldBalance";
            oldBalanceDataGridViewTextBoxColumn.HeaderText = "OldBalance";
            oldBalanceDataGridViewTextBoxColumn.Name = "oldBalanceDataGridViewTextBoxColumn";
            oldBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newBalanceDataGridViewTextBoxColumn
            // 
            newBalanceDataGridViewTextBoxColumn.DataPropertyName = "NewBalance";
            newBalanceDataGridViewTextBoxColumn.HeaderText = "NewBalance";
            newBalanceDataGridViewTextBoxColumn.Name = "newBalanceDataGridViewTextBoxColumn";
            newBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucTransactionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucTransactionList";
            Size = new Size(775, 477);
            Load += ucTransactionList_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tpTransactions.ResumeLayout(false);
            tpTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
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
    }
}
