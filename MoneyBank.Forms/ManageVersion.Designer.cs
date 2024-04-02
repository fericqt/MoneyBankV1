namespace MoneyBank.Forms
{
    partial class ManageVersion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label versionLabel;
            System.Windows.Forms.Label newUpdatesLabel;
            System.Windows.Forms.Label oldUpdatesLabel;
            System.Windows.Forms.Label lastUpdatedOnLabel;
            this.versionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.versionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newUpdatesCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.lastUpdatedOnLabel1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.oldUpdatesLabel2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            versionLabel = new System.Windows.Forms.Label();
            newUpdatesLabel = new System.Windows.Forms.Label();
            oldUpdatesLabel = new System.Windows.Forms.Label();
            lastUpdatedOnLabel = new System.Windows.Forms.Label();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(434, 1);
            this.basePnl2.TabIndex = 1;
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            this.baseButtonCancel.TabIndex = 2;
            // 
            // PanelMain3
            // 
            this.PanelMain3.Controls.Add(this.panel1);
            this.PanelMain3.Controls.Add(lastUpdatedOnLabel);
            this.PanelMain3.Controls.Add(this.lastUpdatedOnLabel1);
            this.PanelMain3.Controls.Add(oldUpdatesLabel);
            this.PanelMain3.Controls.Add(newUpdatesLabel);
            this.PanelMain3.Controls.Add(this.newUpdatesCTextBoxBasic);
            this.PanelMain3.Controls.Add(versionLabel);
            this.PanelMain3.Controls.Add(this.versionMaskedTextBox);
            this.PanelMain3.Size = new System.Drawing.Size(669, 226);
            this.PanelMain3.TabIndex = 0;
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(26, 39);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(45, 13);
            versionLabel.TabIndex = 0;
            versionLabel.Text = "Version:";
            // 
            // newUpdatesLabel
            // 
            newUpdatesLabel.AutoSize = true;
            newUpdatesLabel.Location = new System.Drawing.Point(26, 65);
            newUpdatesLabel.Name = "newUpdatesLabel";
            newUpdatesLabel.Size = new System.Drawing.Size(75, 13);
            newUpdatesLabel.TabIndex = 2;
            newUpdatesLabel.Text = "New Updates:";
            // 
            // oldUpdatesLabel
            // 
            oldUpdatesLabel.AutoSize = true;
            oldUpdatesLabel.Location = new System.Drawing.Point(302, 62);
            oldUpdatesLabel.Name = "oldUpdatesLabel";
            oldUpdatesLabel.Size = new System.Drawing.Size(69, 13);
            oldUpdatesLabel.TabIndex = 6;
            oldUpdatesLabel.Text = "Old Updates:";
            // 
            // lastUpdatedOnLabel
            // 
            lastUpdatedOnLabel.AutoSize = true;
            lastUpdatedOnLabel.Location = new System.Drawing.Point(302, 36);
            lastUpdatedOnLabel.Name = "lastUpdatedOnLabel";
            lastUpdatedOnLabel.Size = new System.Drawing.Size(91, 13);
            lastUpdatedOnLabel.TabIndex = 4;
            lastUpdatedOnLabel.Text = "Last Updated On:";
            // 
            // versionMaskedTextBox
            // 
            this.versionMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.versionDTOBindingSource, "Version", true));
            this.versionMaskedTextBox.Location = new System.Drawing.Point(106, 36);
            this.versionMaskedTextBox.Mask = "0000.0000.0000.0000";
            this.versionMaskedTextBox.Name = "versionMaskedTextBox";
            this.versionMaskedTextBox.Size = new System.Drawing.Size(148, 20);
            this.versionMaskedTextBox.TabIndex = 1;
            // 
            // versionDTOBindingSource
            // 
            this.versionDTOBindingSource.DataSource = typeof(MoneyBank.DTO.VersionDTO);
            // 
            // newUpdatesCTextBoxBasic
            // 
            this.newUpdatesCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newUpdatesCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.versionDTOBindingSource, "NewUpdates", true));
            this.newUpdatesCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.newUpdatesCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.newUpdatesCTextBoxBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.newUpdatesCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.newUpdatesCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.newUpdatesCTextBoxBasic.Location = new System.Drawing.Point(106, 62);
            this.newUpdatesCTextBoxBasic.Multiline = true;
            this.newUpdatesCTextBoxBasic.Name = "newUpdatesCTextBoxBasic";
            this.newUpdatesCTextBoxBasic.Size = new System.Drawing.Size(190, 142);
            this.newUpdatesCTextBoxBasic.TabIndex = 3;
            // 
            // lastUpdatedOnLabel1
            // 
            this.lastUpdatedOnLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.versionDTOBindingSource, "LastUpdatedOn", true));
            this.lastUpdatedOnLabel1.Location = new System.Drawing.Point(399, 36);
            this.lastUpdatedOnLabel1.Name = "lastUpdatedOnLabel1";
            this.lastUpdatedOnLabel1.Size = new System.Drawing.Size(217, 23);
            this.lastUpdatedOnLabel1.TabIndex = 5;
            this.lastUpdatedOnLabel1.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.versionDTOBindingSource;
            // 
            // oldUpdatesLabel2
            // 
            this.oldUpdatesLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.versionDTOBindingSource, "OldUpdates", true));
            this.oldUpdatesLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.oldUpdatesLabel2.Location = new System.Drawing.Point(0, 0);
            this.oldUpdatesLabel2.Name = "oldUpdatesLabel2";
            this.oldUpdatesLabel2.Size = new System.Drawing.Size(227, 1000);
            this.oldUpdatesLabel2.TabIndex = 8;
            this.oldUpdatesLabel2.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.oldUpdatesLabel2);
            this.panel1.Location = new System.Drawing.Point(402, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 139);
            this.panel1.TabIndex = 9;
            // 
            // ManageVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 382);
            this.HideSaveNew = true;
            this.Name = "ManageVersion";
            this.Text = "ManageVersion";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox versionMaskedTextBox;
        private System.Windows.Forms.BindingSource versionDTOBindingSource;
        private FerPROJ.Design.Controls.CTextBoxBasic newUpdatesCTextBoxBasic;
        private System.Windows.Forms.Label lastUpdatedOnLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label oldUpdatesLabel2;
        private System.Windows.Forms.Panel panel1;
    }
}