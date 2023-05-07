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
    public partial class ManageCategories : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            SqLiteLibrary.createDB();
            SqLiteLibrary.createTable("create table if not exists categories (id varchar(20),name varchar(20))");
            dataShow();
        }

        private void dataShow()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();

            string stm = "SELECT * FROM categories";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                categoryListDGV.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private bool checkTB()
        {
            bool a = catIdTB.Text.Length != 0 && catNameTB.Text.Length != 0 ? true : false;
            return a;
        }

        private void btnInsertCat_Click(object sender, EventArgs e)
        {
            if (checkTB())
            {
                con = new SQLiteConnection(SqLiteLibrary.cs);
                con.Open();
                cmd = new SQLiteCommand(con);
                try
                {
                    cmd.CommandText = "INSERT INTO categories(id, name) VALUES(@id,@name)";
                    string id = catIdTB.Text;
                    string name = catNameTB.Text;

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);

                    categoryListDGV.ColumnCount = 2;
                    categoryListDGV.Columns[0].Name = "Category Id";
                    categoryListDGV.Columns[1].Name = "Category Name";

                    string[] row = new string[] { id, name };
                    categoryListDGV.Rows.Add(row);

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

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE categories SET name=@name WHERE id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", catIdTB.Text);
                cmd.Parameters.AddWithValue("@name", catNameTB.Text);
                cmd.ExecuteNonQuery();
                categoryListDGV.Rows.Clear();
                dataShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM categories WHERE id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", catIdTB.Text);
                cmd.ExecuteNonQuery();
                categoryListDGV.Rows.Clear();
                dataShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            catIdTB.Text = "";
            catNameTB.Text = "";
        }

        private void categoryListDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (categoryListDGV.SelectedRows.Count > 0)
                {
                    catIdTB.Text = categoryListDGV.SelectedRows[0].Cells[0].Value.ToString();
                    catNameTB.Text = categoryListDGV.SelectedRows[0].Cells[1].Value.ToString();

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
