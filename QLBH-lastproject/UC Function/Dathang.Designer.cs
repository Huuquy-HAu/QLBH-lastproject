namespace QLBH_lastproject.UC_Function
{
    partial class Dathang
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
            panel2 = new Panel();
            panel3 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            btn_Table = new DataGridViewButtonColumn();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(4, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 480);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(47, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(821, 61);
            panel3.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(549, 10);
            button7.Name = "button7";
            button7.Size = new Size(115, 41);
            button7.TabIndex = 4;
            button7.Text = "Hoàn thành";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(431, 10);
            button6.Name = "button6";
            button6.Size = new Size(121, 41);
            button6.TabIndex = 3;
            button6.Text = "Bị hủy";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(314, 10);
            button5.Name = "button5";
            button5.Size = new Size(121, 41);
            button5.TabIndex = 2;
            button5.Text = "Đã duyệt";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 10);
            button4.Name = "button4";
            button4.Size = new Size(148, 41);
            button4.TabIndex = 1;
            button4.Text = "Chưa duyệt";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(58, 10);
            button3.Name = "button3";
            button3.Size = new Size(121, 41);
            button3.TabIndex = 0;
            button3.Text = "Tất cả";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { btn_Table });
            dataGridView2.Location = new Point(47, 97);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(821, 295);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.RowPostPaint += dataGridView2_RowPostPaint;
            dataGridView2.RowPrePaint += dataGridView2_RowPrePaint;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // btn_Table
            // 
            btn_Table.HeaderText = "";
            btn_Table.Name = "btn_Table";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(563, 418);
            button2.Name = "button2";
            button2.Size = new Size(186, 42);
            button2.TabIndex = 3;
            button2.Text = "Mua tiếp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(870, 3);
            button1.Name = "button1";
            button1.Size = new Size(54, 48);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(7, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 109);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 30);
            label1.Name = "label1";
            label1.Size = new Size(279, 40);
            label1.TabIndex = 2;
            label1.Text = "Hiện trạng đơn hàng";
            // 
            // Dathang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dathang";
            Size = new Size(934, 600);
            Load += Dathang_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView2;
        private Panel panel3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridViewButtonColumn btn_Table;
        private Button button7;
    }
}
