namespace MoneyBankV1 {
    partial class Main {
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucReports1 = new MoneyBankV2.ucReports();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucReminder1 = new MoneyBankV1.ucReminder();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ucTransactionList1 = new MoneyBankV2.ucTransactionList();
            this.cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            this.pnlMainTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainTop
            // 
            this.pnlMainTop.Controls.Add(this.cLabelTitle1);
            this.pnlMainTop.Size = new System.Drawing.Size(966, 96);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucMainMenu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 404);
            this.panel1.TabIndex = 2;
            // 
            // ucMainMenu1
            // 
            this.ucMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMainMenu1.Name = "ucMainMenu1";
            this.ucMainMenu1.Size = new System.Drawing.Size(230, 402);
            this.ucMainMenu1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(766, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 404);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucReports1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 252);
            this.panel4.TabIndex = 1;
            // 
            // ucReports1
            // 
            this.ucReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports1.Location = new System.Drawing.Point(0, 0);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(198, 252);
            this.ucReports1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucReminder1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 150);
            this.panel3.TabIndex = 0;
            // 
            // ucReminder1
            // 
            this.ucReminder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReminder1.Location = new System.Drawing.Point(0, 0);
            this.ucReminder1.Name = "ucReminder1";
            this.ucReminder1.Size = new System.Drawing.Size(198, 150);
            this.ucReminder1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ucTransactionList1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(232, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 404);
            this.panel5.TabIndex = 4;
            // 
            // ucTransactionList1
            // 
            this.ucTransactionList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransactionList1.Location = new System.Drawing.Point(0, 0);
            this.ucTransactionList1.Name = "ucTransactionList1";
            this.ucTransactionList1.Size = new System.Drawing.Size(532, 402);
            this.ucTransactionList1.TabIndex = 0;
            // 
            // cLabelTitle1
            // 
            this.cLabelTitle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLabelTitle1.Font = new System.Drawing.Font("Poppins Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabelTitle1.ForeColor = System.Drawing.Color.White;
            this.cLabelTitle1.Location = new System.Drawing.Point(0, 0);
            this.cLabelTitle1.Name = "cLabelTitle1";
            this.cLabelTitle1.Size = new System.Drawing.Size(964, 94);
            this.cLabelTitle1.TabIndex = 0;
            this.cLabelTitle1.Text = "Bank Management Information System";
            this.cLabelTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 530);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Main";
            this.Text = "Main";
            this.Controls.SetChildIndex(this.pnlMainTop, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.pnlMainTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ucMainMenu ucMainMenu1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private MoneyBankV2.ucReports ucReports1;
        private System.Windows.Forms.Panel panel3;
        private ucReminder ucReminder1;
        private System.Windows.Forms.Panel panel5;
        private MoneyBankV2.ucTransactionList ucTransactionList1;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle1;
    }
}