namespace SemPrace
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            btnClearCat = new Label();
            panel1 = new Panel();
            label5 = new Label();
            productListDGV = new DataGridView();
            prod_id = new DataGridViewTextBoxColumn();
            prod_name = new DataGridViewTextBoxColumn();
            prod_cat = new DataGridViewTextBoxColumn();
            prod_qty = new DataGridViewTextBoxColumn();
            prod_price = new DataGridViewTextBoxColumn();
            prod_desc = new DataGridViewTextBoxColumn();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnInsertProduct = new Button();
            productNameTB = new TextBox();
            productIdTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            productPriceTB = new TextBox();
            productQtyTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            productDescTB = new TextBox();
            label6 = new Label();
            btnClearProducts = new Label();
            productCatCB = new ComboBox();
            label8 = new Label();
            searchCB = new ComboBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)productListDGV).BeginInit();
            SuspendLayout();
            // 
            // btnClearCat
            // 
            btnClearCat.AutoSize = true;
            btnClearCat.BackColor = Color.Transparent;
            btnClearCat.ForeColor = Color.Red;
            btnClearCat.Location = new Point(175, 228);
            btnClearCat.Name = "btnClearCat";
            btnClearCat.Size = new Size(34, 15);
            btnClearCat.TabIndex = 37;
            btnClearCat.Text = "Clear";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(20, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 128);
            panel1.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(579, 9);
            label5.Name = "label5";
            label5.Size = new Size(131, 30);
            label5.TabIndex = 35;
            label5.Text = "Product List";
            // 
            // productListDGV
            // 
            productListDGV.BackgroundColor = Color.White;
            productListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productListDGV.Columns.AddRange(new DataGridViewColumn[] { prod_id, prod_name, prod_cat, prod_qty, prod_price, prod_desc });
            productListDGV.Location = new Point(357, 100);
            productListDGV.Name = "productListDGV";
            productListDGV.RowTemplate.Height = 25;
            productListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productListDGV.Size = new Size(564, 381);
            productListDGV.TabIndex = 34;
            productListDGV.MouseDoubleClick += productListDGV_MouseDoubleClick;
            // 
            // prod_id
            // 
            prod_id.HeaderText = "Id";
            prod_id.Name = "prod_id";
            prod_id.Width = 30;
            // 
            // prod_name
            // 
            prod_name.HeaderText = "Name";
            prod_name.Name = "prod_name";
            // 
            // prod_cat
            // 
            prod_cat.HeaderText = "Category";
            prod_cat.Name = "prod_cat";
            // 
            // prod_qty
            // 
            prod_qty.HeaderText = "Quantity";
            prod_qty.Name = "prod_qty";
            prod_qty.Width = 60;
            // 
            // prod_price
            // 
            prod_price.HeaderText = "Price";
            prod_price.Name = "prod_price";
            // 
            // prod_desc
            // 
            prod_desc.HeaderText = "Description";
            prod_desc.Name = "prod_desc";
            prod_desc.Width = 130;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.ForeColor = Color.Red;
            btnDeleteProduct.Location = new Point(175, 443);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(144, 38);
            btnDeleteProduct.TabIndex = 33;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.ForeColor = Color.Green;
            btnUpdateProduct.Location = new Point(175, 398);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(144, 39);
            btnUpdateProduct.TabIndex = 32;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnInsertProduct
            // 
            btnInsertProduct.ForeColor = Color.Navy;
            btnInsertProduct.Location = new Point(175, 353);
            btnInsertProduct.Name = "btnInsertProduct";
            btnInsertProduct.Size = new Size(144, 39);
            btnInsertProduct.TabIndex = 31;
            btnInsertProduct.Text = "Insert";
            btnInsertProduct.UseVisualStyleBackColor = true;
            btnInsertProduct.Click += btnInsertProduct_Click;
            // 
            // productNameTB
            // 
            productNameTB.Location = new Point(175, 129);
            productNameTB.Name = "productNameTB";
            productNameTB.Size = new Size(144, 23);
            productNameTB.TabIndex = 30;
            // 
            // productIdTB
            // 
            productIdTB.Location = new Point(175, 100);
            productIdTB.Name = "productIdTB";
            productIdTB.Size = new Size(144, 23);
            productIdTB.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 28;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(85, 102);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 27;
            label1.Text = "Product Id:";
            // 
            // productPriceTB
            // 
            productPriceTB.Location = new Point(175, 220);
            productPriceTB.Name = "productPriceTB";
            productPriceTB.Size = new Size(144, 23);
            productPriceTB.TabIndex = 41;
            // 
            // productQtyTB
            // 
            productQtyTB.Location = new Point(175, 187);
            productQtyTB.Name = "productQtyTB";
            productQtyTB.Size = new Size(144, 23);
            productQtyTB.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 222);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 39;
            label3.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(73, 187);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 38;
            label4.Text = "Product Qty:";
            // 
            // productDescTB
            // 
            productDescTB.Location = new Point(175, 249);
            productDescTB.Name = "productDescTB";
            productDescTB.Size = new Size(144, 23);
            productDescTB.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(77, 251);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 43;
            label6.Text = "Description:";
            // 
            // btnClearProducts
            // 
            btnClearProducts.AutoSize = true;
            btnClearProducts.BackColor = Color.Transparent;
            btnClearProducts.ForeColor = Color.Red;
            btnClearProducts.Location = new Point(175, 288);
            btnClearProducts.Name = "btnClearProducts";
            btnClearProducts.Size = new Size(34, 15);
            btnClearProducts.TabIndex = 42;
            btnClearProducts.Text = "Clear";
            btnClearProducts.Click += btnClearProducts_Click;
            // 
            // productCatCB
            // 
            productCatCB.FormattingEnabled = true;
            productCatCB.Location = new Point(175, 158);
            productCatCB.Name = "productCatCB";
            productCatCB.Size = new Size(144, 23);
            productCatCB.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(35, 160);
            label8.Name = "label8";
            label8.Size = new Size(134, 21);
            label8.TabIndex = 46;
            label8.Text = "Product Category:";
            // 
            // searchCB
            // 
            searchCB.FormattingEnabled = true;
            searchCB.Location = new Point(526, 70);
            searchCB.Name = "searchCB";
            searchCB.Size = new Size(117, 23);
            searchCB.TabIndex = 47;
            // 
            // btnSearch
            // 
            btnSearch.ForeColor = Color.Navy;
            btnSearch.Location = new Point(649, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(61, 24);
            btnSearch.TabIndex = 48;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.ForeColor = Color.Navy;
            btnRefresh.Location = new Point(716, 70);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(61, 24);
            btnRefresh.TabIndex = 49;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 523);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(searchCB);
            Controls.Add(label8);
            Controls.Add(productCatCB);
            Controls.Add(productDescTB);
            Controls.Add(label6);
            Controls.Add(btnClearProducts);
            Controls.Add(productPriceTB);
            Controls.Add(productQtyTB);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnClearCat);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(productListDGV);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnInsertProduct);
            Controls.Add(productNameTB);
            Controls.Add(productIdTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageProducts";
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)productListDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnClearCat;
        private Panel panel1;
        private Label label5;
        private DataGridView productListDGV;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnInsertProduct;
        private TextBox productNameTB;
        private TextBox productIdTB;
        private Label label2;
        private Label label1;
        private TextBox productPriceTB;
        private TextBox productQtyTB;
        private Label label3;
        private Label label4;
        private TextBox productDescTB;
        private Label label6;
        private Label btnClearProducts;
        private ComboBox productCatCB;
        private Label label8;
        private DataGridViewTextBoxColumn prod_id;
        private DataGridViewTextBoxColumn prod_name;
        private DataGridViewTextBoxColumn prod_cat;
        private DataGridViewTextBoxColumn prod_qty;
        private DataGridViewTextBoxColumn prod_price;
        private DataGridViewTextBoxColumn prod_desc;
        private ComboBox searchCB;
        private Button btnSearch;
        private Button btnRefresh;
    }
}