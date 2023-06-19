namespace QLBH_lastproject
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            panel1 = new Panel();
            label1 = new Label();
            trolai = new Button();
            Iphone14panel = new Panel();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            thanhtoan = new Button();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            Iphone14panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trolai);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 100);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 1;
            label1.Text = "Giỏ hàng ";
            // 
            // trolai
            // 
            trolai.BackColor = SystemColors.Control;
            trolai.FlatAppearance.BorderColor = SystemColors.Control;
            trolai.FlatStyle = FlatStyle.Flat;
            trolai.Image = (Image)resources.GetObject("trolai.Image");
            trolai.ImageAlign = ContentAlignment.MiddleLeft;
            trolai.Location = new Point(21, 20);
            trolai.Name = "trolai";
            trolai.Size = new Size(146, 43);
            trolai.TabIndex = 0;
            trolai.Text = "Trở lại trang chủ";
            trolai.TextAlign = ContentAlignment.MiddleRight;
            trolai.UseVisualStyleBackColor = false;
            trolai.Click += trolai_Click;
            // 
            // Iphone14panel
            // 
            Iphone14panel.Controls.Add(numericUpDown1);
            Iphone14panel.Controls.Add(label9);
            Iphone14panel.Controls.Add(label8);
            Iphone14panel.Controls.Add(pictureBox1);
            Iphone14panel.Location = new Point(20, 58);
            Iphone14panel.Name = "Iphone14panel";
            Iphone14panel.Size = new Size(664, 80);
            Iphone14panel.TabIndex = 3;
            Iphone14panel.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(612, 22);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(33, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 30);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 2;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 31);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 1;
            label8.Text = "label8";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 72);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(Iphone14panel);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(4, 116);
            panel4.Name = "panel4";
            panel4.Size = new Size(737, 481);
            panel4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(622, 18);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 18);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 1;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 18);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // thanhtoan
            // 
            thanhtoan.BackColor = Color.Gold;
            thanhtoan.FlatAppearance.BorderColor = Color.Black;
            thanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            thanhtoan.Location = new Point(0, 426);
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Size = new Size(239, 52);
            thanhtoan.TabIndex = 3;
            thanhtoan.Text = "Thanh Toán";
            thanhtoan.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 315);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 4;
            label5.Text = "Order Summary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 386);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 0;
            label6.Text = "Tổng tiền";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(thanhtoan);
            panel5.Location = new Point(763, 116);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 481);
            panel5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 392);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 1;
            label7.Text = "label7";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cart";
            Text = "Cart";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Iphone14panel.ResumeLayout(false);
            Iphone14panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button trolai;
        private Panel Iphone14panel;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button thanhtoan;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Label label7;
    }
}