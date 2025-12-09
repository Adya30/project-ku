using TaniGrow2.Controller;
using TaniGrow2.Model;

namespace TaniGrow2.View
{
    public partial class v_katalogcustomer : Form
    {
        private c_produk ctrlProduk;
        private int? userId;

        private List<(m_produk produk, int jumlah)> keranjang;

        public v_katalogcustomer(int? idUser = null)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            panelflow.AutoScroll = true;
            panelflow.FlowDirection = FlowDirection.LeftToRight;
            panelflow.WrapContents = true;

            ctrlProduk = new c_produk();
            userId = idUser;
            keranjang = new List<(m_produk, int)>();

            LoadKatalog();
            UpdateRingkasan();
        }

        // ===============================================================
        // LOAD KATALOG
        // ===============================================================
        public void LoadKatalog()
        {
            panelflow.Controls.Clear();

            var listProduk = ctrlProduk.GetProdukList();

            foreach (var p in listProduk)
            {
                if (p.StokProduk <= 0)
                    continue;

                var card = CreateCard(p);
                panelflow.Controls.Add(card);
            }
        }

        // ---------------------------------------------------------------
        // CARD PRODUK
        // ---------------------------------------------------------------
        private Panel CreateCard(m_produk produk)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 380,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            PictureBox pic = new PictureBox
            {
                Width = card.Width - 20,
                Height = 140,
                Top = 10,
                Left = 10,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (produk.FotoProduk != null)
            {
                using (var ms = new MemoryStream(produk.FotoProduk))
                {
                    pic.Image = Image.FromStream(ms);
                }
            }

            Label lblNama = new Label
            {
                Text = produk.NamaProduk,
                Top = pic.Bottom + 10,
                Left = 10,
                Width = card.Width - 20,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoEllipsis = true
            };

            Label lblStok = new Label
            {
                Text = "Stok: " + produk.StokProduk,
                Top = lblNama.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                ForeColor = produk.StokProduk == 0 ? Color.Red : Color.Black
            };

            Label lblHarga = new Label
            {
                Text = "Harga: Rp." + produk.HargaSatuan,
                Top = lblStok.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                ForeColor = Color.DarkGreen,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label lblDeskripsi = new Label
            {
                Text = produk.Deskripsi,
                Top = lblHarga.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                Height = 50,
                AutoSize = false,
                MaximumSize = new Size(card.Width - 20, 50),
                Font = new Font("Arial", 9),
                ForeColor = Color.DimGray
            };

            Button btnPesan = new Button
            {
                Text = "Pesan",
                Width = 120,
                Height = 35,
                Top = card.Height - 60,
                Left = (card.Width - 120) / 2,
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnPesan.Click += (s, e) =>
            {
                if (produk.StokProduk <= 0)
                {
                    MessageBox.Show("Maaf, stok produk habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TambahKeKeranjang(produk);
                UpdateRingkasan();
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHarga);
            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(btnPesan);

            return card;
        }

        // ===============================================================
        // TAMBAH KE KERANJANG
        // ===============================================================
        private void TambahKeKeranjang(m_produk produk)
        {
            var idx = keranjang.FindIndex(x => x.produk.IdProduk == produk.IdProduk);
            if (idx >= 0)
            {
                var item = keranjang[idx];
                if (item.jumlah + 1 <= produk.StokProduk)
                    keranjang[idx] = (item.produk, item.jumlah + 1);
                else
                    MessageBox.Show("Jumlah melebihi stok tersedia!");
            }
            else
            {
                keranjang.Add((produk, 1));
            }
        }

        // ===============================================================
        // RINGKASAN KERANJANG
        // ===============================================================
        private void UpdateRingkasan()
        {
            panel1.Controls.Clear();

            Panel panelItems = new Panel
            {
                AutoScroll = true,
                Left = 0,
                Top = 0,
                Width = panel1.Width - 5,
                Height = panel1.Height - 150,
            };
            panel1.Controls.Add(panelItems);

            if (keranjang.Count == 0)
            {
                panelItems.Controls.Add(new Label
                {
                    Text = "Keranjang kosong",
                    Top = 10,
                    Left = 10,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    ForeColor = Color.Gray
                });
                return;
            }

            int top = 10;

            foreach (var item in keranjang.ToArray())
            {
                Panel row = new Panel
                {
                    Width = panelItems.Width - 20,
                    Height = 40,
                    Left = 5,
                    Top = top
                };

                Label lblNama = new Label
                {
                    Text = item.produk.NamaProduk,
                    Left = 5,
                    Top = 10,
                    Width = 200
                };
                row.Controls.Add(lblNama);

                TextBox txtJumlah = new TextBox
                {
                    Text = item.jumlah.ToString(),
                    Left = 220,
                    Top = 8,
                    Width = 50,
                    TextAlign = HorizontalAlignment.Center
                };
                txtJumlah.TextChanged += (s, e) =>
                {
                    if (int.TryParse(txtJumlah.Text, out int newQty))
                    {
                        if (newQty <= 0)
                            keranjang.Remove(item);
                        else
                        {
                            var idx = keranjang.FindIndex(x => x.produk.IdProduk == item.produk.IdProduk);
                            keranjang[idx] = (item.produk, newQty);
                        }
                        UpdateRingkasan();
                    }
                };
                row.Controls.Add(txtJumlah);

                Button btnHapus = new Button
                {
                    Text = "X",
                    Width = 35,
                    Height = 25,
                    Left = 280,
                    Top = 7,
                    BackColor = Color.IndianRed,
                    ForeColor = Color.White
                };
                btnHapus.Click += (s, e) =>
                {
                    keranjang.Remove(item);
                    UpdateRingkasan();
                };
                row.Controls.Add(btnHapus);

                panelItems.Controls.Add(row);
                top += 45;
            }

            // TOTAL
            panel1.Controls.Add(new Label
            {
                Text = $"TOTAL = Rp {HitungTotal():N0}",
                Left = 10,
                Top = panel1.Height - 135,
                Width = 400,
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.DarkGreen
            });

            // Batal
            Button btnBatal = new Button
            {
                Text = "Batal",
                Width = 120,
                Height = 40,
                Left = 10,
                Top = panel1.Height - 90,
                BackColor = Color.IndianRed,
                ForeColor = Color.White
            };
            btnBatal.Click += (s, e) =>
            {
                if (MessageBox.Show("Batalkan semua pesanan?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    keranjang.Clear();
                    UpdateRingkasan();
                }
            };
            panel1.Controls.Add(btnBatal);
        }

        private int HitungTotal()
        {
            return keranjang.Sum(x => x.produk.HargaSatuan * x.jumlah);
        }

        // ===============================================================
        // BUTTON BAYAR
        // ===============================================================
        private void btnbayar_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            v_pembayaran bayar = new v_pembayaran(keranjang);
            bayar.Show();
            this.Close();
        }

        // ===============================================================
        // NAVIGASI LAIN
        // ===============================================================
        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new v_login().Show();
                this.Close();
            }
        }

        private void btnprofilcustomer_Click(object sender, EventArgs e)
        {
            new v_profilcustomer().Show();
            this.Close();
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

        private void panelflow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
