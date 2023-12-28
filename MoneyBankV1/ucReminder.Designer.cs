namespace MoneyBankV1 {
    partial class ucReminder {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.cLabelTitle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 572);
            this.panel1.TabIndex = 0;
            // 
            // cLabelTitle1
            // 
            this.cLabelTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLabelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.cLabelTitle1.ForeColor = System.Drawing.Color.White;
            this.cLabelTitle1.Location = new System.Drawing.Point(0, 0);
            this.cLabelTitle1.Name = "cLabelTitle1";
            this.cLabelTitle1.Size = new System.Drawing.Size(254, 52);
            this.cLabelTitle1.TabIndex = 0;
            this.cLabelTitle1.Text = "Reminder";
            this.cLabelTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucReminder";
            this.Size = new System.Drawing.Size(254, 572);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle1;
    }
}
