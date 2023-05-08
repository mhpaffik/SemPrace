using System;
using System.Collections;
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
    public partial class ManageOrders : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        double price = 0, total = 0, sum = 0;
        int quantity = 0, num = 0, stock = 0;
        string product = "";
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void fillCustomer()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();

            string stm = "SELECT * FROM customers";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                custOrderListDGV.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
            }
        }

        private void fillFilter()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            string query = "SELECT name FROM categories";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                filterCB.Items.Add(dr.GetString(0));
            }
            filterCB.Items.Add("None");
            con.Close();
        }

        private void fillProduct()
        {
            prodOrderListDGV.Rows.Clear();
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From products", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    prodOrderListDGV.Rows.Add(new object[] {
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

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            SqLiteLibrary.createDB();
            SqLiteLibrary.createTable("create table if not exists orders (orderId varchar(20),custId varchar(20), custName varchar(20), orderDate datetime, totalAmount real)");
            fillCustomer();
            fillFilter();
            fillProduct();
            custOrderListDGV.Sort(custOrderListDGV.Columns[0], ListSortDirection.Ascending);
        }

        private void filterCB_SelectedValueChanged(object sender, EventArgs e)
        {
            prodOrderListDGV.Rows.Clear();
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            string sql = "";
            if (filterCB.Text == "None")
            {
                sql = "Select * From products";
            }
            else
            {
                sql = "Select * From products Where category=@cat";
            }
            SQLiteCommand comm = new SQLiteCommand(sql, con);
            comm.Prepare();
            comm.Parameters.AddWithValue("@cat", filterCB.Text);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    prodOrderListDGV.Rows.Add(new object[] {
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

        private void custOrderListDGV_SelectionChanged(object sender, EventArgs e)
        {
            custIdTB.Text = custOrderListDGV.SelectedRows[0].Cells[0].Value.ToString();
            custNameTB.Text = custOrderListDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void prodOrderListDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (prodOrderListDGV.SelectedRows.Count > 0)
            {
                product = prodOrderListDGV.SelectedRows[0].Cells[1].Value.ToString();
                price = Convert.ToDouble(prodOrderListDGV.SelectedRows[0].Cells[4].Value.ToString());
                stock = Convert.ToInt32(prodOrderListDGV.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (qtyTB.Text == "")
            {
                MessageBox.Show("Fill Quantity!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(qtyTB.Text) > stock)
                {
                    MessageBox.Show("Out of stock!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        num += 1;
                        quantity = Convert.ToInt32(qtyTB.Text);
                        total = quantity * price;
                        orderListDGV.Rows.Add(num, product, quantity, price, total);
                        sum += total;
                        totalLB.Text = sum.ToString();
                        updateData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Quantity should be a number!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnClearOrders_Click(object sender, EventArgs e)
        {
            orderListDGV.Rows.Clear();
            num = 0;
            totalLB.Text = "";
            sum = 0;
            qtyTB.Text = "";
        }

        private void updateData()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            int id = Convert.ToInt32(prodOrderListDGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(qtyTB.Text);
            string sql = "update products set quantity=@q where id=@id";
            SQLiteCommand comm = new SQLiteCommand(sql, con);
            comm.Prepare();
            comm.Parameters.AddWithValue("@q", newQty);
            comm.Parameters.AddWithValue("@id", id);
            comm.ExecuteNonQuery();
            con.Close();
            fillProduct();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if (orderIdTB.Text == "" || custIdTB.Text == "" || custNameTB.Text == "" || totalLB.Text == "")
            {
                MessageBox.Show("Fill the data corectly!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new SQLiteConnection(SqLiteLibrary.cs);
                con.Open();
                try
                {
                    string sql = "INSERT INTO orders (orderId,custId,custName,orderDate,totalAmount) VALUES(@id,@cid,@cname,@date,@tot)";
                    SQLiteCommand comm = new SQLiteCommand(sql, con);
                    comm.Prepare();
                    comm.Parameters.AddWithValue("@id", orderIdTB.Text);
                    comm.Parameters.AddWithValue("@cid", custIdTB.Text);
                    comm.Parameters.AddWithValue("@cname", custNameTB.Text);
                    comm.Parameters.AddWithValue("@date", orderDTP.Value);
                    comm.Parameters.AddWithValue("@tot", Convert.ToDouble(totalLB.Text));
                    comm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order add successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot insert data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

