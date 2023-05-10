namespace SemPrace
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            label5 = new Label();
            custOrderListDGV = new DataGridView();
            cust_id = new DataGridViewTextBoxColumn();
            cust_name = new DataGridViewTextBoxColumn();
            cust_email = new DataGridViewTextBoxColumn();
            cust_phone = new DataGridViewTextBoxColumn();
            filterCB = new ComboBox();
            prodOrderListDGV = new DataGridView();
            prod_id = new DataGridViewTextBoxColumn();
            prod_name = new DataGridViewTextBoxColumn();
            prod_cat = new DataGridViewTextBoxColumn();
            prod_qty = new DataGridViewTextBoxColumn();
            prod_price = new DataGridViewTextBoxColumn();
            prod_desc = new DataGridViewTextBoxColumn();
            label1 = new Label();
            orderListDGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            qtyTB = new TextBox();
            btnAddOrder = new Button();
            orderIdTB = new TextBox();
            label3 = new Label();
            custIdTB = new TextBox();
            label4 = new Label();
            custNameTB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            orderDTP = new DateTimePicker();
            panel1 = new Panel();
            btnInsertOrder = new Button();
            btnViewOrders = new Button();
            btnClearOrders = new Label();
            label8 = new Label();
            totalLB = new Label();
            ((System.ComponentModel.ISupportInitialize)custOrderListDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodOrderListDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderListDGV).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(151, 9);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 30;
            label5.Text = "Customers List";
            // 
            // custOrderListDGV
            // 
            custOrderListDGV.AllowUserToAddRows = false;
            custOrderListDGV.AllowUserToDeleteRows = false;
            custOrderListDGV.AllowUserToResizeColumns = false;
            custOrderListDGV.AllowUserToResizeRows = false;
            custOrderListDGV.BackgroundColor = Color.White;
            custOrderListDGV.BorderStyle = BorderStyle.None;
            custOrderListDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            custOrderListDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            custOrderListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custOrderListDGV.Columns.AddRange(new DataGridViewColumn[] { cust_id, cust_name, cust_email, cust_phone });
            custOrderListDGV.Location = new Point(12, 51);
            custOrderListDGV.MultiSelect = false;
            custOrderListDGV.Name = "custOrderListDGV";
            custOrderListDGV.RowHeadersVisible = false;
            custOrderListDGV.RowTemplate.Height = 25;
            custOrderListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custOrderListDGV.Size = new Size(424, 205);
            custOrderListDGV.TabIndex = 29;
            custOrderListDGV.SelectionChanged += custOrderListDGV_SelectionChanged;
            // 
            // cust_id
            // 
            cust_id.HeaderText = "Id";
            cust_id.Name = "cust_id";
            cust_id.ReadOnly = true;
            cust_id.Resizable = DataGridViewTriState.False;
            cust_id.Width = 40;
            // 
            // cust_name
            // 
            cust_name.HeaderText = "Name";
            cust_name.Name = "cust_name";
            cust_name.ReadOnly = true;
            cust_name.Resizable = DataGridViewTriState.False;
            cust_name.Width = 110;
            // 
            // cust_email
            // 
            cust_email.HeaderText = "CustEmail";
            cust_email.Name = "cust_email";
            cust_email.ReadOnly = true;
            cust_email.Resizable = DataGridViewTriState.False;
            cust_email.Width = 160;
            // 
            // cust_phone
            // 
            cust_phone.HeaderText = "Phone";
            cust_phone.Name = "cust_phone";
            cust_phone.ReadOnly = true;
            cust_phone.Resizable = DataGridViewTriState.False;
            cust_phone.Width = 110;
            // 
            // filterCB
            // 
            filterCB.FormattingEnabled = true;
            filterCB.Location = new Point(696, 45);
            filterCB.Name = "filterCB";
            filterCB.Size = new Size(117, 23);
            filterCB.TabIndex = 51;
            filterCB.Text = "Select Category";
            filterCB.SelectedValueChanged += filterCB_SelectedValueChanged;
            // 
            // prodOrderListDGV
            // 
            prodOrderListDGV.AllowUserToAddRows = false;
            prodOrderListDGV.AllowUserToDeleteRows = false;
            prodOrderListDGV.AllowUserToResizeColumns = false;
            prodOrderListDGV.AllowUserToResizeRows = false;
            prodOrderListDGV.BackgroundColor = Color.White;
            prodOrderListDGV.BorderStyle = BorderStyle.None;
            prodOrderListDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            prodOrderListDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            prodOrderListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodOrderListDGV.Columns.AddRange(new DataGridViewColumn[] { prod_id, prod_name, prod_cat, prod_qty, prod_price, prod_desc });
            prodOrderListDGV.Location = new Point(474, 74);
            prodOrderListDGV.Name = "prodOrderListDGV";
            prodOrderListDGV.RowHeadersVisible = false;
            prodOrderListDGV.RowTemplate.Height = 25;
            prodOrderListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            prodOrderListDGV.Size = new Size(564, 182);
            prodOrderListDGV.TabIndex = 50;
            prodOrderListDGV.SelectionChanged += prodOrderListDGV_SelectionChanged;
            // 
            // prod_id
            // 
            prod_id.HeaderText = "Id";
            prod_id.Name = "prod_id";
            prod_id.ReadOnly = true;
            prod_id.Resizable = DataGridViewTriState.False;
            prod_id.Width = 40;
            // 
            // prod_name
            // 
            prod_name.HeaderText = "Name";
            prod_name.Name = "prod_name";
            prod_name.ReadOnly = true;
            prod_name.Resizable = DataGridViewTriState.False;
            // 
            // prod_cat
            // 
            prod_cat.HeaderText = "Category";
            prod_cat.Name = "prod_cat";
            prod_cat.ReadOnly = true;
            prod_cat.Resizable = DataGridViewTriState.False;
            prod_cat.Width = 110;
            // 
            // prod_qty
            // 
            prod_qty.HeaderText = "Quantity";
            prod_qty.Name = "prod_qty";
            prod_qty.ReadOnly = true;
            prod_qty.Resizable = DataGridViewTriState.False;
            prod_qty.Width = 60;
            // 
            // prod_price
            // 
            prod_price.HeaderText = "Price";
            prod_price.Name = "prod_price";
            prod_price.ReadOnly = true;
            prod_price.Resizable = DataGridViewTriState.False;
            // 
            // prod_desc
            // 
            prod_desc.HeaderText = "Description";
            prod_desc.Name = "prod_desc";
            prod_desc.ReadOnly = true;
            prod_desc.Resizable = DataGridViewTriState.False;
            prod_desc.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(696, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 52;
            label1.Text = "Product List";
            // 
            // orderListDGV
            // 
            orderListDGV.AllowUserToAddRows = false;
            orderListDGV.AllowUserToDeleteRows = false;
            orderListDGV.AllowUserToResizeColumns = false;
            orderListDGV.AllowUserToResizeRows = false;
            orderListDGV.BackgroundColor = Color.White;
            orderListDGV.BorderStyle = BorderStyle.None;
            orderListDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            orderListDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            orderListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderListDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            orderListDGV.Location = new Point(474, 316);
            orderListDGV.Name = "orderListDGV";
            orderListDGV.RowHeadersVisible = false;
            orderListDGV.RowTemplate.Height = 25;
            orderListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderListDGV.Size = new Size(564, 182);
            orderListDGV.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Number";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Product";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(643, 283);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 54;
            label2.Text = "Quantity:";
            // 
            // qtyTB
            // 
            qtyTB.Location = new Point(722, 283);
            qtyTB.Name = "qtyTB";
            qtyTB.Size = new Size(100, 23);
            qtyTB.TabIndex = 55;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(842, 283);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(100, 23);
            btnAddOrder.TabIndex = 56;
            btnAddOrder.Text = "Add to order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // orderIdTB
            // 
            orderIdTB.Location = new Point(143, 318);
            orderIdTB.Name = "orderIdTB";
            orderIdTB.Size = new Size(121, 23);
            orderIdTB.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 316);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 57;
            label3.Text = "Order Id:";
            // 
            // custIdTB
            // 
            custIdTB.Location = new Point(143, 349);
            custIdTB.Name = "custIdTB";
            custIdTB.ReadOnly = true;
            custIdTB.Size = new Size(121, 23);
            custIdTB.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 347);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 59;
            label4.Text = "Customer Id:";
            // 
            // custNameTB
            // 
            custNameTB.Location = new Point(143, 378);
            custNameTB.Name = "custNameTB";
            custNameTB.ReadOnly = true;
            custNameTB.Size = new Size(121, 23);
            custNameTB.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 376);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 61;
            label6.Text = "Customer Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 407);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 63;
            label7.Text = "Order Date:";
            // 
            // orderDTP
            // 
            orderDTP.Location = new Point(143, 407);
            orderDTP.Name = "orderDTP";
            orderDTP.Size = new Size(121, 23);
            orderDTP.TabIndex = 64;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 96);
            panel1.TabIndex = 65;
            // 
            // btnInsertOrder
            // 
            btnInsertOrder.Location = new Point(151, 460);
            btnInsertOrder.Name = "btnInsertOrder";
            btnInsertOrder.Size = new Size(113, 38);
            btnInsertOrder.TabIndex = 66;
            btnInsertOrder.Text = "Insert Order";
            btnInsertOrder.UseVisualStyleBackColor = true;
            btnInsertOrder.Click += btnInsertOrder_Click;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Location = new Point(151, 518);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(113, 38);
            btnViewOrders.TabIndex = 67;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnClearOrders
            // 
            btnClearOrders.AutoSize = true;
            btnClearOrders.BackColor = Color.Transparent;
            btnClearOrders.ForeColor = Color.Red;
            btnClearOrders.Location = new Point(948, 288);
            btnClearOrders.Name = "btnClearOrders";
            btnClearOrders.Size = new Size(34, 15);
            btnClearOrders.TabIndex = 68;
            btnClearOrders.Text = "Clear";
            btnClearOrders.Click += btnClearOrders_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(831, 518);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 69;
            label8.Text = "Total Price:";
            // 
            // totalLB
            // 
            totalLB.AutoSize = true;
            totalLB.BackColor = Color.Transparent;
            totalLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalLB.ForeColor = Color.Black;
            totalLB.Location = new Point(920, 518);
            totalLB.Name = "totalLB";
            totalLB.Size = new Size(0, 21);
            totalLB.TabIndex = 70;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 568);
            Controls.Add(totalLB);
            Controls.Add(label8);
            Controls.Add(btnClearOrders);
            Controls.Add(btnViewOrders);
            Controls.Add(btnInsertOrder);
            Controls.Add(panel1);
            Controls.Add(orderDTP);
            Controls.Add(label7);
            Controls.Add(custNameTB);
            Controls.Add(label6);
            Controls.Add(custIdTB);
            Controls.Add(label4);
            Controls.Add(orderIdTB);
            Controls.Add(label3);
            Controls.Add(btnAddOrder);
            Controls.Add(qtyTB);
            Controls.Add(label2);
            Controls.Add(orderListDGV);
            Controls.Add(label1);
            Controls.Add(filterCB);
            Controls.Add(prodOrderListDGV);
            Controls.Add(label5);
            Controls.Add(custOrderListDGV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageOrders";
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            ((System.ComponentModel.ISupportInitialize)custOrderListDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodOrderListDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderListDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView custOrderListDGV;
        private ComboBox filterCB;
        private DataGridView prodOrderListDGV;
        private Label label1;
        private DataGridView orderListDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label2;
        private TextBox qtyTB;
        private Button btnAddOrder;
        private TextBox orderIdTB;
        private Label label3;
        private TextBox custIdTB;
        private Label label4;
        private TextBox custNameTB;
        private Label label6;
        private Label label7;
        private DateTimePicker orderDTP;
        private Panel panel1;
        private Button btnInsertOrder;
        private Button btnViewOrders;
        private DataGridViewTextBoxColumn prod_id;
        private DataGridViewTextBoxColumn prod_name;
        private DataGridViewTextBoxColumn prod_cat;
        private DataGridViewTextBoxColumn prod_qty;
        private DataGridViewTextBoxColumn prod_price;
        private DataGridViewTextBoxColumn prod_desc;
        private DataGridViewTextBoxColumn cust_id;
        private DataGridViewTextBoxColumn cust_name;
        private DataGridViewTextBoxColumn cust_email;
        private DataGridViewTextBoxColumn cust_phone;
        private Label btnClearOrders;
        private Label label8;
        private Label totalLB;
    }
}