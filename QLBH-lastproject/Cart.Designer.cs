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
            panel2 = new Panel();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            thembtn = new Button();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label7 = new Label();
            thanhtoan = new Button();
            PnlMain = new Panel();
            trolai = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(708, 358);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 65);
            panel2.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 21);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 0;
            label6.Text = "Tổng tiền";
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Location = new Point(708, 262);
            button2.Name = "button2";
            button2.Size = new Size(239, 47);
            button2.TabIndex = 18;
            button2.Text = "Xóa giỏ hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Location = new Point(708, 200);
            button1.Name = "button1";
            button1.Size = new Size(239, 47);
            button1.TabIndex = 17;
            button1.Text = "Sửa giỏ hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // thembtn
            // 
            thembtn.BackColor = Color.PeachPuff;
            thembtn.Location = new Point(708, 138);
            thembtn.Name = "thembtn";
            thembtn.Size = new Size(239, 47);
            thembtn.TabIndex = 16;
            thembtn.Text = "Thêm giỏ hàng";
            thembtn.UseVisualStyleBackColor = false;
            thembtn.Click += thembtn_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(460, 415);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 14;
            label8.Text = "Mã thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 415);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Ngày tạo ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 415);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 415);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Mã giỏ hàng";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(460, 447);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 447);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 447);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 447);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 23);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dataGridView1.Size = new Size(564, 262);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(708, 321);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 4;
            label5.Text = "Order Summary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(918, 306);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 1;
            // 
            // thanhtoan
            // 
            thanhtoan.BackColor = Color.Gold;
            thanhtoan.FlatAppearance.BorderColor = Color.Black;
            thanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            thanhtoan.Location = new Point(708, 429);
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Size = new Size(239, 52);
            thanhtoan.TabIndex = 3;
            thanhtoan.Text = "Đặt hàng";
            thanhtoan.UseVisualStyleBackColor = false;
            thanhtoan.Click += thanhtoan_Click_1;
            // 
            // PnlMain
            // 
            PnlMain.BackColor = SystemColors.ButtonHighlight;
            PnlMain.Controls.Add(trolai);
            PnlMain.Controls.Add(label1);
            PnlMain.Controls.Add(panel2);
            PnlMain.Controls.Add(button2);
            PnlMain.Controls.Add(button1);
            PnlMain.Controls.Add(thembtn);
            PnlMain.Controls.Add(label8);
            PnlMain.Controls.Add(label4);
            PnlMain.Controls.Add(label3);
            PnlMain.Controls.Add(label2);
            PnlMain.Controls.Add(textBox4);
            PnlMain.Controls.Add(textBox3);
            PnlMain.Controls.Add(textBox2);
            PnlMain.Controls.Add(textBox1);
            PnlMain.Controls.Add(dataGridView1);
            PnlMain.Controls.Add(label5);
            PnlMain.Controls.Add(label7);
            PnlMain.Controls.Add(thanhtoan);
            PnlMain.Location = new Point(3, 3);
            PnlMain.Margin = new Padding(0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(996, 595);
            PnlMain.TabIndex = 12;
            // 
            // trolai
            // 
            trolai.BackColor = SystemColors.ButtonHighlight;
            trolai.FlatAppearance.BorderColor = SystemColors.Control;
            trolai.FlatStyle = FlatStyle.Flat;
            trolai.Image = (Image)resources.GetObject("trolai.Image");
            trolai.ImageAlign = ContentAlignment.MiddleLeft;
            trolai.Location = new Point(38, 18);
            trolai.Name = "trolai";
            trolai.Size = new Size(146, 43);
            trolai.TabIndex = 0;
            trolai.Text = "Trở lại trang chủ";
            trolai.TextAlign = ContentAlignment.MiddleRight;
            trolai.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 18);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 1;
            label1.Text = "Giỏ hàng ";
            label1.Click += label1_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private Button button2;
        private Button button1;
        private Button thembtn;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label7;
        private Button thanhtoan;
        private Panel PnlMain;
        private Button trolai;
        private Label label1;
    }
}