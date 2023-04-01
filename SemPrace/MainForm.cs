﻿using System;
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
    }
}
