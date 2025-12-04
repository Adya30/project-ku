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

namespace TaniGrow2.View
{
    public partial class v_katalogadmin : Form
    {
        private c_produk ctrlProduk;

        public v_katalogadmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            flowpanel.AutoScroll = true;
            flowpanel.WrapContents = true;
            flowpanel.FlowDirection = FlowDirection.LeftToRight;


            ctrlProduk = new c_produk();
            LoadKatalog();
        }

        public void LoadKatalog()
        {
            flowpanel.Controls.Clear();

            var listProduk = ctrlProduk.GetProdukList();

            foreach (var p in listProduk)
            {
                var card = CreateCard(p);
                flowpanel.Controls.Add(card);
            }
        }

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
                Font = new Font("Arial", 11, FontStyle.Bold),
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

            Label lblStok = new Label
            {
                Text = "Stok: " + produk.StokProduk,
                Top = lblKategori.Bottom + 3,
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

            card.Controls.Add(lblDeskripsi);

            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblKategori);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHarga);

            Button btnEdit = new Button
            {
                Text = "Edit",
                Width = 110,
                Height = 35,
                Top = card.Height - 60,
                Left = 10,
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnEdit.Click += (s, e) =>
            {
                var editForm = new v_tambahkatalog(this, produk);
                editForm.Show();
                this.Hide();
            };

            //Button btnHardDelete = new Button
            //{
            //    Text = "Hapus",
            //    Width = 110,
            //    Height = 35,
            //    Top = card.Height - 70,
            //    Left = 135,
            //    BackColor = Color.IndianRed,
            //    ForeColor = Color.White,
            //    FlatStyle = FlatStyle.Flat
            //};
            //btnHardDelete.Click += (s, e) =>
            //{
            //    var confirm = MessageBox.Show(
            //        $"Apakah Anda yakin ingin menghapus produk '{produk.NamaProduk}'?",
            //        "Konfirmasi Hapus",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning
            //    );

            //    if (confirm == DialogResult.Yes)
            //    {
            //        if (ctrlProduk.HapusProduk(produk.IdProduk))
            //        {
            //            MessageBox.Show("Produk berhasil dihapus (stok diset 0).", "Sukses");
            //            LoadKatalog();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Gagal menghapus produk.", "Error");
            //        }
            //    }
            //};


            card.Controls.Add(btnEdit);
            //card.Controls.Add(btnHardDelete);

            return card;
        }

        private void btntambahkatalog_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda ingin menambahkan produk baru?", "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                var tambahForm = new v_tambahkatalog(this);
                tambahForm.Show();
                this.Hide();
            }
        }

        private void btnkatalogadmin_Click(object sender, EventArgs e)
        {

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
            btnstok.BringToFront();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            new v_stok().Show();
            this.Hide();
        }

        //private void supplier_Click(object sender, EventArgs e)
        //{
        //    new v_supplier().Show();
        //    this.Close();
        //}
    }
}
