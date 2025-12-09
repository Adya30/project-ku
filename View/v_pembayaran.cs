using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TaniGrow2.Model;
using TaniGrow2.Controller;

namespace TaniGrow2.View
{
    public partial class v_pembayaran : Form
    {
        private readonly c_Pembayaran ctrl = new c_Pembayaran();
        private List<(m_produk produk, int jumlah)> keranjang;
        private int totalBelanja;

        // Path foto bukti pembayaran
        private string buktiPembayaranPath = "";

        public v_pembayaran(List<(m_produk produk, int jumlah)> keranjangBelanja)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Simpan keranjang
            keranjang = keranjangBelanja ?? new List<(m_produk, int)>();

            // Hitung total
            totalBelanja = keranjang.Sum(x => x.produk.HargaSatuan * x.jumlah);

            labeltotal.Text = totalBelanja.ToString("N0");
        }

        // ===========================================================
        // UPLOAD BUKTI PEMBAYARAN (QRIS)
        // ===========================================================
        private void pictureBoxBukti_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                buktiPembayaranPath = open.FileName;
                pictureBoxBukti.Image = Image.FromFile(buktiPembayaranPath);
            }
        }

        // ===========================================================
        // PROSES PEMBAYARAN
        // ===========================================================
        private void btnbayar_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbalamat.Text))
            {
                MessageBox.Show("Alamat pengiriman tidak boleh kosong!");
                return;
            }

            if (string.IsNullOrWhiteSpace(buktiPembayaranPath))
            {
                MessageBox.Show("Harap upload bukti pembayaran QRIS!");
                return;
            }

            // Konfirmasi
            var confirm = MessageBox.Show(
                $"Total belanja Rp {totalBelanja:N0}. Lanjutkan pembayaran?",
                "Konfirmasi Pembayaran",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            // Convert gambar bukti ke byte[]
            byte[] buktiBytes = File.ReadAllBytes(buktiPembayaranPath);

            
            bool sukses = ctrl.ProsesPembayaran(
                c_user.CurrentUser.IdUser,
                keranjang,
                tbalamat.Text.Trim(),
                buktiBytes
            );

            if (!sukses)
            {
                MessageBox.Show("Gagal menyimpan transaksi! Periksa koneksi database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Pembayaran berhasil! Pesanan sedang diproses.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            keranjang.Clear();

            new v_katalogcustomer().Show();
            this.Close();
        }

        // ===========================================================
        // BUTTON BATAL
        // ===========================================================
        private void btnbatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Batalkan pembayaran?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new v_katalogcustomer().Show();
                this.Close();
            }
        }
    }
}
