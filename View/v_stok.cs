using TaniGrow2.Controller;
using TaniGrow2.Model;

namespace TaniGrow2.View
{
    public partial class v_stok : Form
    {
        private readonly c_produk ctrlProduk;
        private int? userId;
        private List<(m_produk produk, int jumlah)> keranjang;

        public v_stok(int? idUser = null)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;

            ctrlProduk = new c_produk();
            userId = idUser;
            keranjang = new List<(m_produk, int)>();

            LoadKatalog();
            UpdateRingkasan();
        }

        public void LoadKatalog()
        {
            flowLayoutPanel1.Controls.Clear();
            var listProduk = ctrlProduk.GetProdukList();

            foreach (var p in listProduk)
            {
                var card = CreateCard(p);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private Panel CreateCard(m_produk produk)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 350,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            PictureBox pic = new PictureBox
            {
                Width = card.Width - 20,
                Height = 150,
                Top = 10,
                Left = 10,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (produk.FotoProduk != null)
            {
                try
                {
                    using (var ms = new MemoryStream(produk.FotoProduk))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                catch { }
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

            Label lblKategori = new Label
            {
                Text = produk.NamaKategori ?? "",
                Top = lblNama.Bottom + 3,
                Left = 10,
                Width = card.Width - 20,
                Font = new Font("Arial", 9, FontStyle.Italic),
                ForeColor = Color.DarkGreen,
                AutoEllipsis = true
            };

            Label lblDeskripsi = new Label
            {
                Text = produk.Deskripsi ?? "",
                Top = lblKategori.Bottom + 5,
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
                Top = card.Height - 55,
                Left = (card.Width - 120) / 2,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };


            btnPesan.Click += (s, e) =>
            {
                var idx = keranjang.FindIndex(x => x.produk.IdProduk == produk.IdProduk);
                if (idx >= 0)
                {
                    var item = keranjang[idx];
                    keranjang[idx] = (item.produk, item.jumlah + 1);
                }
                else
                {
                    keranjang.Add((produk, 1));
                }

                UpdateRingkasan();
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblKategori);
            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(btnPesan);

            return card;
        }

        private void UpdateRingkasan()
        {
            panel1.Controls.Clear();

            if (keranjang.Count == 0)
            {
                Label lblKosong = new Label
                {
                    Text = "Keranjang kosong",
                    Top = 10,
                    Left = 10,
                    Width = 300,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(lblKosong);
                return;
            }

            int top = 10;

            foreach (var item in keranjang.ToArray())
            {
                Panel row = new Panel
                {
                    Width = panel1.Width - 20,
                    Height = 40,
                    Left = 5,
                    Top = top
                };

                // Nama Produk
                Label lblNama = new Label
                {
                    Text = item.produk.NamaProduk,
                    Left = 5,
                    Top = 10,
                    Width = 200,
                    Font = new Font("Arial", 9)
                };
                row.Controls.Add(lblNama);

                // TextBox jumlah
                TextBox txtJumlah = new TextBox
                {
                    Text = item.jumlah.ToString(),
                    Left = 220,
                    Top = 8,
                    Width = 50,
                    TextAlign = HorizontalAlignment.Center
                };

                // Update jumlah saat berubah
                txtJumlah.TextChanged += (s, e) =>
                {
                    if (int.TryParse(txtJumlah.Text, out int newQty))
                    {
                        if (newQty <= 0)
                        {
                            keranjang.Remove(item);
                        }
                        else
                        {
                            var idx = keranjang.FindIndex(x => x.produk.IdProduk == item.produk.IdProduk);
                            keranjang[idx] = (item.produk, newQty);
                        }
                    }
                };
                row.Controls.Add(txtJumlah);

                // Tombol hapus
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

                panel1.Controls.Add(row);
                top += 45;
            }

            // Tombol Batal
            Button btnBatal = new Button
            {
                Text = "Batal",
                Width = 120,
                Height = 40,
                Left = 10,
                Top = top + 10,
                BackColor = Color.IndianRed,
                ForeColor = Color.White
            };

            btnBatal.Click += (s, e) =>
            {
                if (MessageBox.Show("Batalkan semua pesanan?", "Konfirmasi",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    keranjang.Clear();
                    UpdateRingkasan();
                }
            };

            panel1.Controls.Add(btnBatal);
        }

        private void btnrestock_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Tidak ada stok yang ditambahkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var item in keranjang)
            {
                // 1. Tambah stok
                int stokBaru = item.produk.StokProduk + item.jumlah;
                ctrlProduk.UpdateStok(item.produk.IdProduk, stokBaru);

                // 2. Catat ke tabel stok_masuk
                var dataSupply = new m_stokMasuk
                {
                    IdProduk = item.produk.IdProduk,
                    Jumlah = item.jumlah,
                    TanggalMasuk = DateTime.Now,
                    //IdUser = u
                };
                ctrlProduk.CatatSupply(dataSupply);
            }

            MessageBox.Show("Stok berhasil ditambahkan dan dicatat.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            keranjang.Clear();
            LoadKatalog();
            UpdateRingkasan();
        }


        private void btnkembali_Click(object sender, EventArgs e)
        {
            new v_katalogadmin().Show();
            this.Close();
        }

        private void v_stok_Load(object sender, EventArgs e)
        {

        }
    }
}