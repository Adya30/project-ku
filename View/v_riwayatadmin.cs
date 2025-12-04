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
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            var list = control.GetSemuaPesananAdmin();
            DataTable dt = new DataTable();
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

            foreach (var item in list)
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

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 248, 198);
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            if (dataGridView1.Columns.Contains("Status"))
                dataGridView1.Columns["Status"].DisplayIndex = dataGridView1.Columns.Count - 1;

            dataGridView1.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        }

        //private void btnsupplier_Click(object sender, EventArgs e)
        //{
        //    new v_riwayatsupplier().Show();
        //    this.Close();
        //}
    }
}
