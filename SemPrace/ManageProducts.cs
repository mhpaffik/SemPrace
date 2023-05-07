using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemPrace
{
    public partial class ManageProducts : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void fillCategory()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            string query = "SELECT name FROM categories";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                productCatCB.Items.Add(dr.GetString(0));
            }
            productCatCB.Text = "--Category--";
            con.Close();
        }

        private void fillSearch()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            string query = "SELECT name FROM categories";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                searchCB.Items.Add(dr.GetString(0));
            }
            searchCB.Text = "--Category--";
            con.Close();
        }

        private void dataShow()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From products", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    productListDGV.Rows.Add(new object[] {
            read.GetValue(0),
            read.GetValue(1),
            read.GetValue(2),
            read.GetValue(3),
            read.GetValue(4),
            read.GetValue(5),
            });
                }
            }
            con.Close();
        }

        private bool checkTB()
        {
            bool a = productIdTB.Text.Length != 0 && productNameTB.Text.Length != 0 && productCatCB.Text.Length != 0 && productPriceTB.Text.Length != 0 && productQtyTB.Text.Length != 0 ? true : false;
            return a;
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            if (checkTB())
            {
                con = new SQLiteConnection(SqLiteLibrary.cs);
                con.Open();
                cmd = new SQLiteCommand(con);
                try
                {
                    cmd.CommandText = "INSERT INTO products(id, name, category, quantity, price, description) VALUES(@id,@name,@category,@quantity,@price,@description)";
                    string id = productIdTB.Text;
                    string name = productNameTB.Text;
                    string category = productCatCB.Text;
                    int quantity = 0;
                    double price = 0;
                    string description = productDescTB.Text;
                    try
                    {
                        quantity = Int32.Parse(productQtyTB.Text);
                        price = Double.Parse(productPriceTB.Text);

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@description", description);

                        productListDGV.ColumnCount = 6;
                        productListDGV.Columns[0].Name = "Id";
                        productListDGV.Columns[1].Name = "Name";
                        productListDGV.Columns[2].Name = "Category";
                        productListDGV.Columns[3].Name = "Quantity";
                        productListDGV.Columns[4].Name = "Price";
                        productListDGV.Columns[5].Name = "Description";

                        string[] row = new string[] { id, name, category, quantity.ToString(), price.ToString(), description };
                        productListDGV.Rows.Add(row);

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Quantity or price should be a number!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE products SET name=@name, category=@category, quantity=@qty, price=@price, description=@desc WHERE id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", productNameTB.Text);
                cmd.Parameters.AddWithValue("@category", productCatCB.Text);
                cmd.Parameters.AddWithValue("@qty", Int32.Parse(productQtyTB.Text));
                cmd.Parameters.AddWithValue("@price", Double.Parse(productPriceTB.Text));
                cmd.Parameters.AddWithValue("@desc", productDescTB.Text);
                cmd.ExecuteNonQuery();
                productListDGV.Rows.Clear();
                dataShow();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM products WHERE id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", productIdTB.Text);
                cmd.ExecuteNonQuery();
                productListDGV.Rows.Clear();
                dataShow();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {
            productIdTB.Text = "";
            productNameTB.Text = "";
            productCatCB.Text = "";
            productQtyTB.Text = "";
            productPriceTB.Text = "";
            productDescTB.Text = "";
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            SqLiteLibrary.createDB();
            SqLiteLibrary.createTable("create table if not exists products (id varchar(20),name varchar(20),category varchar(20),quantity int,price real, description varchar(30))");
            fillCategory();
            fillSearch();
            dataShow();
        }

        private void productListDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (productListDGV.SelectedRows.Count > 0)
                {
                    productIdTB.Text = productListDGV.SelectedRows[0].Cells[0].Value.ToString();
                    productNameTB.Text = productListDGV.SelectedRows[0].Cells[1].Value.ToString();
                    productCatCB.Text = productListDGV.SelectedRows[0].Cells[2].Value.ToString();
                    productQtyTB.Text = productListDGV.SelectedRows[0].Cells[3].Value.ToString();
                    productPriceTB.Text = productListDGV.SelectedRows[0].Cells[4].Value.ToString();
                    productDescTB.Text = productListDGV.SelectedRows[0].Cells[5].Value.ToString();

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            productListDGV.Rows.Clear();
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From products Where category=@cat", con);
            comm.Prepare();
            comm.Parameters.AddWithValue("@cat", searchCB.Text);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    productListDGV.Rows.Add(new object[] {
            read.GetValue(0),
            read.GetValue(1),
            read.GetValue(2),
            read.GetValue(3),
            read.GetValue(4),
            read.GetValue(5),
            });
                }
            }
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataShow();
            searchCB.Text = "--Category--";
        }
    }
}
