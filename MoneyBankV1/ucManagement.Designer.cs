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
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            btnBankAccount = new FerPROJ.Design.Controls.CButton();
            groupBox4 = new GroupBox();
            btnReconcileBank = new FerPROJ.Design.Controls.CButton();
            groupBox3 = new GroupBox();
            btnManageReceives = new FerPROJ.Design.Controls.CButton();
            btnReceiveType = new FerPROJ.Design.Controls.CButton();
            groupBox2 = new GroupBox();
            btnManageExpenses = new FerPROJ.Design.Controls.CButton();
            btnExpenseType = new FerPROJ.Design.Controls.CButton();
            groupBox1 = new GroupBox();
            btnBank = new FerPROJ.Design.Controls.CButton();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.MediumPurple;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 851);
            panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(btnBankAccount);
            groupBox5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(22, 649);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(766, 139);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "USER INFORMATION DETAILS";
            // 
            // btnBankAccount
            // 
            btnBankAccount.BackColor = Color.SpringGreen;
            btnBankAccount.BackgroundColor = Color.SpringGreen;
            btnBankAccount.BorderColor = Color.Green;
            btnBankAccount.BorderRadius = 20;
            btnBankAccount.BorderSize = 0;
            btnBankAccount.FlatAppearance.BorderSize = 0;
            btnBankAccount.FlatStyle = FlatStyle.Flat;
            btnBankAccount.Font = new Font("Poppins", 9F);
            btnBankAccount.ForeColor = Color.Black;
            btnBankAccount.Location = new Point(27, 29);
            btnBankAccount.Name = "btnBankAccount";
            btnBankAccount.Size = new Size(187, 40);
            btnBankAccount.TabIndex = 0;
            btnBankAccount.Text = "Info and Bank Account";
            btnBankAccount.TextColor = Color.Black;
            btnBankAccount.UseVisualStyleBackColor = false;
            btnBankAccount.Click += btnBankAccount_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(btnReconcileBank);
            groupBox4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(22, 494);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(766, 139);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "RECONCILE";
            // 
            // btnReconcileBank
            // 
            btnReconcileBank.BackColor = Color.SpringGreen;
            btnReconcileBank.BackgroundColor = Color.SpringGreen;
            btnReconcileBank.BorderColor = Color.Green;
            btnReconcileBank.BorderRadius = 20;
            btnReconcileBank.BorderSize = 0;
            btnReconcileBank.FlatAppearance.BorderSize = 0;
            btnReconcileBank.FlatStyle = FlatStyle.Flat;
            btnReconcileBank.Font = new Font("Poppins", 9F);
            btnReconcileBank.ForeColor = Color.Black;
            btnReconcileBank.Location = new Point(27, 29);
            btnReconcileBank.Name = "btnReconcileBank";
            btnReconcileBank.Size = new Size(150, 40);
            btnReconcileBank.TabIndex = 0;
            btnReconcileBank.Text = "Reconcile Bank";
            btnReconcileBank.TextColor = Color.Black;
            btnReconcileBank.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnManageReceives);
            groupBox3.Controls.Add(btnReceiveType);
            groupBox3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(22, 339);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(766, 139);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "RECEIVES";
            // 
            // btnManageReceives
            // 
            btnManageReceives.BackColor = Color.SpringGreen;
            btnManageReceives.BackgroundColor = Color.SpringGreen;
            btnManageReceives.BorderColor = Color.Green;
            btnManageReceives.BorderRadius = 20;
            btnManageReceives.BorderSize = 0;
            btnManageReceives.FlatAppearance.BorderSize = 0;
            btnManageReceives.FlatStyle = FlatStyle.Flat;
            btnManageReceives.Font = new Font("Poppins", 9F);
            btnManageReceives.ForeColor = Color.Black;
            btnManageReceives.Location = new Point(200, 29);
            btnManageReceives.Name = "btnManageReceives";
            btnManageReceives.Size = new Size(150, 40);
            btnManageReceives.TabIndex = 2;
            btnManageReceives.Text = "Manage Receives";
            btnManageReceives.TextColor = Color.Black;
            btnManageReceives.UseVisualStyleBackColor = false;
            btnManageReceives.Click += btnManageReceives_Click;
            // 
            // btnReceiveType
            // 
            btnReceiveType.BackColor = Color.SpringGreen;
            btnReceiveType.BackgroundColor = Color.SpringGreen;
            btnReceiveType.BorderColor = Color.Green;
            btnReceiveType.BorderRadius = 20;
            btnReceiveType.BorderSize = 0;
            btnReceiveType.FlatAppearance.BorderSize = 0;
            btnReceiveType.FlatStyle = FlatStyle.Flat;
            btnReceiveType.Font = new Font("Poppins", 9F);
            btnReceiveType.ForeColor = Color.Black;
            btnReceiveType.Location = new Point(27, 29);
            btnReceiveType.Name = "btnReceiveType";
            btnReceiveType.Size = new Size(150, 40);
            btnReceiveType.TabIndex = 0;
            btnReceiveType.Text = "Receive Type";
            btnReceiveType.TextColor = Color.Black;
            btnReceiveType.UseVisualStyleBackColor = false;
            btnReceiveType.Click += btnReceiveType_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnManageExpenses);
            groupBox2.Controls.Add(btnExpenseType);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(22, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 139);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "EXPENSES";
            // 
            // btnManageExpenses
            // 
            btnManageExpenses.BackColor = Color.SpringGreen;
            btnManageExpenses.BackgroundColor = Color.SpringGreen;
            btnManageExpenses.BorderColor = Color.Green;
            btnManageExpenses.BorderRadius = 20;
            btnManageExpenses.BorderSize = 0;
            btnManageExpenses.FlatAppearance.BorderSize = 0;
            btnManageExpenses.FlatStyle = FlatStyle.Flat;
            btnManageExpenses.Font = new Font("Poppins", 9F);
            btnManageExpenses.ForeColor = Color.Black;
            btnManageExpenses.Location = new Point(200, 29);
            btnManageExpenses.Name = "btnManageExpenses";
            btnManageExpenses.Size = new Size(150, 40);
            btnManageExpenses.TabIndex = 1;
            btnManageExpenses.Text = "Manage Expenses";
            btnManageExpenses.TextColor = Color.Black;
            btnManageExpenses.UseVisualStyleBackColor = false;
            btnManageExpenses.Click += btnManageExpenses_Click;
            // 
            // btnExpenseType
            // 
            btnExpenseType.BackColor = Color.SpringGreen;
            btnExpenseType.BackgroundColor = Color.SpringGreen;
            btnExpenseType.BorderColor = Color.Green;
            btnExpenseType.BorderRadius = 20;
            btnExpenseType.BorderSize = 0;
            btnExpenseType.FlatAppearance.BorderSize = 0;
            btnExpenseType.FlatStyle = FlatStyle.Flat;
            btnExpenseType.Font = new Font("Poppins", 9F);
            btnExpenseType.ForeColor = Color.Black;
            btnExpenseType.Location = new Point(27, 29);
            btnExpenseType.Name = "btnExpenseType";
            btnExpenseType.Size = new Size(150, 40);
            btnExpenseType.TabIndex = 0;
            btnExpenseType.Text = "Expense Type";
            btnExpenseType.TextColor = Color.Black;
            btnExpenseType.UseVisualStyleBackColor = false;
            btnExpenseType.Click += btnExpenseType_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnBank);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(22, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BANK";
            // 
            // btnBank
            // 
            btnBank.BackColor = Color.SpringGreen;
            btnBank.BackgroundColor = Color.SpringGreen;
            btnBank.BorderColor = Color.Green;
            btnBank.BorderRadius = 20;
            btnBank.BorderSize = 0;
            btnBank.FlatAppearance.BorderSize = 0;
            btnBank.FlatStyle = FlatStyle.Flat;
            btnBank.Font = new Font("Poppins", 9F);
            btnBank.ForeColor = Color.Black;
            btnBank.Location = new Point(27, 29);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(150, 40);
            btnBank.TabIndex = 0;
            btnBank.Text = "Bank";
            btnBank.TextColor = Color.Black;
            btnBank.UseVisualStyleBackColor = false;
            btnBank.Click += btnBank_Click;
            // 
            // ucManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucManagement";
            Size = new Size(821, 851);
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
