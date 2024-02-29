using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class ManageLogin {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.usernameCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.passwordCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(383, 1);
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.FlatAppearance.BorderSize = 0;
            this.baseButtonSave.Text = "Login";
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            this.PanelMain3.Controls.Add(this.panel1);
            this.PanelMain3.Location = new System.Drawing.Point(0, 0);
            this.PanelMain3.Size = new System.Drawing.Size(618, 300);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            this.baseButtonAddNew.Text = "Register";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 300);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.passwordCTextBoxBasic);
            this.panel2.Controls.Add(this.usernameCTextBoxBasic);
            this.panel2.Controls.Add(this.pbPassword);
            this.panel2.Controls.Add(this.pbUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 300);
            this.panel2.TabIndex = 0;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPassword.BackgroundImage")));
            this.pbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPassword.Location = new System.Drawing.Point(23, 134);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(25, 25);
            this.pbPassword.TabIndex = 3;
            this.pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUsername.BackgroundImage")));
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUsername.Location = new System.Drawing.Point(23, 103);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(25, 25);
            this.pbUsername.TabIndex = 2;
            this.pbUsername.TabStop = false;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(MoneyBank.DTO.UserDTO);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.userDTOBindingSource;
            // 
            // usernameCTextBoxBasic
            // 
            this.usernameCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Username", true));
            this.usernameCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.usernameCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.usernameCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.usernameCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.usernameCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.usernameCTextBoxBasic.Location = new System.Drawing.Point(53, 102);
            this.usernameCTextBoxBasic.Multiline = true;
            this.usernameCTextBoxBasic.Name = "usernameCTextBoxBasic";
            this.usernameCTextBoxBasic.Size = new System.Drawing.Size(175, 25);
            this.usernameCTextBoxBasic.TabIndex = 4;
            // 
            // passwordCTextBoxBasic
            // 
            this.passwordCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Password", true));
            this.passwordCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.passwordCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.passwordCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.passwordCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.passwordCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.passwordCTextBoxBasic.Location = new System.Drawing.Point(53, 134);
            this.passwordCTextBoxBasic.Multiline = true;
            this.passwordCTextBoxBasic.Name = "passwordCTextBoxBasic";
            this.passwordCTextBoxBasic.Size = new System.Drawing.Size(175, 25);
            this.passwordCTextBoxBasic.TabIndex = 5;
            // 
            // ManageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 381);
            this.HideHeader = true;
            this.Name = "ManageLogin";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ManageLogin";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private BindingSource userDTOBindingSource;
        private ErrorProvider errorProvider1;
        private PictureBox pbUsername;
        private PictureBox pbPassword;
        private FerPROJ.Design.Controls.CTextBoxBasic passwordCTextBoxBasic;
        private FerPROJ.Design.Controls.CTextBoxBasic usernameCTextBoxBasic;
    }
}