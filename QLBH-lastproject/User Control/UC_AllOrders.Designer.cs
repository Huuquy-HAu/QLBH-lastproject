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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnConfirm = new Button();
            panel3 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1095, 302);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(39, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 92);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(508, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 86);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng thái";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(150, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 28);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hủy";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(23, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Duyệt";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(260, 33);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(321, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 34);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(103, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 34);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày tạo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnConfirm);
            panel2.Location = new Point(807, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 92);
            panel2.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(175, 30);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Xóa";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Location = new Point(33, 30);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(123, 40);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(39, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(1095, 61);
            panel3.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(1020, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 39);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
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
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Button btnCancel;
        private Button btnConfirm;
        private Button btnClose;
    }
}
