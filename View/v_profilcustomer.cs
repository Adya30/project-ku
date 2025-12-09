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
using TaniGrow2.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaniGrow2.View
{
    public partial class v_profilcustomer : Form
    {
        c_user controller = new c_user();
        public v_profilcustomer()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            LoadProfile();
            SetViewMode();   // mulai dari mode lihat
        }

        // ================================================
        // LOAD DATA USER
        // ================================================
        private void LoadProfile()
        {
            if (c_user.CurrentUser != null)
            {
                tbnamalengkap.Text = c_user.CurrentUser.NamaLengkap;
                tbusername.Text = c_user.CurrentUser.Username;
                tbnotelp.Text = c_user.CurrentUser.NoTelp;
                tbpassword.Text = c_user.CurrentUser.Password;
            }
            else
            {
                tbnamalengkap.Text = "";
                tbusername.Text = "";
                tbnotelp.Text = "";
                tbpassword.Text = "";
            }
        }

        // ================================================
        // MODE VIEW (textbox tidak bisa diedit)
        // ================================================
        private void SetViewMode()
        {
            tbnamalengkap.ReadOnly = true;
            tbusername.ReadOnly = true;
            tbnotelp.ReadOnly = true;
            tbpassword.ReadOnly = true;

            tbnamalengkap.BackColor = Color.LightGray;
            tbusername.BackColor = Color.LightGray;
            tbnotelp.BackColor = Color.LightGray;
            tbpassword.BackColor = Color.LightGray;

            btnedit.Visible = true;
            btnsimpan.Visible = false;
            btnbatal.Visible = false;
        }

        // ================================================
        // MODE EDIT (textbox bisa diedit)
        // ================================================
        private void SetEditMode()
        {
            tbnamalengkap.ReadOnly = false;
            tbusername.ReadOnly = false;
            tbnotelp.ReadOnly = false;
            tbpassword.ReadOnly = false;

            tbnamalengkap.BackColor = Color.White;
            tbusername.BackColor = Color.White;
            tbnotelp.BackColor = Color.White;
            tbpassword.BackColor = Color.White;

            btnedit.Visible = false;
            btnsimpan.Visible = true;
            btnbatal.Visible = true;
        }

        // ================================================
        // TOMBOL EDIT
        // ================================================
        private void btnedit_Click(object sender, EventArgs e)
        {
            SetEditMode();
        }

        // ================================================
        // TOMBOL SAVE
        // ================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (tbusername.Text.Trim() == "" || tbpassword.Text.Trim() == "" ||
                tbnamalengkap.Text.Trim() == "" || tbnotelp.Text.Trim() == "")
            {
                MessageBox.Show("Tidak boleh kosong!");
                return;
            }

            string hasil = controller.UpdateProfile(
                tbnamalengkap.Text.Trim(),
                tbusername.Text.Trim(),
                tbnotelp.Text.Trim(),
                tbpassword.Text.Trim()
            );

            MessageBox.Show(hasil);

            if (hasil == "Update Profil Berhasil")
            {
                SetViewMode();
            }
        }


        // ================================================
        // TOMBOL CANCEL
        // ================================================
        private void btnbatal_Click(object sender, EventArgs e)
        {
            LoadProfile();    // kembalikan nilai lama
            SetViewMode();
        }

        
        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new v_login().Show();
                this.Close();
            }
        }

        private void btnprofilcustomer_Click(object sender, EventArgs e)
        {
        }

        private void btnriwayatcustomer_Click(object sender, EventArgs e)
        {
            new v_riwayatcustomer().Show();
            this.Close();
        }

        private void btnpesanancustomer_Click(object sender, EventArgs e)
        {
            new v_pesanancustomer().Show();
            this.Close();
        }

        private void btnkatalogcustomer_Click(object sender, EventArgs e)
        {
            new v_katalogcustomer().Show();
            this.Close();
        }
    }
}