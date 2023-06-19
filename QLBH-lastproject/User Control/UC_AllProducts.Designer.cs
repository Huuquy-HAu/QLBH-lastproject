namespace WinFormsApp1
{
    partial class UC_AllProducts
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
            pnlProductDetail = new Panel();
            txtTotal = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlBtn = new Panel();
            btnDelProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            panel1 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlProductDetail.SuspendLayout();
            pnlBtn.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(220, 34);
            label1.TabIndex = 0;
            label1.Text = "Trang sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(693, 395);
            dataGridView1.TabIndex = 1;
            // 
            // pnlProductDetail
            // 
            pnlProductDetail.BackColor = Color.WhiteSmoke;
            pnlProductDetail.Controls.Add(txtTotal);
            pnlProductDetail.Controls.Add(txtPrice);
            pnlProductDetail.Controls.Add(txtQuantity);
            pnlProductDetail.Controls.Add(txtName);
            pnlProductDetail.Controls.Add(label6);
            pnlProductDetail.Controls.Add(label5);
            pnlProductDetail.Controls.Add(label4);
            pnlProductDetail.Controls.Add(label3);
            pnlProductDetail.Location = new Point(777, 76);
            pnlProductDetail.Name = "pnlProductDetail";
            pnlProductDetail.Size = new Size(361, 316);
            pnlProductDetail.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(192, 261);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(152, 43);
            txtTotal.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(192, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(152, 43);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(192, 121);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(152, 43);
            txtQuantity.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 43);
            txtName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 261);
            label6.Name = "label6";
            label6.Size = new Size(79, 34);
            label6.TabIndex = 4;
            label6.Text = "Tổng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 200);
            label5.Name = "label5";
            label5.Size = new Size(57, 34);
            label5.TabIndex = 3;
            label5.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 124);
            label4.Name = "label4";
            label4.Size = new Size(125, 34);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 35);
            label3.Name = "label3";
            label3.Size = new Size(61, 34);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // pnlBtn
            // 
            pnlBtn.BackColor = Color.LightGray;
            pnlBtn.Controls.Add(btnDelProduct);
            pnlBtn.Controls.Add(btnUpdateProduct);
            pnlBtn.Controls.Add(btnAddProduct);
            pnlBtn.Location = new Point(777, 409);
            pnlBtn.Name = "pnlBtn";
            pnlBtn.Size = new Size(361, 62);
            pnlBtn.TabIndex = 3;
            // 
            // btnDelProduct
            // 
            btnDelProduct.BackColor = Color.Silver;
            btnDelProduct.FlatAppearance.BorderSize = 0;
            btnDelProduct.FlatStyle = FlatStyle.Flat;
            btnDelProduct.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelProduct.Location = new Point(259, 16);
            btnDelProduct.Name = "btnDelProduct";
            btnDelProduct.Size = new Size(95, 33);
            btnDelProduct.TabIndex = 2;
            btnDelProduct.Text = "Xóa";
            btnDelProduct.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.Silver;
            btnUpdateProduct.FlatAppearance.BorderSize = 0;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateProduct.Location = new Point(133, 16);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(95, 33);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Sửa";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Silver;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Microsoft JhengHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(5, 16);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(95, 33);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(61, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 54);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(1002, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 43);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UC_AllProducts
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(pnlBtn);
            Controls.Add(pnlProductDetail);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "UC_AllProducts";
            Size = new Size(1170, 500);
            Load += UC_AllProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlProductDetail.ResumeLayout(false);
            pnlProductDetail.PerformLayout();
            pnlBtn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel pnlProductDetail;
        private Panel pnlBtn;
        private TextBox txtTotal;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private Panel panel1;
        private Button btnClose;
    }
}
