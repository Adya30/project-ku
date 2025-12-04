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
    public partial class v_pesananadmin : Form
    {
        private readonly c_pesanan ctrl;

        public v_pesananadmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ctrl = new c_pesanan();
            LoadPesanan();

            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void LoadPesanan()
        {
            var list = ctrl.GetSemuaPesananAdmin();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tanggal");
            dt.Columns.Add("Customer");
            dt.Columns.Add("Produk");
            dt.Columns.Add("Jumlah");
            dt.Columns.Add("Status");
            dt.Columns.Add("Pembayaran");
            dt.Columns.Add("Alamat");
            dt.Columns.Add("Harga Satuan");
            dt.Columns.Add("Subtotal");

            foreach (var item in list)
            {
                int subtotal = item.detail.jumlah_transaksi * item.detail.HargaSatuan;

                dt.Rows.Add(
                    item.transaksi.id_transaksi,
                    item.transaksi.tanggal_transaksi.ToString("dd/MM/yyyy"),
                    item.user.NamaLengkap,
                    item.produk.NamaProduk,
                    item.detail.jumlah_transaksi,
                    item.transaksi.status_transaksi,
                    item.transaksi.pembayaran,
                    item.transaksi.alamat,
                    item.detail.HargaSatuan,
                    subtotal
                );
            }

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = false;
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
                dataGridView1.Columns.Remove("Status");

            DataGridViewComboBoxColumn comboStatus = new DataGridViewComboBoxColumn();
            comboStatus.Name = "Status";
            comboStatus.HeaderText = "Status";
            comboStatus.DataPropertyName = "Status";
            comboStatus.Items.AddRange("Diproses", "Dikirim", "Selesai", "Dibatalkan");
            dataGridView1.Columns.Add(comboStatus);

            if (dataGridView1.Columns.Contains("Simpan"))
                dataGridView1.Columns.Remove("Simpan");

            DataGridViewButtonColumn btnSave = new DataGridViewButtonColumn();
            btnSave.Name = "Simpan";
            btnSave.HeaderText = "Aksi";
            btnSave.Text = "Simpan";
            btnSave.UseColumnTextForButtonValue = true;
            btnSave.Width = 80;
            dataGridView1.Columns.Add(btnSave);

            btnSave.DisplayIndex = dataGridView1.Columns.Count - 1;
            comboStatus.DisplayIndex = btnSave.DisplayIndex - 1;

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;


        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns.Contains("Status") && dataGridView1.Columns.Contains("Simpan"))
            {
                // ComboStatus sebelum tombol
                dataGridView1.Columns["Status"].DisplayIndex = dataGridView1.Columns.Count - 2;
                dataGridView1.Columns["Simpan"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Simpan")
            {
                int idTransaksi = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["ID"].Value
                );

                string statusBaru = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                bool ok = ctrl.UpdateStatusPesanan(idTransaksi, statusBaru);

                if (ok)
                {
                    MessageBox.Show("Status berhasil diperbarui!");
                    LoadPesanan();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui status.");
                }
            }
        }

        private void btnkatalaogadmin_Click(object sender, EventArgs e)
        {
            new v_katalogadmin().Show();
            this.Close();
        }

        private void btnriwayatadmin_Click(object sender, EventArgs e)
        {
            new v_riwayatadmin().Show();
            this.Close();
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
    }
}