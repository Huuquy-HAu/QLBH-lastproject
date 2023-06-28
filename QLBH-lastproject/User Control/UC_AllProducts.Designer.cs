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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            clProductId = new DataGridViewTextBoxColumn();
            clProductName = new DataGridViewTextBoxColumn();
            clDescription = new DataGridViewTextBoxColumn();
            clPrice = new DataGridViewTextBoxColumn();
            pnlProductDetail = new Panel();
            label4 = new Label();
            txtProID = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            pnlBtn = new Panel();
            btnDelProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            panel1 = new Panel();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlProductDetail.SuspendLayout();
            pnlBtn.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(285, 43);
            label1.TabIndex = 0;
            label1.Text = "Trang sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clProductId, clProductName, clDescription, clPrice });
            dataGridView1.Location = new Point(61, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(767, 395);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clProductId
            // 
            clProductId.DataPropertyName = "productID";
            clProductId.HeaderText = "Mã sản phẩm";
            clProductId.MinimumWidth = 6;
            clProductId.Name = "clProductId";
            clProductId.ReadOnly = true;
            clProductId.Resizable = DataGridViewTriState.False;
            clProductId.Width = 125;
            // 
            // clProductName
            // 
            clProductName.DataPropertyName = "productName";
            clProductName.HeaderText = "Tên sản phẩm";
            clProductName.MinimumWidth = 6;
            clProductName.Name = "clProductName";
            clProductName.ReadOnly = true;
            clProductName.Width = 160;
            // 
            // clDescription
            // 
            clDescription.DataPropertyName = "description";
            clDescription.HeaderText = "Mô tả";
            clDescription.MinimumWidth = 6;
            clDescription.Name = "clDescription";
            clDescription.ReadOnly = true;
            clDescription.Width = 200;
            // 
            // clPrice
            // 
            clPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clPrice.DataPropertyName = "price";
            clPrice.HeaderText = "Giá";
            clPrice.MinimumWidth = 6;
            clPrice.Name = "clPrice";
            clPrice.ReadOnly = true;
            // 
            // pnlProductDetail
            // 
            pnlProductDetail.BackColor = Color.WhiteSmoke;
            pnlProductDetail.Controls.Add(label4);
            pnlProductDetail.Controls.Add(txtProID);
            pnlProductDetail.Controls.Add(label2);
            pnlProductDetail.Controls.Add(txtDescription);
            pnlProductDetail.Controls.Add(txtPrice);
            pnlProductDetail.Controls.Add(txtName);
            pnlProductDetail.Controls.Add(label6);
            pnlProductDetail.Controls.Add(label5);
            pnlProductDetail.Controls.Add(label3);
            pnlProductDetail.Location = new Point(834, 76);
            pnlProductDetail.Name = "pnlProductDetail";
            pnlProductDetail.Size = new Size(304, 316);
            pnlProductDetail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(260, 172);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 12;
            label4.Text = "$";
            // 
            // txtProID
            // 
            txtProID.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProID.Location = new Point(120, 52);
            txtProID.Name = "txtProID";
            txtProID.ReadOnly = true;
            txtProID.Size = new Size(134, 34);
            txtProID.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 10;
            label2.Text = "Mã SP";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(120, 233);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(134, 34);
            txtDescription.TabIndex = 9;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(120, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(134, 34);
            txtPrice.TabIndex = 8;
            txtPrice.Validating += txtPrice_Validating;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(120, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(134, 34);
            txtName.TabIndex = 6;
            txtName.Validating += txtName_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 236);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 4;
            label6.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 172);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 3;
            label5.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 109);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // pnlBtn
            // 
            pnlBtn.BackColor = Color.LightGray;
            pnlBtn.Controls.Add(btnDelProduct);
            pnlBtn.Controls.Add(btnUpdateProduct);
            pnlBtn.Controls.Add(btnAddProduct);
            pnlBtn.Location = new Point(834, 409);
            pnlBtn.Name = "pnlBtn";
            pnlBtn.Size = new Size(304, 62);
            pnlBtn.TabIndex = 3;
            // 
            // btnDelProduct
            // 
            btnDelProduct.BackColor = Color.Silver;
            btnDelProduct.FlatAppearance.BorderSize = 0;
            btnDelProduct.FlatStyle = FlatStyle.Flat;
            btnDelProduct.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelProduct.Location = new Point(205, 16);
            btnDelProduct.Name = "btnDelProduct";
            btnDelProduct.Size = new Size(95, 33);
            btnDelProduct.TabIndex = 2;
            btnDelProduct.Text = "Xóa";
            btnDelProduct.UseVisualStyleBackColor = false;
            btnDelProduct.Click += btnDelProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.Silver;
            btnUpdateProduct.FlatAppearance.BorderSize = 0;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateProduct.Location = new Point(104, 16);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(95, 33);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Sửa";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Silver;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(3, 16);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(95, 33);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel pnlProductDetail;
        private Panel pnlBtn;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button btnDelProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private Panel panel1;
        private Button btnClose;
        private TextBox txtProID;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Label label4;
        private DataGridViewTextBoxColumn clProductId;
        private DataGridViewTextBoxColumn clProductName;
        private DataGridViewTextBoxColumn clDescription;
        private DataGridViewTextBoxColumn clPrice;
    }
}
