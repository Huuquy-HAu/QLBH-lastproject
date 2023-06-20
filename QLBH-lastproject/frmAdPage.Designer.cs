namespace WinFormsApp1
{
    partial class frmAdPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            label1 = new Label();
            btnCLose = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlOrders = new Panel();
            BtnAllOrders = new Button();
            pnlUsers = new Panel();
            BtnAllUsers = new Button();
            pnlProducts = new Panel();
            BtnAllProduct = new Button();
            pnlMain = new Panel();
            pnlTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlUsers.SuspendLayout();
            pnlProducts.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.DimGray;
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(btnCLose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(5, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1190, 50);
            pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 1;
            label1.Text = "Trang quản trị";
            // 
            // btnCLose
            // 
            btnCLose.BackColor = Color.DimGray;
            btnCLose.FlatAppearance.BorderSize = 0;
            btnCLose.FlatStyle = FlatStyle.Flat;
            btnCLose.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCLose.ForeColor = Color.WhiteSmoke;
            btnCLose.Location = new Point(1147, 7);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(40, 40);
            btnCLose.TabIndex = 0;
            btnCLose.Text = "X";
            btnCLose.UseVisualStyleBackColor = false;
            btnCLose.Click += btnCLose_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Silver;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pnlOrders, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlUsers, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlProducts, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 55);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1190, 90);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.Silver;
            pnlOrders.Controls.Add(BtnAllOrders);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(797, 5);
            pnlOrders.Margin = new Padding(5, 5, 5, 0);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Padding = new Padding(0, 0, 0, 5);
            pnlOrders.Size = new Size(388, 85);
            pnlOrders.TabIndex = 5;
            // 
            // BtnAllOrders
            // 
            BtnAllOrders.BackColor = Color.Silver;
            BtnAllOrders.Dock = DockStyle.Fill;
            BtnAllOrders.FlatAppearance.BorderSize = 0;
            BtnAllOrders.FlatStyle = FlatStyle.Flat;
            BtnAllOrders.ForeColor = SystemColors.GrayText;
            BtnAllOrders.Location = new Point(0, 0);
            BtnAllOrders.Name = "BtnAllOrders";
            BtnAllOrders.Size = new Size(388, 80);
            BtnAllOrders.TabIndex = 1;
            BtnAllOrders.Text = "Tất cả đơn hàng";
            BtnAllOrders.UseVisualStyleBackColor = false;
            BtnAllOrders.Click += btn_Click;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.Silver;
            pnlUsers.Controls.Add(BtnAllUsers);
            pnlUsers.Dock = DockStyle.Fill;
            pnlUsers.Location = new Point(401, 5);
            pnlUsers.Margin = new Padding(5, 5, 5, 0);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Padding = new Padding(0, 0, 0, 5);
            pnlUsers.Size = new Size(386, 85);
            pnlUsers.TabIndex = 4;
            // 
            // BtnAllUsers
            // 
            BtnAllUsers.BackColor = Color.Silver;
            BtnAllUsers.Dock = DockStyle.Fill;
            BtnAllUsers.FlatAppearance.BorderSize = 0;
            BtnAllUsers.FlatStyle = FlatStyle.Flat;
            BtnAllUsers.ForeColor = SystemColors.GrayText;
            BtnAllUsers.Location = new Point(0, 0);
            BtnAllUsers.Name = "BtnAllUsers";
            BtnAllUsers.Size = new Size(386, 80);
            BtnAllUsers.TabIndex = 1;
            BtnAllUsers.Text = "Tất cả người dùng";
            BtnAllUsers.UseVisualStyleBackColor = false;
            BtnAllUsers.Click += btn_Click;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.White;
            pnlProducts.Controls.Add(BtnAllProduct);
            pnlProducts.Dock = DockStyle.Fill;
            pnlProducts.Location = new Point(5, 5);
            pnlProducts.Margin = new Padding(5, 5, 5, 0);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Padding = new Padding(0, 0, 0, 5);
            pnlProducts.Size = new Size(386, 85);
            pnlProducts.TabIndex = 3;
            // 
            // BtnAllProduct
            // 
            BtnAllProduct.BackColor = Color.Silver;
            BtnAllProduct.Dock = DockStyle.Fill;
            BtnAllProduct.FlatAppearance.BorderSize = 0;
            BtnAllProduct.FlatStyle = FlatStyle.Flat;
            BtnAllProduct.ForeColor = SystemColors.GrayText;
            BtnAllProduct.Location = new Point(0, 0);
            BtnAllProduct.Name = "BtnAllProduct";
            BtnAllProduct.Size = new Size(386, 80);
            BtnAllProduct.TabIndex = 1;
            BtnAllProduct.Text = "Tất cả sản phẩm";
            BtnAllProduct.UseVisualStyleBackColor = false;
            BtnAllProduct.Click += btn_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.ForeColor = Color.Black;
            pnlMain.Location = new Point(5, 145);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1190, 500);
            pnlMain.TabIndex = 2;
            // 
            // frmAdPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 650);
            Controls.Add(pnlMain);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlTop);
            Font = new Font("Microsoft JhengHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdPage";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnlOrders.ResumeLayout(false);
            pnlUsers.ResumeLayout(false);
            pnlProducts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlProducts;
        private Button BtnAllProduct;
        private Button btnCLose;
        private Panel pnlOrders;
        private Button BtnAllOrders;
        private Panel pnlUsers;
        private Button BtnAllUsers;
        private Label label1;
        private Panel pnlMain;
    }
}