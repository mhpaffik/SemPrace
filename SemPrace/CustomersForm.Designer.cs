namespace SemPrace
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            btnClearCust = new Label();
            panel1 = new Panel();
            btnDeleteCust = new Button();
            btnUpdateCust = new Button();
            btnInsertCust = new Button();
            custEmailTB = new TextBox();
            custNameTB = new TextBox();
            custIdTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            custPhoneTB = new TextBox();
            label4 = new Label();
            label5 = new Label();
            customerListDGV = new DataGridView();
            cust_id = new DataGridViewTextBoxColumn();
            cust_name = new DataGridViewTextBoxColumn();
            cust_email = new DataGridViewTextBoxColumn();
            cust_phone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customerListDGV).BeginInit();
            SuspendLayout();
            // 
            // btnClearCust
            // 
            btnClearCust.AutoSize = true;
            btnClearCust.BackColor = Color.Transparent;
            btnClearCust.ForeColor = Color.Red;
            btnClearCust.Location = new Point(167, 221);
            btnClearCust.Name = "btnClearCust";
            btnClearCust.Size = new Size(34, 15);
            btnClearCust.TabIndex = 24;
            btnClearCust.Text = "Clear";
            btnClearCust.Click += btnClearCust_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 128);
            panel1.TabIndex = 23;
            // 
            // btnDeleteCust
            // 
            btnDeleteCust.ForeColor = Color.Red;
            btnDeleteCust.Location = new Point(167, 338);
            btnDeleteCust.Name = "btnDeleteCust";
            btnDeleteCust.Size = new Size(144, 38);
            btnDeleteCust.TabIndex = 22;
            btnDeleteCust.Text = "Delete";
            btnDeleteCust.UseVisualStyleBackColor = true;
            btnDeleteCust.Click += btnDeleteCust_Click;
            // 
            // btnUpdateCust
            // 
            btnUpdateCust.ForeColor = Color.Green;
            btnUpdateCust.Location = new Point(167, 293);
            btnUpdateCust.Name = "btnUpdateCust";
            btnUpdateCust.Size = new Size(144, 39);
            btnUpdateCust.TabIndex = 21;
            btnUpdateCust.Text = "Update";
            btnUpdateCust.UseVisualStyleBackColor = true;
            btnUpdateCust.Click += btnUpdateCust_Click;
            // 
            // btnInsertCust
            // 
            btnInsertCust.ForeColor = Color.Navy;
            btnInsertCust.Location = new Point(167, 248);
            btnInsertCust.Name = "btnInsertCust";
            btnInsertCust.Size = new Size(144, 39);
            btnInsertCust.TabIndex = 20;
            btnInsertCust.Text = "Insert";
            btnInsertCust.UseVisualStyleBackColor = true;
            btnInsertCust.Click += btnInsertCust_Click;
            // 
            // custEmailTB
            // 
            custEmailTB.Location = new Point(167, 148);
            custEmailTB.Name = "custEmailTB";
            custEmailTB.Size = new Size(144, 23);
            custEmailTB.TabIndex = 19;
            // 
            // custNameTB
            // 
            custNameTB.Location = new Point(167, 119);
            custNameTB.Name = "custNameTB";
            custNameTB.Size = new Size(144, 23);
            custNameTB.TabIndex = 18;
            // 
            // custIdTB
            // 
            custIdTB.Location = new Point(167, 90);
            custIdTB.Name = "custIdTB";
            custIdTB.Size = new Size(144, 23);
            custIdTB.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 150);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 16;
            label3.Text = "Customer E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 121);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 15;
            label2.Text = "Customer Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 92);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 14;
            label1.Text = "Customer Id:";
            // 
            // custPhoneTB
            // 
            custPhoneTB.Location = new Point(167, 177);
            custPhoneTB.Name = "custPhoneTB";
            custPhoneTB.Size = new Size(144, 23);
            custPhoneTB.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 179);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 25;
            label4.Text = "Customer  Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(521, 55);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 28;
            label5.Text = "Customers List";
            // 
            // customerListDGV
            // 
            customerListDGV.BackgroundColor = Color.White;
            customerListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerListDGV.Columns.AddRange(new DataGridViewColumn[] { cust_id, cust_name, cust_email, cust_phone });
            customerListDGV.Location = new Point(364, 90);
            customerListDGV.Name = "customerListDGV";
            customerListDGV.RowTemplate.Height = 25;
            customerListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerListDGV.Size = new Size(424, 286);
            customerListDGV.TabIndex = 27;
            customerListDGV.MouseDoubleClick += customerListDGV_MouseDoubleClick;
            // 
            // cust_id
            // 
            cust_id.HeaderText = "Id";
            cust_id.Name = "cust_id";
            cust_id.Width = 30;
            // 
            // cust_name
            // 
            cust_name.HeaderText = "Name";
            cust_name.Name = "cust_name";
            cust_name.Width = 110;
            // 
            // cust_email
            // 
            cust_email.HeaderText = "CustEmail";
            cust_email.Name = "cust_email";
            cust_email.Width = 140;
            // 
            // cust_phone
            // 
            cust_phone.HeaderText = "Phone";
            cust_phone.Name = "cust_phone";
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(customerListDGV);
            Controls.Add(custPhoneTB);
            Controls.Add(label4);
            Controls.Add(btnClearCust);
            Controls.Add(panel1);
            Controls.Add(btnDeleteCust);
            Controls.Add(btnUpdateCust);
            Controls.Add(btnInsertCust);
            Controls.Add(custEmailTB);
            Controls.Add(custNameTB);
            Controls.Add(custIdTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerListDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnClearCust;
        private Panel panel1;
        private Button btnDeleteCust;
        private Button btnUpdateCust;
        private Button btnInsertCust;
        private TextBox custEmailTB;
        private TextBox custNameTB;
        private TextBox custIdTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox custPhoneTB;
        private Label label4;
        private Label label5;
        private DataGridView customerListDGV;
        private DataGridViewTextBoxColumn cust_id;
        private DataGridViewTextBoxColumn cust_name;
        private DataGridViewTextBoxColumn cust_email;
        private DataGridViewTextBoxColumn cust_phone;
    }
}