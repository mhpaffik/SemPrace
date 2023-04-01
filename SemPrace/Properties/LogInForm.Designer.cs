namespace SemPrace
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            panel1 = new Panel();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            button1 = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 41);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(195, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 118);
            panel1.TabIndex = 1;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(183, 271);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(136, 23);
            usernameTB.TabIndex = 2;
            usernameTB.TabStop = false;
            usernameTB.Text = "Username";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(183, 318);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(136, 23);
            passwordTB.TabIndex = 3;
            passwordTB.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(183, 393);
            button1.Name = "button1";
            button1.Size = new Size(136, 35);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(183, 360);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(223, 359);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Passwrd";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(502, 542);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogInForm";
            Text = "Login";
            Load += LogInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Panel panel1;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button button1;
        private Label label2;
        private CheckBox checkBox1;
    }
}