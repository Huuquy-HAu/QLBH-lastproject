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
            dataGridView1 = new DataGridView();
            btn_Xoa = new DataGridViewButtonColumn();
            btn_Down = new DataGridViewButtonColumn();
            btn_Up = new DataGridViewButtonColumn();
            check = new DataGridViewCheckBoxColumn();
            label7 = new Label();
            PnlMain = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            thanhtoan = new Button();
            pricelabel = new Label();
            label6 = new Label();
            label5 = new Label();
            trolai = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PnlMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btn_Xoa, btn_Down, btn_Up, check });
            dataGridView1.Location = new Point(22, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(677, 398);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Xoa
            // 
            btn_Xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btn_Xoa.FillWeight = 46.1608353F;
            btn_Xoa.HeaderText = "";
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseColumnTextForButtonValue = true;
            btn_Xoa.Width = 5;
            // 
            // btn_Down
            // 
            btn_Down.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btn_Down.FillWeight = 92.9569855F;
            btn_Down.HeaderText = "";
            btn_Down.Name = "btn_Down";
            btn_Down.Text = "-";
            btn_Down.UseColumnTextForButtonValue = true;
            btn_Down.Width = 5;
            // 
            // btn_Up
            // 
            btn_Up.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btn_Up.FillWeight = 118.750191F;
            btn_Up.HeaderText = "";
            btn_Up.Name = "btn_Up";
            btn_Up.Text = "+";
            btn_Up.UseColumnTextForButtonValue = true;
            btn_Up.Width = 5;
            // 
            // check
            // 
            check.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            check.FillWeight = 142.132F;
            check.HeaderText = "";
            check.Name = "check";
            check.Width = 5;
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
            PnlMain.Controls.Add(trolai);
            PnlMain.Controls.Add(label1);
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
            panel1.Location = new Point(715, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 595);
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
            button2.Size = new Size(272, 55);
            button2.TabIndex = 29;
            button2.Text = "Xóa giỏ hàng";
            button2.UseVisualStyleBackColor = false;
            // 
            // thanhtoan
            // 
            thanhtoan.BackColor = Color.Gold;
            thanhtoan.FlatAppearance.BorderColor = Color.Black;
            thanhtoan.FlatStyle = FlatStyle.Popup;
            thanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            thanhtoan.Location = new Point(3, 479);
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Size = new Size(272, 52);
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
            label6.Location = new Point(0, 408);
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
            trolai.Click += trolai_Click_2;
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
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label7;
        private Panel PnlMain;
        private Button trolai;
        private Label label1;
        private Label label6;
        private Button button2;
        private Label label5;
        private Button thanhtoan;
        private Label pricelabel;
        private Panel panel1;
        private DataGridViewButtonColumn btn_Xoa;
        private DataGridViewButtonColumn btn_Down;
        private DataGridViewButtonColumn btn_Up;
        private DataGridViewCheckBoxColumn check;
    }
}