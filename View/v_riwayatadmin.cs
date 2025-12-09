using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TaniGrow2.Controller;
using TaniGrow2.Model;

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

        private void LoadDataGridPesanan(List<(m_transaksi, m_detailtransaksi, m_produk, User)> list)
        {
            DataTable dt = new DataTable();

            // Reset DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tanggal");
            dt.Columns.Add("Customer");
            dt.Columns.Add("Produk");
            dt.Columns.Add("Jumlah", typeof(int));
            dt.Columns.Add("Alamat");
            dt.Columns.Add("Harga Satuan", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));
            dt.Columns.Add("Status");

            foreach (var item in list)
            {
                var transaksi = item.Item1;
                var detail = item.Item2;
                var produk = item.Item3;
                var user = item.Item4;

                if (transaksi == null || detail == null || produk == null || user == null)
                    continue;

                if (transaksi.status_transaksi != "Selesai")
                    continue;

                decimal subtotal = Convert.ToDecimal(detail.jumlah_transaksi) * Convert.ToDecimal(produk.HargaSatuan);

                dt.Rows.Add(
                    transaksi.id_transaksi,
                    transaksi.tanggal_transaksi != null ? transaksi.tanggal_transaksi.ToString("dd/MM/yyyy") : "-",
                    user.NamaLengkap ?? "-",
                    produk.NamaProduk ?? "-",
                    detail.jumlah_transaksi,
                    transaksi.alamat ?? "-",
                    produk.HargaSatuan,
                    subtotal,
                    transaksi.status_transaksi
                );
            }

            dataGridView1.DataSource = dt;

            // Styling DataGridView
            if (dataGridView1.Columns.Contains("ID"))
                dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 248, 198);

            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            if (dataGridView1.Columns.Contains("Status"))
            {
                dataGridView1.Columns["Status"].DisplayIndex = dataGridView1.Columns.Count - 1;
                dataGridView1.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void LoadDataGridStokMasuk<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dt.Columns.Add("ID Riwayat", typeof(int));
            dt.Columns.Add("Tanggal Masuk");
            dt.Columns.Add("Produk");
            dt.Columns.Add("Jumlah", typeof(int));
            dt.Columns.Add("Admin");

            foreach (var itemObj in list)
            {
                dynamic item = itemObj;
                if (item == null) continue;

                dt.Rows.Add(
                    item.IdStokMasuk,
                    item.TanggalMasuk != null ? item.TanggalMasuk.ToString("dd/MM/yyyy HH:mm") : "-",
                    item.Produk?.NamaProduk ?? "-",
                    item.Jumlah,
                    item.User?.NamaLengkap ?? "-"
                );
            }

            dataGridView1.DataSource = dt;

            // Styling
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 248, 198);
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil list tuple
                var list = control.GetSemuaPesananAdmin();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Tanggal");
                dt.Columns.Add("Customer");
                dt.Columns.Add("Produk");
                dt.Columns.Add("Jumlah", typeof(int));
                dt.Columns.Add("Alamat");
                dt.Columns.Add("Harga Satuan", typeof(decimal));
                dt.Columns.Add("Subtotal", typeof(decimal));
                dt.Columns.Add("Status");

                foreach (var item in list)
                {
                    var transaksi = item.Item1;
                    var detail = item.Item2;
                    var produk = item.Item3;
                    var user = item.Item4;

                    if (transaksi.status_transaksi != "Selesai")
                        continue;

                    decimal subtotal = Convert.ToDecimal(detail.jumlah_transaksi) * Convert.ToDecimal(produk.HargaSatuan);

                    dt.Rows.Add(
                        transaksi.id_transaksi,
                        transaksi.tanggal_transaksi.ToString("dd/MM/yyyy") ?? "-",
                        user.NamaLengkap ?? "-",
                        produk.NamaProduk ?? "-",
                        detail.jumlah_transaksi,
                        transaksi.alamat ?? "-",
                        produk.HargaSatuan,
                        subtotal,
                        transaksi.status_transaksi
                    );
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data pesanan: " + ex.Message);
            }
        }


        private void btnbarang_Click(object sender, EventArgs e)
        {
            try
            {
                var list = control.GetRiwayatStokMasuk();
                LoadDataGridStokMasuk(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data stok masuk: " + ex.Message);
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

        private void btnriwayatadmin_Click(object sender, EventArgs e) { }

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
    }
}

