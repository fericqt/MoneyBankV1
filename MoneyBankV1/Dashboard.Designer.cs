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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucReports1 = new MoneyBankV2.ucReports();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucManagement1 = new MoneyBankV2.ucManagement();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucTransactionList1 = new MoneyBankV2.ucTransactionList();
            this.ucReminder1 = new MoneyBankV1.ucReminder();
            this.dbPanel1.SuspendLayout();
            this.dbPanel3.SuspendLayout();
            this.dbPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbPanel1
            // 
            this.dbPanel1.Size = new System.Drawing.Size(749, 441);
            // 
            // dbPanel6
            // 
            this.dbPanel6.Location = new System.Drawing.Point(0, 350);
            // 
            // dbPanel3
            // 
            this.dbPanel3.Controls.Add(this.ucReminder1);
            this.dbPanel3.Size = new System.Drawing.Size(200, 265);
            // 
            // dbPanel8
            // 
            this.dbPanel8.Controls.Add(this.tableLayoutPanel1);
            this.dbPanel8.Controls.Add(this.panel1);
            this.dbPanel8.Size = new System.Drawing.Size(545, 439);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucReports1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(374, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 439);
            this.panel1.TabIndex = 0;
            // 
            // ucReports1
            // 
            this.ucReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports1.Location = new System.Drawing.Point(0, 0);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(171, 439);
            this.ucReports1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 439);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucManagement1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 213);
            this.panel2.TabIndex = 0;
            // 
            // ucManagement1
            // 
            this.ucManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagement1.Location = new System.Drawing.Point(0, 0);
            this.ucManagement1.Name = "ucManagement1";
            this.ucManagement1.Size = new System.Drawing.Size(368, 213);
            this.ucManagement1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucTransactionList1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 214);
            this.panel3.TabIndex = 1;
            // 
            // ucTransactionList1
            // 
            this.ucTransactionList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransactionList1.Location = new System.Drawing.Point(0, 0);
            this.ucTransactionList1.Name = "ucTransactionList1";
            this.ucTransactionList1.Size = new System.Drawing.Size(368, 214);
            this.ucTransactionList1.TabIndex = 0;
            // 
            // ucReminder1
            // 
            this.ucReminder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReminder1.Location = new System.Drawing.Point(0, 0);
            this.ucReminder1.Name = "ucReminder1";
            this.ucReminder1.Size = new System.Drawing.Size(198, 263);
            this.ucReminder1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 441);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.dbPanel1.ResumeLayout(false);
            this.dbPanel3.ResumeLayout(false);
            this.dbPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private ucManagement ucManagement1;
        private ucTransactionList ucTransactionList1;
        private ucReports ucReports1;
        private MoneyBankV1.ucReminder ucReminder1;
    }
}
