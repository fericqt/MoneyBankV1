using System.Drawing;

namespace MoneyBank.Base.Forms {
    partial class MyFormListWithSearchBase {
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
            PanelMain4.Size = new Size(798, 350);
            // 
            // MyFormListWithSearchBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(814, 450);
            Name = "MyFormListWithSearchBase";
            Text = "MyFormListWithSearchBase";
            ResumeLayout(false);
        }

        #endregion
    }
}