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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            PnlMain = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            thanhtoan = new Button();
            pricelabel = new Label();
            label6 = new Label();
            label5 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            trolai = new Button();
            label1 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PnlMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 101);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 13;
            label4.Text = "tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 101);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 101);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Mã giỏ hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(615, 262);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(918, 306);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 1;
            // 
            // PnlMain
            // 
            PnlMain.BackColor = SystemColors.ButtonHighlight;
            PnlMain.Controls.Add(panel1);
            PnlMain.Controls.Add(label13);
            PnlMain.Controls.Add(label12);
            PnlMain.Controls.Add(label11);
            PnlMain.Controls.Add(label10);
            PnlMain.Controls.Add(label9);
            PnlMain.Controls.Add(textBox5);
            PnlMain.Controls.Add(trolai);
            PnlMain.Controls.Add(label1);
            PnlMain.Controls.Add(label8);
            PnlMain.Controls.Add(label4);
            PnlMain.Controls.Add(label3);
            PnlMain.Controls.Add(label2);
            PnlMain.Controls.Add(dataGridView1);
            PnlMain.Controls.Add(label7);
            PnlMain.Location = new Point(3, 3);
            PnlMain.Margin = new Padding(0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(996, 595);
            PnlMain.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(thanhtoan);
            panel1.Controls.Add(pricelabel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(657, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 595);
            panel1.TabIndex = 31;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(3, 537);
            button2.Name = "button2";
            button2.Size = new Size(330, 55);
            button2.TabIndex = 29;
            button2.Text = "Xóa giỏ hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // thanhtoan
            // 
            thanhtoan.BackColor = Color.Gold;
            thanhtoan.FlatAppearance.BorderColor = Color.Black;
            thanhtoan.FlatStyle = FlatStyle.Popup;
            thanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            thanhtoan.Location = new Point(3, 479);
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Size = new Size(330, 52);
            thanhtoan.TabIndex = 27;
            thanhtoan.Text = "Đặt hàng";
            thanhtoan.UseVisualStyleBackColor = false;
            thanhtoan.Click += thanhtoan_Click;
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pricelabel.ForeColor = Color.White;
            pricelabel.Location = new Point(190, 415);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(0, 21);
            pricelabel.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(18, 408);
            label6.Name = "label6";
            label6.Size = new Size(97, 30);
            label6.TabIndex = 0;
            label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(30, 79);
            label5.Name = "label5";
            label5.Size = new Size(203, 37);
            label5.TabIndex = 28;
            label5.Text = "Order Summary";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(476, 133);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(184, 133);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(102, 133);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 133);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(580, 101);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 22;
            label9.Text = "Số lượng ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(580, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(57, 23);
            textBox5.TabIndex = 20;
            textBox5.TextAlign = HorizontalAlignment.Right;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
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
            label1.Location = new Point(241, 21);
            label1.Name = "label1";
            label1.Size = new Size(140, 40);
            label1.TabIndex = 1;
            label1.Text = "Giỏ hàng ";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 101);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 14;
            label8.Text = "Giá sản phẩm";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label7;
        private Panel PnlMain;
        private Button trolai;
        private Label label1;
        private TextBox textBox5;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label6;
        private Button button2;
        private Label label5;
        private Button thanhtoan;
        private Label pricelabel;
        private Panel panel1;
    }
}