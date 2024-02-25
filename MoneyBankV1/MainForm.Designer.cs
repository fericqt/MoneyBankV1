﻿namespace MoneyBankV1 {
    partial class MainForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucMainMenu1 = new MoneyBankV1.ucMainMenu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucReports1 = new MoneyBankV2.ucReports();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucTransactionList1 = new MoneyBankV2.ucTransactionList();
            this.dbPanel1.SuspendLayout();
            this.dbPanel3.SuspendLayout();
            this.dbPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbPanel1
            // 
            this.dbPanel1.Size = new System.Drawing.Size(954, 498);
            // 
            // dbPanel6
            // 
            this.dbPanel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.dbPanel6.Location = new System.Drawing.Point(0, 436);
            // 
            // dbPanel3
            // 
            this.dbPanel3.BackColor = System.Drawing.Color.DarkBlue;
            this.dbPanel3.Controls.Add(this.panel1);
            this.dbPanel3.Size = new System.Drawing.Size(200, 436);
            // 
            // dbPanel8
            // 
            this.dbPanel8.Controls.Add(this.panel4);
            this.dbPanel8.Controls.Add(this.panel3);
            this.dbPanel8.Controls.Add(this.panel2);
            this.dbPanel8.Size = new System.Drawing.Size(750, 496);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ucMainMenu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 434);
            this.panel1.TabIndex = 0;
            // 
            // ucMainMenu1
            // 
            this.ucMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMainMenu1.Name = "ucMainMenu1";
            this.ucMainMenu1.Size = new System.Drawing.Size(198, 434);
            this.ucMainMenu1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.cLabelTitle1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 100);
            this.panel2.TabIndex = 0;
            // 
            // cLabelTitle1
            // 
            this.cLabelTitle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLabelTitle1.Font = new System.Drawing.Font("Poppins Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelTitle1.ForeColor = System.Drawing.Color.White;
            this.cLabelTitle1.Location = new System.Drawing.Point(0, 0);
            this.cLabelTitle1.Name = "cLabelTitle1";
            this.cLabelTitle1.Size = new System.Drawing.Size(750, 100);
            this.cLabelTitle1.TabIndex = 0;
            this.cLabelTitle1.Text = "Money Bank Information System";
            this.cLabelTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ucReports1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 396);
            this.panel3.TabIndex = 1;
            // 
            // ucReports1
            // 
            this.ucReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports1.Location = new System.Drawing.Point(0, 0);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(198, 394);
            this.ucReports1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ucTransactionList1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 396);
            this.panel4.TabIndex = 2;
            // 
            // ucTransactionList1
            // 
            this.ucTransactionList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransactionList1.Location = new System.Drawing.Point(0, 0);
            this.ucTransactionList1.Name = "ucTransactionList1";
            this.ucTransactionList1.Size = new System.Drawing.Size(548, 394);
            this.ucTransactionList1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 498);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.dbPanel1.ResumeLayout(false);
            this.dbPanel3.ResumeLayout(false);
            this.dbPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ucMainMenu ucMainMenu1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MoneyBankV2.ucReports ucReports1;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle1;
        private MoneyBankV2.ucTransactionList ucTransactionList1;
    }
}