using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SemPrace
{
    public partial class ManageUsers : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void dataShow()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();

            string stm = "SELECT * FROM users";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                userListDGV.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkTB())
            {
                con = new SQLiteConnection(SqLiteLibrary.cs);
                con.Open();
                cmd = new SQLiteCommand(con);
                try
                {
                    cmd.CommandText = "INSERT INTO users(username, password, email) VALUES(@name,@pass,@email)";
                    string name = userNameTB.Text;
                    string pass = passwordTB.Text;
                    string email = emailTB.Text;

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@email", email);

                    userListDGV.ColumnCount = 3;
                    userListDGV.Columns[0].Name = "Username";
                    userListDGV.Columns[1].Name = "Password";
                    userListDGV.Columns[2].Name = "Email";
                    string[] row = new string[] { name, pass, email };
                    userListDGV.Rows.Add(row);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot insert data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data cannot be empty!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE users SET password=@pass, email=@email WHERE username=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", userNameTB.Text);
                cmd.Parameters.AddWithValue("@pass", passwordTB.Text);
                cmd.Parameters.AddWithValue("@email", emailTB.Text);
                cmd.ExecuteNonQuery();
                userListDGV.Rows.Clear();
                dataShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM users WHERE username=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", userNameTB.Text);
                cmd.ExecuteNonQuery();
                userListDGV.Rows.Clear();
                dataShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            SqLiteLibrary.createDB();
            SqLiteLibrary.createTable("create table if not exists users (username varchar(20), password varchar(20), email varchar(20))");
            dataShow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            userNameTB.Text = "";
            passwordTB.Text = "";
            emailTB.Text = "";
        }

        private bool checkTB()
        {
            bool a = userNameTB.Text.Length != 0 && passwordTB.Text.Length != 0 && emailTB.Text.Length != 0 ? true : false;
            return a;
        }

        private void userListDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (userListDGV.SelectedRows.Count > 0)
                {
                    userNameTB.Text = userListDGV.SelectedRows[0].Cells[0].Value.ToString();
                    passwordTB.Text = userListDGV.SelectedRows[0].Cells[1].Value.ToString();
                    emailTB.Text = userListDGV.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
