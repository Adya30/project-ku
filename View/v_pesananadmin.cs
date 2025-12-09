using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TaniGrow2.Controller;
using TaniGrow2.Model;

namespace TaniGrow2.View
{
    public partial class v_pesananadmin : Form
    {
        private readonly c_pesanan ctrl;
        private readonly string[] AllowedStatuses = new[] { "Diproses", "Dikirim", "Selesai", "Dibatalkan" };

        public v_pesananadmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ctrl = new c_pesanan();

            dataGridView1.DataError += DataGridView1_DataError;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;

            LoadPesanan();
        }

        // --------------------- HANDLER ERROR COMBOBOX ----------------------
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Jika error di kolom StatusEdit, set default agar tidak melempar dialog
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "StatusEdit")
            {
                try
                {
                    if (e.RowIndex >= 0 && dataGridView1.Rows.Count > e.RowIndex)
                        dataGridView1.Rows[e.RowIndex].Cells["StatusEdit"].Value = "Diproses";
                }
                catch { }
            }

            // jangan munculkan exception dialog
            e.ThrowException = false;
        }

        // -------------------------- LOAD DATA PESANAN --------------------------
        private void LoadPesanan()
        {
            var list = ctrl.GetSemuaPesananAdmin();

            // DATA TABLE
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tanggal", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Produk", typeof(string));
            dt.Columns.Add("Jumlah", typeof(int));
            dt.Columns.Add("Alamat", typeof(string));
            dt.Columns.Add("HargaSatuan", typeof(int));
            dt.Columns.Add("Subtotal", typeof(int));
            // simpan raw bytes di kolom terpisah (agar tidak bentrok dengan image column)
            dt.Columns.Add("BuktiPembayaranData", typeof(byte[]));
            dt.Columns.Add("Status", typeof(string));

            // ------------------ LOOP DATA PESANAN -------------------
            foreach (var item in list)
            {
                // normalisasi status
                string statusNormalized = NormalizeStatus(item.transaksi?.status_transaksi);

                if (statusNormalized == "Selesai")
                    continue;

                
                int hargaSatuan = item.produk.HargaSatuan;

                int jumlah = item.detail?.jumlah_transaksi ?? 0;
                int subtotal = jumlah * hargaSatuan;

                dt.Rows.Add(
                    item.transaksi?.id_transaksi ?? 0,
                    item.transaksi?.tanggal_transaksi.ToString("dd/MM/yyyy") ?? "",
                    item.user?.NamaLengkap ?? "",
                    item.produk?.NamaProduk ?? "",
                    jumlah,
                    item.transaksi?.alamat ?? "",
                    hargaSatuan,
                    subtotal,
                    item.transaksi?.bukti_pembayaran,
                    statusNormalized
                );
            }


            // ====== ASSIGN DATATABLE ======
            dataGridView1.DataSource = dt;

            // ------------------ TAMBAHKAN KOLOM GAMBAR (BuktiGambar) ------------------
            if (dataGridView1.Columns.Contains("BuktiGambar"))
                dataGridView1.Columns.Remove("BuktiGambar");

            // buat kolom gambar
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn
            {
                Name = "BuktiGambar",
                HeaderText = "Bukti",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 120
            };

            // letakkan SETELAH BuktiPembayaranData
            int insertIndex = dataGridView1.Columns["BuktiPembayaranData"].Index + 1;
            dataGridView1.Columns.Insert(insertIndex, imgCol);

            // ISI GAMBAR
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var raw = row.Cells["BuktiPembayaranData"].Value;

                if (raw is byte[] imgBytes && imgBytes.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(imgBytes))
                        {
                            row.Cells["BuktiGambar"].Value = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        row.Cells["BuktiGambar"].Value = null;
                    }
                }
                else
                {
                    row.Cells["BuktiGambar"].Value = null;
                }
            }


            // ----------------------- STYLE DATAGRID ------------------------
            if (dataGridView1.Columns.Contains("ID"))
                dataGridView1.Columns["ID"].Visible = false;

            // sembunyikan kolom raw byte agar tidak terlihat
            if (dataGridView1.Columns.Contains("BuktiPembayaranData"))
                dataGridView1.Columns["BuktiPembayaranData"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 120;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

            // ------------------------ KOLOM COMBO STATUS ------------------------
            // jangan hapus kolom sumber (Status), kita buat ComboBox yang terhubung ke nilai ini
            if (dataGridView1.Columns.Contains("StatusEdit"))
                dataGridView1.Columns.Remove("StatusEdit");

            DataGridViewComboBoxColumn comboStatus = new DataGridViewComboBoxColumn
            {
                Name = "StatusEdit",
                HeaderText = "Status",
                DataPropertyName = "Status", // sumber dari DataTable kolom "Status"
                ValueType = typeof(string)
            };
            comboStatus.Items.AddRange(AllowedStatuses);
            dataGridView1.Columns.Add(comboStatus);

            // Setelah menambahkan kolom combo, set value setiap baris ke nilai Status yang ada
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (dataGridView1.Columns.Contains("Status") && dataGridView1.Columns.Contains("StatusEdit"))
                {
                    var val = row.Cells["Status"].Value;
                    if (val != null)
                    {
                        // jika value cocok dengan allowed, langsung set; kalau tidak, normalisasi
                        string s = val.ToString();
                        if (!AllowedStatuses.Contains(s))
                            s = NormalizeStatus(s);

                        row.Cells["StatusEdit"].Value = s;
                    }
                    else
                    {
                        row.Cells["StatusEdit"].Value = "Diproses";
                    }
                }
            }

            // ------------------------ KOLOM BUTTON SIMPAN ------------------------
            if (dataGridView1.Columns.Contains("Simpan"))
                dataGridView1.Columns.Remove("Simpan");

            DataGridViewButtonColumn btnSave = new DataGridViewButtonColumn
            {
                Name = "Simpan",
                HeaderText = "Aksi",
                Text = "Simpan",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(btnSave);

            // tempatkan combo & tombol di paling kanan
            comboStatus.DisplayIndex = dataGridView1.Columns.Count - 2;
            btnSave.DisplayIndex = dataGridView1.Columns.Count - 1;

            dataGridView1.CellClick -= DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        // --------------------------- AFTER BINDING ---------------------------
        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns.Contains("StatusEdit") &&
                dataGridView1.Columns.Contains("Simpan"))
            {
                dataGridView1.Columns["StatusEdit"].DisplayIndex = dataGridView1.Columns.Count - 2;
                dataGridView1.Columns["Simpan"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }

        // --------------------------- EVENT CLICK SAVE ---------------------------
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Simpan")
            {
                try
                {
                    int idTransaksi = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                    var statusCell = dataGridView1.Rows[e.RowIndex].Cells["StatusEdit"].Value;
                    if (statusCell == null)
                    {
                        MessageBox.Show("Pilih status terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string statusBaru = statusCell.ToString();
                    if (!AllowedStatuses.Contains(statusBaru))
                        statusBaru = NormalizeStatus(statusBaru);

                    bool ok = ctrl.UpdateStatusPesanan(idTransaksi, statusBaru);

                    if (ok)
                    {
                        MessageBox.Show("Status berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPesanan();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --------------------------- NORMALISASI STATUS ---------------------------
        private string NormalizeStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                return "Diproses";

            string s = status.Trim().ToLower();

            return s switch
            {
                "diproses" => "Diproses",
                "proses" => "Diproses",
                "pending" => "Diproses",
                "menunggu" => "Diproses",

                "dikirim" => "Dikirim",
                "shipped" => "Dikirim",

                "selesai" => "Selesai",
                "done" => "Selesai",

                "dibatalkan" => "Dibatalkan",
                "batal" => "Dibatalkan",
                "cancel" => "Dibatalkan",

                _ => "Diproses",
            };
        }

        // --------------------------- NAVIGASI FORM ---------------------------
        private void btnkatalaogadmin_Click(object sender, EventArgs e)
        {
            new v_katalogcustomer().Show();
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
            if (MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new v_login().Show();
                this.Close();
            }
        }
    }
}
