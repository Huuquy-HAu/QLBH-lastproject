namespace QLBH_lastproject.UC_Function
{
    partial class CartItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            Iphone14panel = new Panel();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            Iphone14panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Iphone14panel
            // 
            Iphone14panel.Controls.Add(numericUpDown1);
            Iphone14panel.Controls.Add(label9);
            Iphone14panel.Controls.Add(label8);
            Iphone14panel.Controls.Add(pictureBox1);
            Iphone14panel.Location = new Point(3, 0);
            Iphone14panel.Name = "Iphone14panel";
            Iphone14panel.Size = new Size(664, 80);
            Iphone14panel.TabIndex = 4;
            Iphone14panel.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(607, 28);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(38, 23);
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
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Iphone14panel);
            Name = "CartItem";
            Size = new Size(664, 80);
            Iphone14panel.ResumeLayout(false);
            Iphone14panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Iphone14panel;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
    }
}
