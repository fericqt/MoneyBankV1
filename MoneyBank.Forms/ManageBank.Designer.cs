using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageBank {
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
            components = new System.ComponentModel.Container();
            cTextBoxBasic1 = new FerPROJ.Design.Controls.CTextBoxBasic();
            bankDTOBindingSource = new BindingSource(components);
            cLabelDesc1 = new FerPROJ.Design.Controls.CLabelDesc();
            cLabelDesc2 = new FerPROJ.Design.Controls.CLabelDesc();
            cTextBoxBasic2 = new FerPROJ.Design.Controls.CTextBoxBasic();
            cLabelDesc3 = new FerPROJ.Design.Controls.CLabelDesc();
            cTextBoxBasic3 = new FerPROJ.Design.Controls.CTextBoxBasic();
            cLabelDesc4 = new FerPROJ.Design.Controls.CLabelDesc();
            cTextBoxBasic4 = new FerPROJ.Design.Controls.CTextBoxBasic();
            errorProvider1 = new ErrorProvider(components);
            basePnl2.SuspendLayout();
            PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // basePnl2
            // 
            basePnl2.Location = new Point(240, 1);
            // 
            // baseButtonUpdate
            // 
            baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            baseButtonSave.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            PanelMain3.Controls.Add(cLabelDesc4);
            PanelMain3.Controls.Add(cTextBoxBasic4);
            PanelMain3.Controls.Add(cLabelDesc3);
            PanelMain3.Controls.Add(cTextBoxBasic3);
            PanelMain3.Controls.Add(cLabelDesc2);
            PanelMain3.Controls.Add(cTextBoxBasic2);
            PanelMain3.Controls.Add(cLabelDesc1);
            PanelMain3.Controls.Add(cTextBoxBasic1);
            PanelMain3.Size = new Size(514, 184);
            // 
            // baseButtonAddNew
            // 
            baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // cTextBoxBasic1
            // 
            cTextBoxBasic1.BackColor = Color.WhiteSmoke;
            cTextBoxBasic1.DataBindings.Add(new Binding("Text", bankDTOBindingSource, "BankSwiftcode", true));
            cTextBoxBasic1.DefaultForeColor = Color.Black;
            cTextBoxBasic1.EnterColor = Color.LightGray;
            cTextBoxBasic1.Font = new Font("Poppins", 8F);
            cTextBoxBasic1.ForeColor = Color.Black;
            cTextBoxBasic1.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic1.Location = new Point(180, 19);
            cTextBoxBasic1.Name = "cTextBoxBasic1";
            cTextBoxBasic1.Size = new Size(165, 23);
            cTextBoxBasic1.TabIndex = 0;
            // 
            // bankDTOBindingSource
            // 
            bankDTOBindingSource.DataSource = typeof(DTO.BankDTO);
            // 
            // cLabelDesc1
            // 
            cLabelDesc1.AutoSize = true;
            cLabelDesc1.Font = new Font("Poppins", 10F);
            cLabelDesc1.Location = new Point(24, 17);
            cLabelDesc1.Name = "cLabelDesc1";
            cLabelDesc1.Size = new Size(121, 25);
            cLabelDesc1.TabIndex = 1;
            cLabelDesc1.Text = "Bank Swiftcode:";
            // 
            // cLabelDesc2
            // 
            cLabelDesc2.AutoSize = true;
            cLabelDesc2.Font = new Font("Poppins", 10F);
            cLabelDesc2.Location = new Point(24, 55);
            cLabelDesc2.Name = "cLabelDesc2";
            cLabelDesc2.Size = new Size(91, 25);
            cLabelDesc2.TabIndex = 3;
            cLabelDesc2.Text = "BankName:";
            // 
            // cTextBoxBasic2
            // 
            cTextBoxBasic2.BackColor = Color.WhiteSmoke;
            cTextBoxBasic2.DataBindings.Add(new Binding("Text", bankDTOBindingSource, "BankName", true));
            cTextBoxBasic2.DefaultForeColor = Color.Black;
            cTextBoxBasic2.EnterColor = Color.LightGray;
            cTextBoxBasic2.Font = new Font("Poppins", 8F);
            cTextBoxBasic2.ForeColor = Color.Black;
            cTextBoxBasic2.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic2.Location = new Point(180, 57);
            cTextBoxBasic2.Name = "cTextBoxBasic2";
            cTextBoxBasic2.Size = new Size(305, 23);
            cTextBoxBasic2.TabIndex = 2;
            // 
            // cLabelDesc3
            // 
            cLabelDesc3.AutoSize = true;
            cLabelDesc3.Font = new Font("Poppins", 10F);
            cLabelDesc3.Location = new Point(24, 94);
            cLabelDesc3.Name = "cLabelDesc3";
            cLabelDesc3.Size = new Size(109, 25);
            cLabelDesc3.TabIndex = 5;
            cLabelDesc3.Text = "Bank Provider:";
            // 
            // cTextBoxBasic3
            // 
            cTextBoxBasic3.BackColor = Color.WhiteSmoke;
            cTextBoxBasic3.DataBindings.Add(new Binding("Text", bankDTOBindingSource, "BankProvider", true));
            cTextBoxBasic3.DefaultForeColor = Color.Black;
            cTextBoxBasic3.EnterColor = Color.LightGray;
            cTextBoxBasic3.Font = new Font("Poppins", 8F);
            cTextBoxBasic3.ForeColor = Color.Black;
            cTextBoxBasic3.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic3.Location = new Point(180, 96);
            cTextBoxBasic3.Name = "cTextBoxBasic3";
            cTextBoxBasic3.Size = new Size(305, 23);
            cTextBoxBasic3.TabIndex = 4;
            // 
            // cLabelDesc4
            // 
            cLabelDesc4.AutoSize = true;
            cLabelDesc4.Font = new Font("Poppins", 10F);
            cLabelDesc4.Location = new Point(24, 133);
            cLabelDesc4.Name = "cLabelDesc4";
            cLabelDesc4.Size = new Size(112, 25);
            cLabelDesc4.TabIndex = 7;
            cLabelDesc4.Text = "Bank Location:";
            // 
            // cTextBoxBasic4
            // 
            cTextBoxBasic4.BackColor = Color.WhiteSmoke;
            cTextBoxBasic4.DataBindings.Add(new Binding("Text", bankDTOBindingSource, "BankLocation", true));
            cTextBoxBasic4.DefaultForeColor = Color.Black;
            cTextBoxBasic4.EnterColor = Color.LightGray;
            cTextBoxBasic4.Font = new Font("Poppins", 8F);
            cTextBoxBasic4.ForeColor = Color.Black;
            cTextBoxBasic4.LeaveColor = Color.WhiteSmoke;
            cTextBoxBasic4.Location = new Point(180, 135);
            cTextBoxBasic4.Name = "cTextBoxBasic4";
            cTextBoxBasic4.Size = new Size(305, 23);
            cTextBoxBasic4.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.DataSource = bankDTOBindingSource;
            // 
            // ManageBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 366);
            Name = "ManageBank";
            Text = "ManageBank";
            basePnl2.ResumeLayout(false);
            PanelMain3.ResumeLayout(false);
            PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc4;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic4;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc3;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic3;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc2;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic2;
        private FerPROJ.Design.Controls.CLabelDesc cLabelDesc1;
        private FerPROJ.Design.Controls.CTextBoxBasic cTextBoxBasic1;
        private BindingSource bankDTOBindingSource;
        private ErrorProvider errorProvider1;
    }
}