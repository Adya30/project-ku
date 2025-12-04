using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<(m_transaksi transaksi, m_detailtransaksi detail, m_produk produk)>
        GetPesananBelumSelesaiByUser(int userId)
        {
            var list = new List<(m_transaksi, m_detailtransaksi, m_produk)>();

            using (var conn = db.getConn())
            {
                conn.Open();

                string query = @"
                SELECT 
                    t.id_transaksi, t.tanggal_transaksi, t.status_transaksi, t.pembayaran, t.alamat,
                    d.id_detailtransaksi, d.jumlah, d.id_produk,
                    p.id_produk, p.nama_produk, p.deskripsi, p.harga_satuan,
                    k.nama_kategori
                FROM transaksi t
                LEFT JOIN detail_transaksi d ON t.id_transaksi = d.id_transaksi
                LEFT JOIN produk p ON d.id_produk = p.id_produk
                LEFT JOIN kategori k ON p.id_kategoriproduk = k.id_kategoriProduk
                WHERE t.id_user = @uid
                  AND t.status_transaksi != 'Selesai'
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
                                pembayaran = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                alamat = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                id_user = userId
                            };

                            var produk = new m_produk
                            {
                                IdProduk = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                                NamaProduk = reader.IsDBNull(9) ? "" : reader.GetString(9),
                                Deskripsi = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                HargaSatuan = reader.IsDBNull(11) ? 0 : reader.GetInt32(11), // pastikan ini benar
                                NamaKategori = reader.IsDBNull(12) ? "" : reader.GetString(12)
                            };

                            var detail = new m_detailtransaksi
                            {
                                id_detailtransaksi = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                jumlah_transaksi = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                id_transaksi = transaksi.id_transaksi,
                                id_produk = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                                HargaSatuan = produk.HargaSatuan // ambil dari produk
                            };

                            list.Add((transaksi, detail, produk));
                        }
                    }
                }
            }

            return list;
        }

        public List<(m_transaksi transaksi, m_detailtransaksi detail, m_produk produk)>
        GetPesananSelesaiByUser(int userId)
        {
            var list = new List<(m_transaksi, m_detailtransaksi, m_produk)>();

            using (var conn = db.getConn())
            {
                conn.Open();

                string query = @"
            SELECT 
                t.id_transaksi, t.tanggal_transaksi, t.status_transaksi, t.pembayaran, t.alamat,
                d.id_detailtransaksi, d.jumlah, d.id_produk,
                p.id_produk, p.nama_produk, p.deskripsi, p.harga_satuan,
                k.nama_kategori
            FROM transaksi t
            LEFT JOIN detail_transaksi d ON t.id_transaksi = d.id_transaksi
            LEFT JOIN produk p ON d.id_produk = p.id_produk
            LEFT JOIN kategori k ON p.id_kategoriproduk = k.id_kategoriProduk
            WHERE t.id_user = @uid
              AND t.status_transaksi = 'Selesai'
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
                                pembayaran = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                alamat = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                id_user = userId
                            };

                            var produk = new m_produk
                            {
                                IdProduk = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                                NamaProduk = reader.IsDBNull(9) ? "" : reader.GetString(9),
                                Deskripsi = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                HargaSatuan = reader.IsDBNull(11) ? 0 : reader.GetInt32(11),
                                NamaKategori = reader.IsDBNull(12) ? "" : reader.GetString(12)
                            };

                            var detail = new m_detailtransaksi
                            {
                                id_detailtransaksi = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                jumlah_transaksi = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                id_transaksi = transaksi.id_transaksi,
                                id_produk = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                                HargaSatuan = produk.HargaSatuan
                            };

                            list.Add((transaksi, detail, produk));
                        }
                    }
                }
            }

            return list;
        }




        public List<(m_transaksi transaksi, m_detailtransaksi detail, m_produk produk, User user)>
        GetSemuaPesananAdmin()
        {
            var list = new List<(m_transaksi, m_detailtransaksi, m_produk, User)>();

            using (var conn = db.getConn())
            {
                conn.Open();

                string query = @"
                SELECT 
                    t.id_transaksi, t.tanggal_transaksi, t.status_transaksi, 
                    t.pembayaran, t.alamat, t.id_user,

                    d.id_detailtransaksi, d.jumlah, p.harga_satuan, d.id_produk,

                    p.id_produk, p.nama_produk, k.nama_kategori, p.deskripsi,

                    u.id_user, u.nama_lengkap
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
                            pembayaran = reader.GetString(3),
                            alamat = reader.IsDBNull(4) ? "" : reader.GetString(4),
                            id_user = reader.GetInt32(5),
                        };

                        var detail = new m_detailtransaksi
                        {
                            id_detailtransaksi = reader.GetInt32(6),
                            jumlah_transaksi = reader.GetInt32(7),
                            HargaSatuan = reader.GetInt32(8),
                            id_transaksi = transaksi.id_transaksi,
                            id_produk = reader.GetInt32(9)
                        };

                        var produk = new m_produk
                        {
                            IdProduk = reader.GetInt32(10),
                            NamaProduk = reader.GetString(11),
                            NamaKategori = reader.GetString(12),
                            Deskripsi = reader.IsDBNull(13) ? "" : reader.GetString(13)
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

        public bool UpdateStatusPesanan(int idTransaksi, string statusBaru)
        {
            try
            {
                using (var conn = db.getConn())
                {
                    conn.Open();
                    string query = @"
                UPDATE transaksi
                SET status_transaksi = @status
                WHERE id_transaksi = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@id", idTransaksi);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }



    }
}