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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dathang));
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            trolai = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(4, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 480);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(18, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(941, 100);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(758, 27);
            button1.Name = "button1";
            button1.Size = new Size(164, 48);
            button1.TabIndex = 2;
            button1.Text = "Hủy đơn hàng";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(444, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 44);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trolai);
            panel1.Location = new Point(7, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 109);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(332, 28);
            label1.Name = "label1";
            label1.Size = new Size(279, 40);
            label1.TabIndex = 2;
            label1.Text = "Hiện trạng đơn hàng";
            // 
            // trolai
            // 
            trolai.BackColor = SystemColors.Control;
            trolai.FlatAppearance.BorderColor = SystemColors.Control;
            trolai.FlatStyle = FlatStyle.Flat;
            trolai.Image = (Image)resources.GetObject("trolai.Image");
            trolai.ImageAlign = ContentAlignment.MiddleLeft;
            trolai.Location = new Point(26, 25);
            trolai.Name = "trolai";
            trolai.Size = new Size(146, 43);
            trolai.TabIndex = 1;
            trolai.Text = "Trở lại trang chủ";
            trolai.TextAlign = ContentAlignment.MiddleRight;
            trolai.UseVisualStyleBackColor = false;
            trolai.Click += trolai_Click;
            // 
            // Dathang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dathang";
            Size = new Size(1000, 600);
            Load += Dathang_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button trolai;
    }
}
