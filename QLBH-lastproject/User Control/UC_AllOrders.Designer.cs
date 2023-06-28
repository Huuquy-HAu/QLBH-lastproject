namespace WinFormsApp1.UC
{
    partial class UC_AllOrders
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            btnConfirm = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(214, 34);
            label1.TabIndex = 0;
            label1.Text = "Trang đơn hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1095, 302);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(39, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 92);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(496, 30);
            button3.Name = "button3";
            button3.Size = new Size(155, 40);
            button3.TabIndex = 7;
            button3.Text = "Bị hủy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(276, 30);
            button2.Name = "button2";
            button2.Size = new Size(174, 40);
            button2.TabIndex = 6;
            button2.Text = "Đã duyệt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(53, 30);
            button1.Name = "button1";
            button1.Size = new Size(189, 40);
            button1.TabIndex = 5;
            button1.Text = "Chưa duyệt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnConfirm);
            panel2.Location = new Point(973, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 92);
            panel2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(693, 30);
            button4.Name = "button4";
            button4.Size = new Size(200, 40);
            button4.TabIndex = 5;
            button4.Text = "Hoàn thành";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Location = new Point(15, 20);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(123, 64);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "ALL";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(39, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(1095, 61);
            panel3.TabIndex = 4;
            // 
            // UC_AllOrders
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "UC_AllOrders";
            Size = new Size(1180, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnConfirm;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}
