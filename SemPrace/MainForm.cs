using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemPrace
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitLogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersLogo_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.MdiParent = this.MdiParent;
            manageUsers.Show();
        }

        private void logoutLogo_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.Show();
            this.Hide();
        }

        private void customersLogo_Click(object sender, EventArgs e)
        {
            CustomersForm manageCustomers = new CustomersForm();
            manageCustomers.MdiParent = this.MdiParent;
            manageCustomers.Show();
        }

        private void productsLogo_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.MdiParent = this.MdiParent;
            manageProducts.Show();
        }

        private void categoriesLogo_Click(object sender, EventArgs e)
        {
            ManageCategories manageCategories = new ManageCategories();
            manageCategories.MdiParent = this.MdiParent;
            manageCategories.Show();
        }

        private void ordersLogo_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.MdiParent = this.MdiParent;
            manageOrders.Show();
        }
    }
}
