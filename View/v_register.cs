
using TaniGrow2.Controller;

namespace TaniGrow2.View
{

    public partial class v_register : Form
    {
        private c_user controller;

        public v_register()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            controller = new c_user();
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLoginForm();
        }

        public void OpenLoginForm()
        {
            new v_login().Show();
            this.Close();
        }



        private void btndaftar_Click(object sender, EventArgs e)
        {
            string namaLengkap = tbnama_lengkap.Text.Trim();
            string username = tbusername_register.Text.Trim();
            string noTelp = tbno_telp.Text.Trim();
            string password = tbpassword_register.Text.Trim();
            string konfirmasi = tbkonfirmasi_password.Text.Trim();

            if (namaLengkap == "" || username == "" || noTelp == "" || password == "" || konfirmasi == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username minimal 4 karakter!");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter!");
                return;
            }

            if (!long.TryParse(noTelp, out _))
            {
                MessageBox.Show("Nomor telepon harus berupa angka!");
                return;
            }

            string result = controller.RegisterCustomer(
                namaLengkap, username, noTelp, password, konfirmasi);

            if (result == "Pendaftaran Berhasil")
            {
                MessageBox.Show("Akun berhasil dibuat! Silakan login.");
                v_login loginForm = new v_login();
                loginForm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show(result);
            }
        }


    }
}

