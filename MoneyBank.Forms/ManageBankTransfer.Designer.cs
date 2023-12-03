namespace MoneyBank.Forms {
    partial class ManageBankTransfer {
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
            System.Windows.Forms.Label bankAccountNoFromLabel;
            System.Windows.Forms.Label bankAccountNoToLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label remainingBalanceLabel;
            System.Windows.Forms.Label label1;
            this.bankTransferDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIDFromCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.userIDToCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.bankAccountNoFromCComboBoxBasic = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.bankAccountNoToCComboBoxBasic = new FerPROJ.Design.Controls.CComboBoxBasic();
            this.remarksCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            this.remainingBalanceCLabelDesc = new FerPROJ.Design.Controls.CLabelDesc();
            this.llUserIDFrom = new System.Windows.Forms.LinkLabel();
            this.llUserIDTo = new System.Windows.Forms.LinkLabel();
            this.amountCTextBoxBasic = new FerPROJ.Design.Controls.CTextBoxBasic();
            bankAccountNoFromLabel = new System.Windows.Forms.Label();
            bankAccountNoToLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            remainingBalanceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankTransferDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(501, 1);
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
            // 
            // PanelMain3
            // 
            this.PanelMain3.Controls.Add(label1);
            this.PanelMain3.Controls.Add(this.amountCTextBoxBasic);
            this.PanelMain3.Controls.Add(this.llUserIDTo);
            this.PanelMain3.Controls.Add(this.llUserIDFrom);
            this.PanelMain3.Controls.Add(remainingBalanceLabel);
            this.PanelMain3.Controls.Add(this.remainingBalanceCLabelDesc);
            this.PanelMain3.Controls.Add(remarksLabel);
            this.PanelMain3.Controls.Add(this.remarksCTextBoxBasic);
            this.PanelMain3.Controls.Add(bankAccountNoToLabel);
            this.PanelMain3.Controls.Add(this.bankAccountNoToCComboBoxBasic);
            this.PanelMain3.Controls.Add(bankAccountNoFromLabel);
            this.PanelMain3.Controls.Add(this.bankAccountNoFromCComboBoxBasic);
            this.PanelMain3.Controls.Add(this.userIDToCTextBoxBasic);
            this.PanelMain3.Controls.Add(this.userIDFromCTextBoxBasic);
            this.PanelMain3.Size = new System.Drawing.Size(736, 230);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // bankAccountNoFromLabel
            // 
            bankAccountNoFromLabel.AutoSize = true;
            bankAccountNoFromLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bankAccountNoFromLabel.Location = new System.Drawing.Point(26, 64);
            bankAccountNoFromLabel.Name = "bankAccountNoFromLabel";
            bankAccountNoFromLabel.Size = new System.Drawing.Size(158, 23);
            bankAccountNoFromLabel.TabIndex = 4;
            bankAccountNoFromLabel.Text = "Bank Account No From:";
            // 
            // bankAccountNoToLabel
            // 
            bankAccountNoToLabel.AutoSize = true;
            bankAccountNoToLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bankAccountNoToLabel.Location = new System.Drawing.Point(370, 63);
            bankAccountNoToLabel.Name = "bankAccountNoToLabel";
            bankAccountNoToLabel.Size = new System.Drawing.Size(140, 23);
            bankAccountNoToLabel.TabIndex = 6;
            bankAccountNoToLabel.Text = "Bank Account No To:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarksLabel.Location = new System.Drawing.Point(26, 156);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(70, 23);
            remarksLabel.TabIndex = 10;
            remarksLabel.Text = "Remarks:";
            // 
            // remainingBalanceLabel
            // 
            remainingBalanceLabel.AutoSize = true;
            remainingBalanceLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remainingBalanceLabel.Location = new System.Drawing.Point(26, 118);
            remainingBalanceLabel.Name = "remainingBalanceLabel";
            remainingBalanceLabel.Size = new System.Drawing.Size(138, 23);
            remainingBalanceLabel.TabIndex = 12;
            remainingBalanceLabel.Text = "Remaining Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(370, 118);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 23);
            label1.TabIndex = 17;
            label1.Text = "Amount:";
            // 
            // bankTransferDTOBindingSource
            // 
            this.bankTransferDTOBindingSource.DataSource = typeof(MoneyBank.DTO.BankTransferDTO);
            // 
            // userIDFromCTextBoxBasic
            // 
            this.userIDFromCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userIDFromCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankTransferDTOBindingSource, "UserIDFrom", true));
            this.userIDFromCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.userIDFromCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.userIDFromCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.userIDFromCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.userIDFromCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.userIDFromCTextBoxBasic.Location = new System.Drawing.Point(187, 22);
            this.userIDFromCTextBoxBasic.Name = "userIDFromCTextBoxBasic";
            this.userIDFromCTextBoxBasic.Size = new System.Drawing.Size(103, 23);
            this.userIDFromCTextBoxBasic.TabIndex = 1;
            // 
            // userIDToCTextBoxBasic
            // 
            this.userIDToCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userIDToCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankTransferDTOBindingSource, "UserIDTo", true));
            this.userIDToCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.userIDToCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.userIDToCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.userIDToCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.userIDToCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.userIDToCTextBoxBasic.Location = new System.Drawing.Point(516, 22);
            this.userIDToCTextBoxBasic.Name = "userIDToCTextBoxBasic";
            this.userIDToCTextBoxBasic.Size = new System.Drawing.Size(106, 23);
            this.userIDToCTextBoxBasic.TabIndex = 3;
            // 
            // bankAccountNoFromCComboBoxBasic
            // 
            this.bankAccountNoFromCComboBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bankTransferDTOBindingSource, "BankAccountNoFrom", true));
            this.bankAccountNoFromCComboBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("PropertyTextValue", this.bankTransferDTOBindingSource, "BankAccountNoFrom", true));
            this.bankAccountNoFromCComboBoxBasic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankAccountNoFromCComboBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.bankAccountNoFromCComboBoxBasic.FormattingEnabled = true;
            this.bankAccountNoFromCComboBoxBasic.Location = new System.Drawing.Point(187, 65);
            this.bankAccountNoFromCComboBoxBasic.Name = "bankAccountNoFromCComboBoxBasic";
            this.bankAccountNoFromCComboBoxBasic.PropertyText = "";
            this.bankAccountNoFromCComboBoxBasic.PropertyTextValue = "";
            this.bankAccountNoFromCComboBoxBasic.Size = new System.Drawing.Size(177, 21);
            this.bankAccountNoFromCComboBoxBasic.TabIndex = 5;
            this.bankAccountNoFromCComboBoxBasic.SelectedIndexChanged += new System.EventHandler(this.bankAccountNoFromCComboBoxBasic_SelectedIndexChanged);
            // 
            // bankAccountNoToCComboBoxBasic
            // 
            this.bankAccountNoToCComboBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bankTransferDTOBindingSource, "BankAccountNoTo", true));
            this.bankAccountNoToCComboBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("PropertyTextValue", this.bankTransferDTOBindingSource, "BankAccountNoTo", true));
            this.bankAccountNoToCComboBoxBasic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankAccountNoToCComboBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.bankAccountNoToCComboBoxBasic.FormattingEnabled = true;
            this.bankAccountNoToCComboBoxBasic.Location = new System.Drawing.Point(516, 63);
            this.bankAccountNoToCComboBoxBasic.Name = "bankAccountNoToCComboBoxBasic";
            this.bankAccountNoToCComboBoxBasic.PropertyText = "";
            this.bankAccountNoToCComboBoxBasic.PropertyTextValue = "";
            this.bankAccountNoToCComboBoxBasic.Size = new System.Drawing.Size(194, 21);
            this.bankAccountNoToCComboBoxBasic.TabIndex = 7;
            // 
            // remarksCTextBoxBasic
            // 
            this.remarksCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankTransferDTOBindingSource, "Remarks", true));
            this.remarksCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.remarksCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.remarksCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.remarksCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.remarksCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxBasic.Location = new System.Drawing.Point(187, 156);
            this.remarksCTextBoxBasic.Multiline = true;
            this.remarksCTextBoxBasic.Name = "remarksCTextBoxBasic";
            this.remarksCTextBoxBasic.Size = new System.Drawing.Size(523, 49);
            this.remarksCTextBoxBasic.TabIndex = 11;
            // 
            // remainingBalanceCLabelDesc
            // 
            this.remainingBalanceCLabelDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankTransferDTOBindingSource, "RemainingBalance", true));
            this.remainingBalanceCLabelDesc.Font = new System.Drawing.Font("Poppins", 10F);
            this.remainingBalanceCLabelDesc.Location = new System.Drawing.Point(182, 118);
            this.remainingBalanceCLabelDesc.Name = "remainingBalanceCLabelDesc";
            this.remainingBalanceCLabelDesc.Size = new System.Drawing.Size(100, 23);
            this.remainingBalanceCLabelDesc.TabIndex = 13;
            this.remainingBalanceCLabelDesc.Text = "cLabelDesc1";
            // 
            // llUserIDFrom
            // 
            this.llUserIDFrom.AutoSize = true;
            this.llUserIDFrom.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUserIDFrom.Location = new System.Drawing.Point(26, 22);
            this.llUserIDFrom.Name = "llUserIDFrom";
            this.llUserIDFrom.Size = new System.Drawing.Size(90, 23);
            this.llUserIDFrom.TabIndex = 14;
            this.llUserIDFrom.TabStop = true;
            this.llUserIDFrom.Text = "UserID From:";
            this.llUserIDFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUserIDFrom_LinkClicked);
            // 
            // llUserIDTo
            // 
            this.llUserIDTo.AutoSize = true;
            this.llUserIDTo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUserIDTo.Location = new System.Drawing.Point(370, 22);
            this.llUserIDTo.Name = "llUserIDTo";
            this.llUserIDTo.Size = new System.Drawing.Size(72, 23);
            this.llUserIDTo.TabIndex = 15;
            this.llUserIDTo.TabStop = true;
            this.llUserIDTo.Text = "UserID To:";
            this.llUserIDTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUserIDTo_LinkClicked);
            // 
            // amountCTextBoxBasic
            // 
            this.amountCTextBoxBasic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.amountCTextBoxBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankTransferDTOBindingSource, "Amount", true));
            this.amountCTextBoxBasic.DefaultForeColor = System.Drawing.Color.Black;
            this.amountCTextBoxBasic.EnterColor = System.Drawing.Color.LightGray;
            this.amountCTextBoxBasic.Font = new System.Drawing.Font("Poppins", 8F);
            this.amountCTextBoxBasic.ForeColor = System.Drawing.Color.Black;
            this.amountCTextBoxBasic.LeaveColor = System.Drawing.Color.WhiteSmoke;
            this.amountCTextBoxBasic.Location = new System.Drawing.Point(516, 118);
            this.amountCTextBoxBasic.Name = "amountCTextBoxBasic";
            this.amountCTextBoxBasic.Size = new System.Drawing.Size(194, 23);
            this.amountCTextBoxBasic.TabIndex = 16;
            // 
            // ManageBankTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 386);
            this.Name = "ManageBankTransfer";
            this.Text = "ManageBankTransfer";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankTransferDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CTextBoxBasic remarksCTextBoxBasic;
        private System.Windows.Forms.BindingSource bankTransferDTOBindingSource;
        private FerPROJ.Design.Controls.CComboBoxBasic bankAccountNoToCComboBoxBasic;
        private FerPROJ.Design.Controls.CComboBoxBasic bankAccountNoFromCComboBoxBasic;
        private FerPROJ.Design.Controls.CTextBoxBasic userIDToCTextBoxBasic;
        private FerPROJ.Design.Controls.CTextBoxBasic userIDFromCTextBoxBasic;
        private FerPROJ.Design.Controls.CLabelDesc remainingBalanceCLabelDesc;
        private System.Windows.Forms.LinkLabel llUserIDTo;
        private System.Windows.Forms.LinkLabel llUserIDFrom;
        private FerPROJ.Design.Controls.CTextBoxBasic amountCTextBoxBasic;
    }
}