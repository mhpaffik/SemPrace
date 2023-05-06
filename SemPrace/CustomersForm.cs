using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemPrace
{
    public partial class CustomersForm : Form
    {

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            SqLiteLibrary.createDB();
            SqLiteLibrary.createTable("create table if not exists customers (id varchar(20),name varchar(20),email varchar(20),phone varchar(20))");
            dataShow();
        }

        private void dataShow()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();

            string stm = "SELECT * FROM customers";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                customerListDGV.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
            }
        }

        private bool checkTB()
        {
            bool a = custIdTB.Text.Length != 0 && custNameTB.Text.Length != 0 && custEmailTB.Text.Length != 0 && custPhoneTB.Text.Length != 0 ? true : false;
            return a;
        }

        private void btnInsertCust_Click(object sender, EventArgs e)
        {
            if (checkTB())
            {
                con = new SQLiteConnection(SqLiteLibrary.cs);
                con.Open();
                cmd = new SQLiteCommand(con);
                try
                {
                    cmd.CommandText = "INSERT INTO customers(id, name, email, phone) VALUES(@id,@name,@email,@phone)";
                    string id = custIdTB.Text;
                    string name = custNameTB.Text;
                    string phone = custPhoneTB.Text;
                    string email = custEmailTB.Text;

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    customerListDGV.ColumnCount = 4;
                    customerListDGV.Columns[0].Name = "Id";
                    customerListDGV.Columns[1].Name = "Name";
                    customerListDGV.Columns[2].Name = "Email";
                    customerListDGV.Columns[2].Name = "Phone";
                    string[] row = new string[] { id, name, email, phone };
                    customerListDGV.Rows.Add(row);

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

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE customers SET name=@name, email=@email, phone=@phone WHERE id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", custIdTB.Text);
                cmd.Parameters.AddWithValue("@name", custNameTB.Text);
                cmd.Parameters.AddWithValue("@email", custEmailTB.Text);
                cmd.Parameters.AddWithValue("@phone", custPhoneTB.Text);
                cmd.ExecuteNonQuery();
                customerListDGV.Rows.Clear();
                dataShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM customers WHERE id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", custIdTB.Text);
                cmd.ExecuteNonQuery();
                customerListDGV.Rows.Clear();
                dataShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearCust_Click(object sender, EventArgs e)
        {
            custIdTB.Text = "";
            custNameTB.Text = "";
            custEmailTB.Text = "";
            custPhoneTB.Text = "";
        }

        private void customerListDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (customerListDGV.SelectedRows.Count > 0)
                {
                    custIdTB.Text = customerListDGV.SelectedRows[0].Cells[0].Value.ToString();
                    custNameTB.Text = customerListDGV.SelectedRows[0].Cells[1].Value.ToString();
                    custEmailTB.Text = customerListDGV.SelectedRows[0].Cells[2].Value.ToString();
                    custPhoneTB.Text = customerListDGV.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
