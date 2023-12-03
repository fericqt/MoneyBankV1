using System.Drawing;
using System.Windows.Forms;

namespace MoneyBankV2 {
    partial class ucManagement {
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBankAccount = new FerPROJ.Design.Controls.CButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReconcileBank = new FerPROJ.Design.Controls.CButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnManageReceives = new FerPROJ.Design.Controls.CButton();
            this.btnReceiveType = new FerPROJ.Design.Controls.CButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnManageExpenses = new FerPROJ.Design.Controls.CButton();
            this.btnExpenseType = new FerPROJ.Design.Controls.CButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBankTransfer = new FerPROJ.Design.Controls.CButton();
            this.btnBank = new FerPROJ.Design.Controls.CButton();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 738);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnBankAccount);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(19, 562);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(657, 120);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "USER INFORMATION DETAILS";
            // 
            // btnBankAccount
            // 
            this.btnBankAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBankAccount.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnBankAccount.BorderColor = System.Drawing.Color.Green;
            this.btnBankAccount.BorderRadius = 20;
            this.btnBankAccount.BorderSize = 0;
            this.btnBankAccount.FlatAppearance.BorderSize = 0;
            this.btnBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankAccount.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnBankAccount.ForeColor = System.Drawing.Color.Black;
            this.btnBankAccount.Location = new System.Drawing.Point(23, 25);
            this.btnBankAccount.Name = "btnBankAccount";
            this.btnBankAccount.Size = new System.Drawing.Size(160, 35);
            this.btnBankAccount.TabIndex = 0;
            this.btnBankAccount.Text = "Info and Bank Account";
            this.btnBankAccount.TextColor = System.Drawing.Color.Black;
            this.btnBankAccount.UseVisualStyleBackColor = false;
            this.btnBankAccount.Click += new System.EventHandler(this.btnBankAccount_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnReconcileBank);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(19, 428);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(657, 120);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RECONCILE";
            // 
            // btnReconcileBank
            // 
            this.btnReconcileBank.BackColor = System.Drawing.Color.SpringGreen;
            this.btnReconcileBank.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnReconcileBank.BorderColor = System.Drawing.Color.Green;
            this.btnReconcileBank.BorderRadius = 20;
            this.btnReconcileBank.BorderSize = 0;
            this.btnReconcileBank.FlatAppearance.BorderSize = 0;
            this.btnReconcileBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReconcileBank.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnReconcileBank.ForeColor = System.Drawing.Color.Black;
            this.btnReconcileBank.Location = new System.Drawing.Point(23, 25);
            this.btnReconcileBank.Name = "btnReconcileBank";
            this.btnReconcileBank.Size = new System.Drawing.Size(129, 35);
            this.btnReconcileBank.TabIndex = 0;
            this.btnReconcileBank.Text = "Reconcile Bank";
            this.btnReconcileBank.TextColor = System.Drawing.Color.Black;
            this.btnReconcileBank.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnManageReceives);
            this.groupBox3.Controls.Add(this.btnReceiveType);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(19, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RECEIVES";
            // 
            // btnManageReceives
            // 
            this.btnManageReceives.BackColor = System.Drawing.Color.SpringGreen;
            this.btnManageReceives.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnManageReceives.BorderColor = System.Drawing.Color.Green;
            this.btnManageReceives.BorderRadius = 20;
            this.btnManageReceives.BorderSize = 0;
            this.btnManageReceives.FlatAppearance.BorderSize = 0;
            this.btnManageReceives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReceives.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnManageReceives.ForeColor = System.Drawing.Color.Black;
            this.btnManageReceives.Location = new System.Drawing.Point(171, 25);
            this.btnManageReceives.Name = "btnManageReceives";
            this.btnManageReceives.Size = new System.Drawing.Size(129, 35);
            this.btnManageReceives.TabIndex = 2;
            this.btnManageReceives.Text = "Manage Receives";
            this.btnManageReceives.TextColor = System.Drawing.Color.Black;
            this.btnManageReceives.UseVisualStyleBackColor = false;
            this.btnManageReceives.Click += new System.EventHandler(this.btnManageReceives_Click);
            // 
            // btnReceiveType
            // 
            this.btnReceiveType.BackColor = System.Drawing.Color.SpringGreen;
            this.btnReceiveType.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnReceiveType.BorderColor = System.Drawing.Color.Green;
            this.btnReceiveType.BorderRadius = 20;
            this.btnReceiveType.BorderSize = 0;
            this.btnReceiveType.FlatAppearance.BorderSize = 0;
            this.btnReceiveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveType.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnReceiveType.ForeColor = System.Drawing.Color.Black;
            this.btnReceiveType.Location = new System.Drawing.Point(23, 25);
            this.btnReceiveType.Name = "btnReceiveType";
            this.btnReceiveType.Size = new System.Drawing.Size(129, 35);
            this.btnReceiveType.TabIndex = 0;
            this.btnReceiveType.Text = "Receive Type";
            this.btnReceiveType.TextColor = System.Drawing.Color.Black;
            this.btnReceiveType.UseVisualStyleBackColor = false;
            this.btnReceiveType.Click += new System.EventHandler(this.btnReceiveType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnManageExpenses);
            this.groupBox2.Controls.Add(this.btnExpenseType);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(19, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXPENSES";
            // 
            // btnManageExpenses
            // 
            this.btnManageExpenses.BackColor = System.Drawing.Color.SpringGreen;
            this.btnManageExpenses.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnManageExpenses.BorderColor = System.Drawing.Color.Green;
            this.btnManageExpenses.BorderRadius = 20;
            this.btnManageExpenses.BorderSize = 0;
            this.btnManageExpenses.FlatAppearance.BorderSize = 0;
            this.btnManageExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageExpenses.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnManageExpenses.ForeColor = System.Drawing.Color.Black;
            this.btnManageExpenses.Location = new System.Drawing.Point(171, 25);
            this.btnManageExpenses.Name = "btnManageExpenses";
            this.btnManageExpenses.Size = new System.Drawing.Size(129, 35);
            this.btnManageExpenses.TabIndex = 1;
            this.btnManageExpenses.Text = "Manage Expenses";
            this.btnManageExpenses.TextColor = System.Drawing.Color.Black;
            this.btnManageExpenses.UseVisualStyleBackColor = false;
            this.btnManageExpenses.Click += new System.EventHandler(this.btnManageExpenses_Click);
            // 
            // btnExpenseType
            // 
            this.btnExpenseType.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExpenseType.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnExpenseType.BorderColor = System.Drawing.Color.Green;
            this.btnExpenseType.BorderRadius = 20;
            this.btnExpenseType.BorderSize = 0;
            this.btnExpenseType.FlatAppearance.BorderSize = 0;
            this.btnExpenseType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseType.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnExpenseType.ForeColor = System.Drawing.Color.Black;
            this.btnExpenseType.Location = new System.Drawing.Point(23, 25);
            this.btnExpenseType.Name = "btnExpenseType";
            this.btnExpenseType.Size = new System.Drawing.Size(129, 35);
            this.btnExpenseType.TabIndex = 0;
            this.btnExpenseType.Text = "Expense Type";
            this.btnExpenseType.TextColor = System.Drawing.Color.Black;
            this.btnExpenseType.UseVisualStyleBackColor = false;
            this.btnExpenseType.Click += new System.EventHandler(this.btnExpenseType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBankTransfer);
            this.groupBox1.Controls.Add(this.btnBank);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BANK";
            // 
            // btnBankTransfer
            // 
            this.btnBankTransfer.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBankTransfer.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnBankTransfer.BorderColor = System.Drawing.Color.Green;
            this.btnBankTransfer.BorderRadius = 20;
            this.btnBankTransfer.BorderSize = 0;
            this.btnBankTransfer.FlatAppearance.BorderSize = 0;
            this.btnBankTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransfer.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnBankTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnBankTransfer.Location = new System.Drawing.Point(171, 25);
            this.btnBankTransfer.Name = "btnBankTransfer";
            this.btnBankTransfer.Size = new System.Drawing.Size(129, 35);
            this.btnBankTransfer.TabIndex = 1;
            this.btnBankTransfer.Text = "Bank Transfer";
            this.btnBankTransfer.TextColor = System.Drawing.Color.Black;
            this.btnBankTransfer.UseVisualStyleBackColor = false;
            this.btnBankTransfer.Click += new System.EventHandler(this.btnBankTransfer_Click);
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBank.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btnBank.BorderColor = System.Drawing.Color.Green;
            this.btnBank.BorderRadius = 20;
            this.btnBank.BorderSize = 0;
            this.btnBank.FlatAppearance.BorderSize = 0;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBank.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnBank.ForeColor = System.Drawing.Color.Black;
            this.btnBank.Location = new System.Drawing.Point(23, 25);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(129, 35);
            this.btnBank.TabIndex = 0;
            this.btnBank.Text = "Bank";
            this.btnBank.TextColor = System.Drawing.Color.Black;
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // ucManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucManagement";
            this.Size = new System.Drawing.Size(704, 738);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private FerPROJ.Design.Controls.CButton btnBank;
        private GroupBox groupBox3;
        private FerPROJ.Design.Controls.CButton btnReceiveType;
        private GroupBox groupBox2;
        private FerPROJ.Design.Controls.CButton btnExpenseType;
        private GroupBox groupBox4;
        private FerPROJ.Design.Controls.CButton btnReconcileBank;
        private GroupBox groupBox5;
        private FerPROJ.Design.Controls.CButton btnBankAccount;
        private FerPROJ.Design.Controls.CButton btnManageExpenses;
        private FerPROJ.Design.Controls.CButton btnManageReceives;
        private FerPROJ.Design.Controls.CButton btnBankTransfer;
    }
}
