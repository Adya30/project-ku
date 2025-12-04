using TaniGrow2.Controller;

namespace TaniGrow2.View
{
    public partial class v_profiladmin : Form
    {
        public v_profiladmin()
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
                tbusername.Text = c_user.CurrentUser.Username;
                tbpassword.Text = c_user.CurrentUser.Password;
            }
            else
            {
                tbusername.Text = "";
                tbpassword.Text = "";
            }
        }

        // ================================================
        // MODE VIEW (textbox tidak bisa diedit)
        // ================================================
        private void SetViewMode()
        {
            tbusername.ReadOnly = true;
            tbpassword.ReadOnly = true;

            tbusername.BackColor = Color.LightGray;
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
            tbusername.ReadOnly = false;
            tbpassword.ReadOnly = false;

            tbusername.BackColor = Color.White;
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
            if (tbusername.Text.Trim() == "" || tbpassword.Text.Trim() == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!");
                return;
            }

            // Simpan ke objek user
            c_user.CurrentUser.Username = tbusername.Text.Trim();
            c_user.CurrentUser.Password = tbpassword.Text.Trim();

            MessageBox.Show("Profil berhasil diperbarui!");

            SetViewMode();
        }

        // ================================================
        // TOMBOL CANCEL
        // ================================================
        private void btnbatal_Click(object sender, EventArgs e)
        {
            LoadProfile();    // kembalikan nilai lama
            SetViewMode();
        }

        private void btnkatalogadmin_Click(object sender, EventArgs e)
        {
            new v_katalogadmin().Show();
            this.Close();
        }

        private void btnpesananadmin_Click(object sender, EventArgs e)
        {
            new v_pesananadmin().Show();
            this.Close();
        }

        private void btnriwayatadmin_Click(object sender, EventArgs e)
        {
            new v_riwayatadmin().Show();
            this.Close();
        }

        //private void btnfeedbackadmin_Click(object sender, EventArgs e)
        //{
        //    new v_feedbackadmin().Show();
        //    this.Close();
        //}

        private void btnprofiladmin_Click(object sender, EventArgs e)
        {
            new v_profiladmin().Show();
            this.Close();
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

        private void v_katalogadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
