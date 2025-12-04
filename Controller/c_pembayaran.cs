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
            string bank,
            string alamat,
            string status);
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

                    string queryTransaksi = @"
                    INSERT INTO transaksi 
                    (tanggal_transaksi, status_transaksi, pembayaran, alamat, id_user) 
                    VALUES (@tgl, @status, @bayar, @alamat, @id_user) 
                    RETURNING id_transaksi";

                    int idTransaksi;
                    using (var cmd = new NpgsqlCommand(queryTransaksi, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@tgl", transaksi.tanggal_transaksi);
                        cmd.Parameters.AddWithValue("@status", transaksi.status_transaksi ?? "");
                        cmd.Parameters.AddWithValue("@bayar", transaksi.pembayaran ?? "");
                        cmd.Parameters.AddWithValue("@alamat", transaksi.alamat ?? "");
                        cmd.Parameters.AddWithValue("@id_user", transaksi.id_user);
                        idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (var item in listDetail)
                    {

                        string queryDetail = @"
                        INSERT INTO detail_transaksi
                        (jumlah, id_transaksi, id_produk)
                        VALUES (@jumlah, @id_transaksi, @id_produk)";

                        using (var cmd = new NpgsqlCommand(queryDetail, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@jumlah", item.jumlah_transaksi);
                            cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                            cmd.Parameters.AddWithValue("@id_produk", item.id_produk);
                            cmd.ExecuteNonQuery();
                        }

                        string queryKurangiStok = @"
                        UPDATE produk
                        SET stok_produk = stok_produk - @jumlah
                        WHERE id_produk = @id AND stok_produk >= @jumlah";

                        using (var cmd = new NpgsqlCommand(queryKurangiStok, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@jumlah", item.jumlah_transaksi);
                            cmd.Parameters.AddWithValue("@id", item.id_produk);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 0)
                                throw new Exception($"Stok produk ID {item.id_produk} tidak cukup");
                        }
                    }

                    tran.Commit();
                    return true;
                }
            }
        }


        public bool ProsesPembayaran(int idUser,
            List<(m_produk produk, int jumlah)> keranjang,
            string bank,
            string alamat,
            string status)
        {
            List<m_detailtransaksi> listDetail = new List<m_detailtransaksi>();
            foreach (var item in keranjang)
            {
                listDetail.Add(new m_detailtransaksi
                {
                    id_produk = item.produk.IdProduk,
                    jumlah_transaksi = item.jumlah,
                    HargaSatuan = item.produk.HargaSatuan
                });
            }

            m_transaksi transaksi = new m_transaksi
            {
                tanggal_transaksi = DateTime.Now,
                status_transaksi = status,
                pembayaran = bank,
                alamat = alamat,
                id_user = idUser,
            };

            return SimpanTransaksi(transaksi, listDetail);
        }

    }
}
