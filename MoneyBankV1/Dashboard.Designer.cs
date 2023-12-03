using System.Drawing;
using System.Windows.Forms;

namespace MoneyBankV2
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            ucReports1 = new ucReports();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ucManagement1 = new ucManagement();
            panel3 = new Panel();
            ucTransactionList1 = new ucTransactionList();
            dbPanel1.SuspendLayout();
            dbPanel8.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dbPanel1
            // 
            dbPanel1.Size = new Size(874, 509);
            // 
            // dbPanel6
            // 
            dbPanel6.Location = new Point(0, 405);
            // 
            // dbPanel3
            // 
            dbPanel3.Size = new Size(233, 307);
            // 
            // dbPanel8
            // 
            dbPanel8.Controls.Add(tableLayoutPanel1);
            dbPanel8.Controls.Add(panel1);
            dbPanel8.Size = new Size(637, 507);
            // 
            // panel1
            // 
            panel1.Controls.Add(ucReports1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(437, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 507);
            panel1.TabIndex = 0;
            // 
            // ucReports1
            // 
            ucReports1.Dock = DockStyle.Fill;
            ucReports1.Location = new Point(0, 0);
            ucReports1.Name = "ucReports1";
            ucReports1.Size = new Size(200, 507);
            ucReports1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(437, 507);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(ucManagement1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 247);
            panel2.TabIndex = 0;
            // 
            // ucManagement1
            // 
            ucManagement1.Dock = DockStyle.Fill;
            ucManagement1.Location = new Point(0, 0);
            ucManagement1.Name = "ucManagement1";
            ucManagement1.Size = new Size(431, 247);
            ucManagement1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(ucTransactionList1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 248);
            panel3.TabIndex = 1;
            // 
            // ucTransactionList1
            // 
            ucTransactionList1.Dock = DockStyle.Fill;
            ucTransactionList1.Location = new Point(0, 0);
            ucTransactionList1.Name = "ucTransactionList1";
            ucTransactionList1.Size = new Size(431, 248);
            ucTransactionList1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 509);
            Location = new Point(0, 0);
            Name = "Dashboard";
            Text = "Dashboard";
            dbPanel1.ResumeLayout(false);
            dbPanel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private ucManagement ucManagement1;
        private ucTransactionList ucTransactionList1;
        private ucReports ucReports1;
    }
}
