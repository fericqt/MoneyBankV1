using System.Drawing;
using System.Windows.Forms;

namespace MoneyBank.Forms {
    partial class FrmUsers {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvUsers = new FerPROJ.Design.Controls.CDatagridview();
            dateReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateLastLoginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userLevelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDTOBindingSource = new BindingSource(components);
            panel1 = new Panel();
            PanelMain4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
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
            PanelMain4.Controls.Add(panel1);
            PanelMain4.Size = new Size(1311, 432);
            PanelMain4.Controls.SetChildIndex(panel1, 0);
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToOrderColumns = true;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AlternatingRowColor = Color.LightGray;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { dateReferenceDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, dateLastLoginDataGridViewTextBoxColumn, userLevelDataGridViewTextBoxColumn });
            dgvUsers.CustomHeaderFontStyle = new Font("Poppins", 12F);
            dgvUsers.CustomHeaderForeColor = Color.Black;
            dgvUsers.CustomRowFontStyle = new Font("Poppins", 10F);
            dgvUsers.DataSource = userDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.HeaderColor = Color.WhiteSmoke;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.SelectionColor = Color.FromArgb(128, 128, 255);
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1311, 303);
            dgvUsers.TabIndex = 5;
            // 
            // dateReferenceDataGridViewTextBoxColumn
            // 
            dateReferenceDataGridViewTextBoxColumn.DataPropertyName = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.HeaderText = "DateReference";
            dateReferenceDataGridViewTextBoxColumn.Name = "dateReferenceDataGridViewTextBoxColumn";
            dateReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateLastLoginDataGridViewTextBoxColumn
            // 
            dateLastLoginDataGridViewTextBoxColumn.DataPropertyName = "DateLastLogin";
            dateLastLoginDataGridViewTextBoxColumn.HeaderText = "DateLastLogin";
            dateLastLoginDataGridViewTextBoxColumn.Name = "dateLastLoginDataGridViewTextBoxColumn";
            dateLastLoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLevelDataGridViewTextBoxColumn
            // 
            userLevelDataGridViewTextBoxColumn.DataPropertyName = "UserLevel";
            userLevelDataGridViewTextBoxColumn.HeaderText = "UserLevel";
            userLevelDataGridViewTextBoxColumn.Name = "userLevelDataGridViewTextBoxColumn";
            userLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDTOBindingSource
            // 
            userDTOBindingSource.DataSource = typeof(DTO.UserDTO);
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 303);
            panel1.TabIndex = 6;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonNameAdd = "Add User";
            ButtonNameDelete = "Delete User";
            ButtonNameEdit = "Edit User";
            ClientSize = new Size(1327, 532);
            Name = "FrmUsers";
            Text = "FrmUsers";
            PanelMain4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FerPROJ.Design.Controls.CDatagridview dgvUsers;
        private DataGridViewTextBoxColumn dateReferenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateLastLoginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userLevelDataGridViewTextBoxColumn;
        private BindingSource userDTOBindingSource;
    }
}