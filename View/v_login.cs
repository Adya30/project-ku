using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaniGrow2.Controller;

namespace TaniGrow2.View
{
    public partial class v_login : Form
    {
        private readonly c_user userController;

        public v_login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            userController = new c_user();
            linkdaftar.LinkClicked += LinkDaftar_Click;
        }

        private void LinkDaftar_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_register reg = new v_register();
            reg.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tblogin_username.Text.Trim();
            string password = tblogin_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = userController.Login(username, password);

            if (result == "LOGIN_ADMIN")
            {
                MessageBox.Show("Login berhasil sebagai Admin!");
                v_katalogadmin adminPage = new v_katalogadmin();
                adminPage.Show();
                this.Hide();
            }
            else if (result == "LOGIN_CUSTOMER")
            {
                MessageBox.Show("Login berhasil sebagai Customer!");
                v_katalogcustomer customerPage = new v_katalogcustomer();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void linkdaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_register reg = new v_register();
            reg.Show();
            this.Hide();
        }
    }
}

