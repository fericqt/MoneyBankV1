using System.Drawing;
using System.Windows.Forms;

namespace MoneyBankV2 {
    partial class ucReports {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportListBox = new System.Windows.Forms.ListBox();
            this.cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUCReports
            // 
            this.panelUCReports.Size = new System.Drawing.Size(230, 452);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cLabelTitle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 452);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reportListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 410);
            this.panel2.TabIndex = 1;
            // 
            // reportListBox
            // 
            this.reportListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportListBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportListBox.FormattingEnabled = true;
            this.reportListBox.ItemHeight = 23;
            this.reportListBox.Location = new System.Drawing.Point(0, 0);
            this.reportListBox.Name = "reportListBox";
            this.reportListBox.Size = new System.Drawing.Size(226, 408);
            this.reportListBox.TabIndex = 0;
            this.reportListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.reportListBox_MouseDoubleClick);
            // 
            // cLabelTitle1
            // 
            this.cLabelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cLabelTitle1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.cLabelTitle1.Location = new System.Drawing.Point(0, 0);
            this.cLabelTitle1.Name = "cLabelTitle1";
            this.cLabelTitle1.Size = new System.Drawing.Size(228, 40);
            this.cLabelTitle1.TabIndex = 0;
            this.cLabelTitle1.Text = "Reports";
            this.cLabelTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(230, 452);
            this.Controls.SetChildIndex(this.panelUCReports, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle1;
        private ListBox reportListBox;
    }
}
