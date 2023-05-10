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
    public partial class ViewOrders : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void dataShow()
        {
            con = new SQLiteConnection(SqLiteLibrary.cs);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From orders", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    orderListDGV.Rows.Add(new object[] {
            read.GetValue(0),
            read.GetValue(1),
            read.GetValue(2),
            read.GetValue(3),
            read.GetValue(4),
            });
                }
            }
            con.Close();
        }

        private void orderListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printOrders.Print();
            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            dataShow();
        }

        private void printOrders_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summury", new Font("Century", 30, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order Id: " + orderListDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Customer Id: " + orderListDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Black, new Point(80, 130));
            e.Graphics.DrawString("Customer Name: " + orderListDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Black, new Point(80, 160));
            e.Graphics.DrawString("Order Date: " + orderListDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Total Amount: " + orderListDGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Black, new Point(80, 220));
        }
    }
}
