using System.Data;
using TaniGrow2.Controller;

namespace TaniGrow2.View
{
    public partial class v_riwayatadmin : Form
    {
        private readonly c_pesanan control;

        public v_riwayatadmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            control = new c_pesanan();
        }

        private void LoadDataGrid<T>(List<T> list, string tipe)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            if (tipe == "pesanan")
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Tanggal");
                dt.Columns.Add("Customer");
                dt.Columns.Add("Produk");
                dt.Columns.Add("Jumlah");
                dt.Columns.Add("Pembayaran");
                dt.Columns.Add("Alamat");
                dt.Columns.Add("Harga Satuan");
                dt.Columns.Add("Subtotal");
                dt.Columns.Add("Status");

                foreach (var item in list.Cast<dynamic>())
                {
                    if (item.transaksi.status_transaksi != "Selesai")
                        continue;

                    int subtotal = item.detail.jumlah_transaksi * item.detail.HargaSatuan;

                    dt.Rows.Add(
                        item.transaksi.id_transaksi,
                        item.transaksi.tanggal_transaksi.ToString("dd/MM/yyyy"),
                        item.user.NamaLengkap,
                        item.produk.NamaProduk,
                        item.detail.jumlah_transaksi,
                        item.transaksi.pembayaran,
                        item.transaksi.alamat,
                        item.detail.HargaSatuan,
                        subtotal,
                        item.transaksi.status_transaksi
                    );
                }
            }
            else if (tipe == "stokmasuk")
            {
                dt.Columns.Add("ID Riwayat", typeof(int));
                dt.Columns.Add("Tanggal Masuk");
                dt.Columns.Add("Produk");
                dt.Columns.Add("Jumlah", typeof(int));
                dt.Columns.Add("Admin");

                foreach (var item in list.Cast<dynamic>())
                {
                    dt.Rows.Add(
                        item.IdStokMasuk,
                        item.TanggalMasuk.ToString("dd/MM/yyyy HH:mm"),
                        item.Produk?.NamaProduk,
                        item.Jumlah,
                        item.User?.NamaLengkap
                    );
                }
            }

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

        }



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

        private void btncustomer_Click(object sender, EventArgs e)
        {
            var list = control.GetSemuaPesananAdmin();
            LoadDataGrid(list, "pesanan");
        }

        private void btnbarang_Click(object sender, EventArgs e)
        {
            
            var list = control.GetRiwayatStokMasuk();
            LoadDataGrid(list, "stokmasuk");
        }

    }
}
