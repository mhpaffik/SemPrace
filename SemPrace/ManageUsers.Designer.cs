namespace SemPrace
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameTB = new TextBox();
            passwordTB = new TextBox();
            emailTB = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            userListDGV = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnClear = new Label();
            ((System.ComponentModel.ISupportInitialize)userListDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 138);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 172);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 205);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "E-mail:";
            // 
            // userNameTB
            // 
            userNameTB.Location = new Point(167, 136);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(144, 23);
            userNameTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(167, 170);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(144, 23);
            passwordTB.TabIndex = 4;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(167, 203);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(144, 23);
            emailTB.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.ForeColor = Color.Navy;
            btnInsert.Location = new Point(167, 265);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(144, 39);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Green;
            btnUpdate.Location = new Point(167, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 39);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(167, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // userListDGV
            // 
            userListDGV.BackgroundColor = Color.White;
            userListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userListDGV.Columns.AddRange(new DataGridViewColumn[] { username, password, email });
            userListDGV.Location = new Point(349, 136);
            userListDGV.Name = "userListDGV";
            userListDGV.RowTemplate.Height = 25;
            userListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userListDGV.Size = new Size(424, 286);
            userListDGV.TabIndex = 9;
            userListDGV.CellContentClick += userListDGV_CellContentClick;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.Name = "username";
            username.Width = 140;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.Name = "password";
            password.Width = 120;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            email.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(287, 9);
            label4.Name = "label4";
            label4.Size = new Size(175, 32);
            label4.TabIndex = 10;
            label4.Text = "Manage Users";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(506, 101);
            label5.Name = "label5";
            label5.Size = new Size(96, 30);
            label5.TabIndex = 11;
            label5.Text = "User List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 128);
            panel1.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.Transparent;
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(167, 238);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(34, 15);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(userListDGV);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(emailTB);
            Controls.Add(passwordTB);
            Controls.Add(userNameTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManageUsers";
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)userListDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userNameTB;
        private TextBox passwordTB;
        private TextBox emailTB;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView userListDGV;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn email;
        private Label btnClear;
    }
}