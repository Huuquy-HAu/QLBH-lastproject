namespace QLBH_lastproject
{
    partial class Mainmenu
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
            panel1 = new Panel();
            button5 = new Button();
            btnAdmin = new Button();
            donhang = new Button();
            giohang = new Button();
            btnUserInfor = new Button();
            panel2 = new Panel();
            huy = new Button();
            timkiem = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(donhang);
            panel1.Controls.Add(giohang);
            panel1.Controls.Add(btnUserInfor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 600);
            panel1.TabIndex = 3;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 377);
            button5.Name = "button5";
            button5.Size = new Size(197, 61);
            button5.TabIndex = 4;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(0, 310);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(197, 61);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += taikhoan_Click;
            // 
            // donhang
            // 
            donhang.FlatStyle = FlatStyle.Popup;
            donhang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            donhang.ForeColor = Color.White;
            donhang.Location = new Point(0, 243);
            donhang.Name = "donhang";
            donhang.Size = new Size(197, 61);
            donhang.TabIndex = 2;
            donhang.Text = "Đơn hàng";
            donhang.UseVisualStyleBackColor = true;
            donhang.Click += donhang_Click;
            // 
            // giohang
            // 
            giohang.FlatStyle = FlatStyle.Popup;
            giohang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            giohang.ForeColor = Color.White;
            giohang.Location = new Point(0, 176);
            giohang.Name = "giohang";
            giohang.Size = new Size(197, 61);
            giohang.TabIndex = 1;
            giohang.Text = "Giỏ hàng";
            giohang.UseVisualStyleBackColor = true;
            giohang.Click += giohang_Click;
            // 
            // btnUserInfor
            // 
            btnUserInfor.FlatStyle = FlatStyle.Popup;
            btnUserInfor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserInfor.ForeColor = Color.White;
            btnUserInfor.Location = new Point(0, 109);
            btnUserInfor.Name = "btnUserInfor";
            btnUserInfor.Size = new Size(197, 61);
            btnUserInfor.TabIndex = 0;
            btnUserInfor.Text = "Thông tin tài khoản";
            btnUserInfor.UseVisualStyleBackColor = true;
            btnUserInfor.Click += trangchu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(huy);
            panel2.Controls.Add(timkiem);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(205, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 76);
            panel2.TabIndex = 4;
            // 
            // huy
            // 
            huy.ForeColor = SystemColors.Highlight;
            huy.Location = new Point(549, 28);
            huy.Name = "huy";
            huy.Size = new Size(86, 31);
            huy.TabIndex = 2;
            huy.Text = "Hủy";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // timkiem
            // 
            timkiem.BackColor = SystemColors.Highlight;
            timkiem.ForeColor = SystemColors.ButtonHighlight;
            timkiem.Location = new Point(447, 26);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(96, 34);
            timkiem.TabIndex = 1;
            timkiem.Text = "Tìm";
            timkiem.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 35);
            textBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(220, 109);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(710, 486);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainmenu";
            Text = "Mainmenu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button5;
        private Button btnAdmin;
        private Button donhang;
        private Button giohang;
        private Button btnUserInfor;
        private Panel panel2;
        private Button huy;
        private Button timkiem;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}