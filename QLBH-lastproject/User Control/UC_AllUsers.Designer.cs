﻿namespace WinFormsApp1
{
    partial class UC_AllUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            pnlUserDetail = new Panel();
            cbRoleUser = new ComboBox();
            inpPassword = new TextBox();
            inpUserName = new TextBox();
            inpID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlBtnUser = new Panel();
            btnDelOrder = new Button();
            btnUpdateUser = new Button();
            btnAddUser = new Button();
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlUserDetail.SuspendLayout();
            pnlBtnUser.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(440, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(693, 395);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnlUserDetail
            // 
            pnlUserDetail.BackColor = Color.WhiteSmoke;
            pnlUserDetail.Controls.Add(cbRoleUser);
            pnlUserDetail.Controls.Add(inpPassword);
            pnlUserDetail.Controls.Add(inpUserName);
            pnlUserDetail.Controls.Add(inpID);
            pnlUserDetail.Controls.Add(label6);
            pnlUserDetail.Controls.Add(label5);
            pnlUserDetail.Controls.Add(label4);
            pnlUserDetail.Controls.Add(label3);
            pnlUserDetail.Location = new Point(34, 73);
            pnlUserDetail.Name = "pnlUserDetail";
            pnlUserDetail.Size = new Size(361, 316);
            pnlUserDetail.TabIndex = 2;
            // 
            // cbRoleUser
            // 
            cbRoleUser.FlatStyle = FlatStyle.Flat;
            cbRoleUser.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoleUser.FormattingEnabled = true;
            cbRoleUser.ItemHeight = 31;
            cbRoleUser.Location = new Point(196, 247);
            cbRoleUser.Name = "cbRoleUser";
            cbRoleUser.Size = new Size(149, 39);
            cbRoleUser.TabIndex = 9;
            // 
            // inpPassword
            // 
            inpPassword.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inpPassword.Location = new Point(196, 173);
            inpPassword.Name = "inpPassword";
            inpPassword.Size = new Size(149, 38);
            inpPassword.TabIndex = 8;
            // 
            // inpUserName
            // 
            inpUserName.Enabled = false;
            inpUserName.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            inpUserName.Location = new Point(196, 105);
            inpUserName.Name = "inpUserName";
            inpUserName.Size = new Size(149, 43);
            inpUserName.TabIndex = 7;
            // 
            // inpID
            // 
            inpID.Enabled = false;
            inpID.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inpID.Location = new Point(196, 36);
            inpID.Name = "inpID";
            inpID.Size = new Size(149, 38);
            inpID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 247);
            label6.Name = "label6";
            label6.Size = new Size(118, 35);
            label6.TabIndex = 4;
            label6.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 173);
            label5.Name = "label5";
            label5.Size = new Size(147, 35);
            label5.TabIndex = 3;
            label5.Text = "Mật khẩu ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 105);
            label4.Name = "label4";
            label4.Size = new Size(160, 29);
            label4.TabIndex = 2;
            label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 36);
            label3.Name = "label3";
            label3.Size = new Size(86, 29);
            label3.TabIndex = 1;
            label3.Text = "UserID";
            // 
            // pnlBtnUser
            // 
            pnlBtnUser.BackColor = Color.LightGray;
            pnlBtnUser.Controls.Add(btnDelOrder);
            pnlBtnUser.Controls.Add(btnUpdateUser);
            pnlBtnUser.Controls.Add(btnAddUser);
            pnlBtnUser.Location = new Point(34, 403);
            pnlBtnUser.Name = "pnlBtnUser";
            pnlBtnUser.Size = new Size(361, 62);
            pnlBtnUser.TabIndex = 3;
            // 
            // btnDelOrder
            // 
            btnDelOrder.FlatStyle = FlatStyle.Flat;
            btnDelOrder.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelOrder.Location = new Point(248, 16);
            btnDelOrder.Name = "btnDelOrder";
            btnDelOrder.Size = new Size(97, 32);
            btnDelOrder.TabIndex = 2;
            btnDelOrder.Text = "Xóa";
            btnDelOrder.UseVisualStyleBackColor = true;
            btnDelOrder.Click += btnDelOrder_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateUser.Location = new Point(125, 16);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(95, 32);
            btnUpdateUser.TabIndex = 1;
            btnUpdateUser.Text = "Sửa";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUser.Location = new Point(15, 16);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(85, 32);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Thêm";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 64);
            panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(1021, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 46);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(311, 43);
            label1.TabIndex = 5;
            label1.Text = "Trang người dùng";
            // 
            // UC_AllUsers
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Controls.Add(pnlBtnUser);
            Controls.Add(pnlUserDetail);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_AllUsers";
            Size = new Size(1170, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlUserDetail.ResumeLayout(false);
            pnlUserDetail.PerformLayout();
            pnlBtnUser.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel pnlUserDetail;
        private Panel pnlBtnUser;
        private ComboBox cbRoleUser;
        private TextBox inpPassword;
        private TextBox inpUserName;
        private TextBox inpID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelOrder;
        private Button btnUpdateUser;
        private Button btnAddUser;
        private Panel panel1;
        private Label label1;
        private Button btnClose;
    }
}
