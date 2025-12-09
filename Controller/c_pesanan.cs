using Npgsql;
using TaniGrow2.dbconnect;
using TaniGrow2.Model;

namespace TaniGrow2.Controller
{
    public class c_pesanan
    {
        private readonly connectdata db;

        public c_pesanan()
        {
            db = new connectdata();
        }

        // =======================================================
        // 1. USER — GET PESANAN BELUM SELESAI
        // =======================================================
        public List<(m_transaksi transaksi, m_detailtransaksi detail, m_produk produk)>
        GetPesananBelumSelesaiByUser(int userId)
        {
            var list = new List<(m_transaksi, m_detailtransaksi, m_produk)>();

            using (var conn = db.getConn())
            {
                conn.Open();

                string query = @"
                SELECT 
                    t.id_transaksi,          -- 0
                    t.tanggal_transaksi,     -- 1
                    t.status_transaksi,      -- 2
                    t.alamat,                -- 3
                    t.id_user,               -- 4
                    t.bukti_pembayaran,      -- 5

                    d.id_detailtransaksi,    -- 6
                    d.jumlah,                -- 7
                    d.id_produk,             -- 8

                    p.id_produk,             -- 9
                    p.nama_produk,           -- 10
                    p.deskripsi,             -- 11
                    p.harga_satuan,          -- 12

                    k.nama_kategori          -- 13
                FROM transaksi t
                LEFT JOIN detail_transaksi d ON t.id_transaksi = d.id_transaksi
                LEFT JOIN produk p ON d.id_produk = p.id_produk
                LEFT JOIN kategori k ON p.id_kategoriproduk = k.id_kategoriProduk
                WHERE t.id_user = @uid AND t.status_transaksi != 'Selesai'
                ORDER BY t.tanggal_transaksi DESC;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transaksi = new m_transaksi
                            {
                                id_transaksi = reader.GetInt32(0),
                                tanggal_transaksi = reader.GetDateTime(1),
                                status_transaksi = reader.GetString(2),
                                alamat = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                id_user = reader.GetInt32(4),
                                bukti_pembayaran = reader.IsDBNull(5) ? null : (byte[])reader[5]
                            };

                            var detail = new m_detailtransaksi
                            {
                                id_detailtransaksi = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                jumlah_transaksi = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                                id_produk = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                                id_transaksi = transaksi.id_transaksi
                            };

                            var produk = new m_produk
                            {
                                IdProduk = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                                NamaProduk = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                Deskripsi = reader.IsDBNull(11) ? "" : reader.GetString(11),
                                HargaSatuan = reader.IsDBNull(12) ? 0 : reader.GetInt32(12),
                                NamaKategori = reader.IsDBNull(13) ? "" : reader.GetString(13)
                            };

                            list.Add((transaksi, detail, produk));
                        }
                    }
                }
            }

            return list;
        }

        // =======================================================
        // 2. USER — GET PESANAN SELESAI
        // =======================================================
        public List<(m_transaksi transaksi, m_detailtransaksi detail, m_produk produk)>
        GetPesananSelesaiByUser(int userId)
        {
            var list = new List<(m_transaksi, m_detailtransaksi, m_produk)>();

            using (var conn = db.getConn())
            {
                conn.Open();

                string query = @"
                SELECT 
                    t.id_transaksi,          -- 0
                    t.tanggal_transaksi,     -- 1
                    t.status_transaksi,      -- 2
                    t.alamat,                -- 3
                    t.id_user,               -- 4
                    t.bukti_pembayaran,      -- 5

                    d.id_detailtransaksi,    -- 6
                    d.jumlah,                -- 7
                    d.id_produk,             -- 8

                    p.id_produk,             -- 9
                    p.nama_produk,           -- 10
                    p.deskripsi,             -- 11
                    p.harga_satuan,          -- 12

                    k.nama_kategori          -- 13
                FROM transaksi t
                LEFT JOIN detail_transaksi d ON t.id_transaksi = d.id_transaksi
                LEFT JOIN produk p ON d.id_produk = p.id_produk
                LEFT JOIN kategori k ON p.id_kategoriproduk = k.id_kategoriProduk
                WHERE t.id_user = @uid AND t.status_transaksi = 'Selesai'
                ORDER BY t.tanggal_transaksi DESC;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transaksi = new m_transaksi
                            {
                                id_transaksi = reader.GetInt32(0),
                                tanggal_transaksi = reader.GetDateTime(1),
                                status_transaksi = reader.GetString(2),
                                alamat = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                id_user = reader.GetInt32(4),
                                bukti_pembayaran = reader.IsDBNull(5) ? null : (byte[])reader[5]
                            };

                            var detail = new m_detailtransaksi
                            {
                                id_detailtransaksi = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                jumlah_transaksi = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                                id_produk = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                                id_transaksi = transaksi.id_transaksi
                            };

                            var produk = new m_produk
                            {
                                IdProduk = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                                NamaProduk = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                Deskripsi = reader.IsDBNull(11) ? "" : reader.GetString(11),
                                HargaSatuan = reader.IsDBNull(12) ? 0 : reader.GetInt32(12),
                                NamaKategori = reader.IsDBNull(13) ? "" : reader.GetString(13)
                            };

                            list.Add((transaksi, detail, produk));
                        }
                    }
                }
            }

            return list;
        }

        // =======================================================
        // 3. ADMIN — GET SEMUA PESANAN
        // =======================================================
        public List<(m_transaksi transaksi, m_detailtransaksi detail, m_produk produk, User user)>
        GetSemuaPesananAdmin()
        {
            var list = new List<(m_transaksi, m_detailtransaksi, m_produk, User)>();

            using (var conn = db.getConn())
            {
                conn.Open();

                string query = @"
        SELECT 
            t.id_transaksi,          -- 0
            t.tanggal_transaksi,     -- 1
            t.status_transaksi,      -- 2
            t.alamat,                -- 3
            t.id_user,               -- 4
            t.bukti_pembayaran,      -- 5

            d.id_detailtransaksi,    -- 6
            d.jumlah,                -- 7
            d.id_produk,             -- 8

            p.id_produk,             -- 9
            p.nama_produk,           -- 10
            p.deskripsi,             -- 11
            p.harga_satuan,          -- 12
            k.nama_kategori,         -- 13

            u.id_user,               -- 14
            u.nama_lengkap           -- 15
        FROM transaksi t
        INNER JOIN detail_transaksi d ON t.id_transaksi = d.id_transaksi
        INNER JOIN produk p ON d.id_produk = p.id_produk
        INNER JOIN kategori k ON p.id_kategoriproduk = k.id_kategoriproduk
        INNER JOIN users u ON t.id_user = u.id_user
        ORDER BY u.nama_lengkap ASC, t.tanggal_transaksi DESC;
        ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var transaksi = new m_transaksi
                        {
                            id_transaksi = reader.GetInt32(0),
                            tanggal_transaksi = reader.GetDateTime(1),
                            status_transaksi = reader.GetString(2),
                            alamat = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            id_user = reader.GetInt32(4),
                            bukti_pembayaran = reader.IsDBNull(5) ? null : (byte[])reader[5]
                        };

                        var detail = new m_detailtransaksi
                        {
                            id_detailtransaksi = reader.GetInt32(6),
                            jumlah_transaksi = reader.GetInt32(7),
                            id_produk = reader.GetInt32(8),
                            id_transaksi = transaksi.id_transaksi
                        };

                        var produk = new m_produk
                        {
                            IdProduk = reader.GetInt32(9),
                            NamaProduk = reader.GetString(10),
                            Deskripsi = reader.IsDBNull(11) ? "" : reader.GetString(11),
                            HargaSatuan = reader.GetInt32(12),
                            NamaKategori = reader.GetString(13)
                        };

                        var user = new User
                        {
                            IdUser = reader.GetInt32(14),
                            NamaLengkap = reader.GetString(15)
                        };

                        list.Add((transaksi, detail, produk, user));
                    }
                }
            }

            return list;
        }


        // =======================================================
        // 4. UPDATE STATUS TRANSAKSI
        // =======================================================
        public bool UpdateStatusPesanan(int idTransaksi, string statusBaru)
        {
            using var conn = db.getConn();
            conn.Open();

            string query = @"UPDATE transaksi SET status_transaksi = @status WHERE id_transaksi = @id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", statusBaru);
            cmd.Parameters.AddWithValue("@id", idTransaksi);

            return cmd.ExecuteNonQuery() > 0;
        }
    

        public List<m_stokMasuk> GetRiwayatStokMasuk()
        {
            List<m_stokMasuk> list = new List<m_stokMasuk>();


            using var conn = db.getConn();
            conn.Open();

            string query = @"
        SELECT s.id_stok_masuk, s.jumlah, s.tanggal_masuk,
               p.id_produk, p.nama_produk,
               u.id_user, u.nama_lengkap
        FROM stok_masuk s
        LEFT JOIN produk p ON p.id_produk = s.id_produk
        LEFT JOIN users u ON u.id_user = s.id_user
        ORDER BY s.tanggal_masuk DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new m_stokMasuk
                {
                    IdStokMasuk = reader.GetInt32(0),
                    Jumlah = reader.GetInt32(1),
                    TanggalMasuk = reader.GetDateTime(2),

                    Produk = new m_produk
                    {
                        IdProduk = reader.GetInt32(3),
                        NamaProduk = reader.GetString(4)
                    },

                    User = new User
                    {
                        IdUser = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        NamaLengkap = reader.IsDBNull(6) ? "-" : reader.GetString(6)
                    }
                });
            }
            MessageBox.Show("Jumlah stok: " + list.Count);
            return list;


        }
    }
}