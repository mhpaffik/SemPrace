namespace SemPrace
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            btnClearCat = new Label();
            panel1 = new Panel();
            label5 = new Label();
            categoryListDGV = new DataGridView();
            cat_id = new DataGridViewTextBoxColumn();
            cat_name = new DataGridViewTextBoxColumn();
            btnDeleteCat = new Button();
            btnUpdateCat = new Button();
            btnInsertCat = new Button();
            catNameTB = new TextBox();
            catIdTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)categoryListDGV).BeginInit();
            SuspendLayout();
            // 
            // btnClearCat
            // 
            btnClearCat.AutoSize = true;
            btnClearCat.BackColor = Color.Transparent;
            btnClearCat.ForeColor = Color.Red;
            btnClearCat.Location = new Point(175, 170);
            btnClearCat.Name = "btnClearCat";
            btnClearCat.Size = new Size(34, 15);
            btnClearCat.TabIndex = 26;
            btnClearCat.Text = "Clear";
            btnClearCat.Click += btnClearCat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(20, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 128);
            panel1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(514, 65);
            label5.Name = "label5";
            label5.Size = new Size(142, 30);
            label5.TabIndex = 24;
            label5.Text = "Category List";
            // 
            // categoryListDGV
            // 
            categoryListDGV.BackgroundColor = Color.White;
            categoryListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryListDGV.Columns.AddRange(new DataGridViewColumn[] { cat_id, cat_name });
            categoryListDGV.Location = new Point(357, 100);
            categoryListDGV.Name = "categoryListDGV";
            categoryListDGV.RowTemplate.Height = 25;
            categoryListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryListDGV.Size = new Size(424, 286);
            categoryListDGV.TabIndex = 23;
            categoryListDGV.MouseDoubleClick += categoryListDGV_MouseDoubleClick;
            // 
            // cat_id
            // 
            cat_id.HeaderText = "Category Id";
            cat_id.Name = "cat_id";
            // 
            // cat_name
            // 
            cat_name.HeaderText = "Category Name";
            cat_name.Name = "cat_name";
            cat_name.Width = 280;
            // 
            // btnDeleteCat
            // 
            btnDeleteCat.ForeColor = Color.Red;
            btnDeleteCat.Location = new Point(175, 319);
            btnDeleteCat.Name = "btnDeleteCat";
            btnDeleteCat.Size = new Size(144, 38);
            btnDeleteCat.TabIndex = 22;
            btnDeleteCat.Text = "Delete";
            btnDeleteCat.UseVisualStyleBackColor = true;
            btnDeleteCat.Click += btnDeleteCat_Click;
            // 
            // btnUpdateCat
            // 
            btnUpdateCat.ForeColor = Color.Green;
            btnUpdateCat.Location = new Point(175, 274);
            btnUpdateCat.Name = "btnUpdateCat";
            btnUpdateCat.Size = new Size(144, 39);
            btnUpdateCat.TabIndex = 21;
            btnUpdateCat.Text = "Update";
            btnUpdateCat.UseVisualStyleBackColor = true;
            btnUpdateCat.Click += btnUpdateCat_Click;
            // 
            // btnInsertCat
            // 
            btnInsertCat.ForeColor = Color.Navy;
            btnInsertCat.Location = new Point(175, 229);
            btnInsertCat.Name = "btnInsertCat";
            btnInsertCat.Size = new Size(144, 39);
            btnInsertCat.TabIndex = 20;
            btnInsertCat.Text = "Insert";
            btnInsertCat.UseVisualStyleBackColor = true;
            btnInsertCat.Click += btnInsertCat_Click;
            // 
            // catNameTB
            // 
            catNameTB.Location = new Point(175, 134);
            catNameTB.Name = "catNameTB";
            catNameTB.Size = new Size(144, 23);
            catNameTB.TabIndex = 18;
            // 
            // catIdTB
            // 
            catIdTB.Location = new Point(175, 100);
            catIdTB.Name = "catIdTB";
            catIdTB.Size = new Size(144, 23);
            catIdTB.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(47, 136);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 15;
            label2.Text = "Category Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(76, 102);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 14;
            label1.Text = "Category Id:";
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearCat);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(categoryListDGV);
            Controls.Add(btnDeleteCat);
            Controls.Add(btnUpdateCat);
            Controls.Add(btnInsertCat);
            Controls.Add(catNameTB);
            Controls.Add(catIdTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageCategories";
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)categoryListDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnClearCat;
        private Panel panel1;
        private Label label5;
        private DataGridView categoryListDGV;
        private Button btnDeleteCat;
        private Button btnUpdateCat;
        private Button btnInsertCat;
        private TextBox catNameTB;
        private TextBox catIdTB;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn cat_id;
        private DataGridViewTextBoxColumn cat_name;
    }
}