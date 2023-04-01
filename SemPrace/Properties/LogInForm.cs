using System.Data;
using System.Data.SQLite;

namespace SemPrace
{
    public partial class LogInForm : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\data_tb.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        public LogInForm()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTB.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text.Trim() == "" || passwordTB.Text.Trim() == "")
            {
                MessageBox.Show("Empty fields", "Error");
            }
            else
            {
                string query = "SELECT * FROM users WHERE username= @name AND password= @pass";
                con = new SQLiteConnection(cs);
                con.Open();
                cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@name", usernameTB.Text);
                cmd.Parameters.AddWithValue("@pass", passwordTB.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error");
                }
            }
        }
    }
}