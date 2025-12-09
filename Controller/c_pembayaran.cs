using Npgsql;
using TaniGrow2.dbconnect;
using TaniGrow2.Model;

namespace TaniGrow2.Controller
{
    public interface ITransaksiService
    {
        bool ProsesPembayaran(
            int idUser,
            List<(m_produk produk, int jumlah)> keranjang,
            string alamat,
            byte[] buktiPembayaran);
    }

    public class c_Pembayaran : ITransaksiService
    {
        private readonly connectdata db;

        public c_Pembayaran()
        {
            db = new connectdata();
        }

        private bool SimpanTransaksi(m_transaksi transaksi, List<m_detailtransaksi> listDetail)
        {
            using (var conn = new NpgsqlConnection(db.connstring))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // INSERT TRANSAKSI
                        string queryTransaksi = @"
                INSERT INTO transaksi 
                (tanggal_transaksi, status_transaksi, alamat, id_user, bukti_pembayaran) 
                VALUES (@tgl, @status, @alamat, @id_user, @bukti)
                RETURNING id_transaksi";

                        int idTransaksi;
                        using (var cmd = new NpgsqlCommand(queryTransaksi, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@tgl", transaksi.tanggal_transaksi);
                            cmd.Parameters.AddWithValue("@status", transaksi.status_transaksi ?? "");
                            cmd.Parameters.AddWithValue("@alamat", transaksi.alamat ?? "");
                            cmd.Parameters.AddWithValue("@id_user", transaksi.id_user);
                            cmd.Parameters.AddWithValue("@bukti", (object)transaksi.bukti_pembayaran ?? DBNull.Value);

                            idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // INSERT DETAIL + UPDATE STOK
                        string queryDetail = @"
                INSERT INTO detail_transaksi
                (jumlah, id_transaksi, id_produk)
                VALUES (@jumlah, @id_transaksi, @id_produk)";

                        string queryUpdateStok = @"
                UPDATE produk
                SET stok_produk = stok_produk - @jumlah
                WHERE id_produk = @id_produk";

                        foreach (var item in listDetail)
                        {
                            // INSERT DETAIL
                            using (var cmd = new NpgsqlCommand(queryDetail, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@jumlah", item.jumlah_transaksi);
                                cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                                cmd.Parameters.AddWithValue("@id_produk", item.id_produk);

                                cmd.ExecuteNonQuery();
                            }

                            // UPDATE STOK PRODUK
                            using (var cmd = new NpgsqlCommand(queryUpdateStok, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@jumlah", item.jumlah_transaksi);
                                cmd.Parameters.AddWithValue("@id_produk", item.id_produk);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("SQL ERROR:\n" + ex.Message);
                        return false;
                    }
                }
            }
        }


        public bool ProsesPembayaran(
            int idUser,
            List<(m_produk produk, int jumlah)> keranjang,
            string alamat,
            byte[] buktiPembayaran)
        {
            List<m_detailtransaksi> listDetail = new List<m_detailtransaksi>();

            foreach (var item in keranjang)
            {
                listDetail.Add(new m_detailtransaksi
                {
                    id_produk = item.produk.IdProduk,
                    jumlah_transaksi = item.jumlah
                });
            }

            m_transaksi transaksi = new m_transaksi
            {
                tanggal_transaksi = DateTime.Now,
                status_transaksi = "Menunggu Konfirmasi",
                alamat = alamat,
                id_user = idUser,
                bukti_pembayaran = buktiPembayaran
            };

            return SimpanTransaksi(transaksi, listDetail);
        }
    }
}
