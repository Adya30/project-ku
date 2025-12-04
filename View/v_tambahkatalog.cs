using TaniGrow2.Controller;
using TaniGrow2.Model;

namespace TaniGrow2.View
{
    public partial class v_tambahkatalog : Form
    {
        private c_produk ctrlProduk;
        private v_katalogadmin parentForm;
        private m_produk editProduk;
        private byte[]? fotoByte = null;

        private Dictionary<string, int> kategoriMap = new Dictionary<string, int>();

        public v_tambahkatalog(v_katalogadmin parent, m_produk? produk = null)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            parentForm = parent;
            ctrlProduk = new c_produk();
            editProduk = produk;

            LoadKategoriComboBox();

            btnpicture.Text = "";
            btnpicture.SizeMode = PictureBoxSizeMode.Zoom;
            btnpicture.BorderStyle = BorderStyle.FixedSingle;

            if (editProduk != null)
            {
                tbnama_produk.Text = editProduk.NamaProduk;
                cbjenisproduk.SelectedItem = editProduk.NamaKategori;
                tbstok.Text = editProduk.StokProduk.ToString();
            }
            else
            {
                tbstok.Text = "0";
            }
            tbstok.ReadOnly = true;

            if (editProduk != null)
            {
                tbharga.Text = editProduk.HargaSatuan.ToString();
                rbdeskripsi.Text = editProduk.Deskripsi;

                if (editProduk.FotoProduk != null)
                {
                    try
                    {
                        using var ms = new MemoryStream(editProduk.FotoProduk);
                        btnpicture.Image = new Bitmap(ms);
                        fotoByte = editProduk.FotoProduk;
                    }
                    catch
                    {
                        btnpicture.Image = null;
                        fotoByte = null;
                    }
                }
            }
        }

        private void LoadKategoriComboBox()
        {
            cbjenisproduk.Items.Clear();
            kategoriMap.Clear();

            try
            {
                kategoriMap = ctrlProduk.GetKategoriMap();
                foreach (var nama in kategoriMap.Keys)
                {
                    cbjenisproduk.Items.Add(nama);
                }
                if (cbjenisproduk.Items.Count > 0)
                    cbjenisproduk.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load kategori: " + ex.Message);
            }
        }

        private void btnpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        var img = Image.FromStream(fs);
                        btnpicture.Image = new Bitmap(img);
                    }
                    fotoByte = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Gagal memuat gambar.");
                    btnpicture.Image = null;
                    fotoByte = null;
                }
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbnama_produk.Text) || cbjenisproduk.SelectedItem == null)
            {
                MessageBox.Show("Nama produk dan kategori harus diisi!");
                return;
            }

            if (!int.TryParse(tbharga.Text, out int hargaValue) || hargaValue < 0)
            {
                MessageBox.Show("Harga harus berupa angka bulat >= 0");
                return;
            }

            var produk = editProduk ?? new m_produk();
            produk.NamaProduk = tbnama_produk.Text;
            produk.StokProduk = editProduk != null ? editProduk.StokProduk : 0; // tetap stok lama / default 0
            produk.HargaSatuan = hargaValue;
            produk.Deskripsi = rbdeskripsi.Text;
            produk.FotoProduk = fotoByte;

            string kategoriTerpilih = cbjenisproduk.SelectedItem.ToString();
            if (kategoriMap.ContainsKey(kategoriTerpilih))
            {
                produk.IdKategoriProduk = kategoriMap[kategoriTerpilih];
                produk.NamaKategori = kategoriTerpilih;
            }
            else
            {
                MessageBox.Show("Kategori tidak valid!");
                return;
            }

            try
            {
                bool success = editProduk == null ? ctrlProduk.AddProduk(produk) : ctrlProduk.UpdateProduk(produk);
                if (success)
                {
                    MessageBox.Show("Data berhasil disimpan");
                    parentForm.LoadKatalog();
                    this.Close();
                    parentForm.Show();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message);
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnkatalogadmin_Click(object sender, EventArgs e) { }
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

        private void stok_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
