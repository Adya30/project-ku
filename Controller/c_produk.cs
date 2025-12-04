using Npgsql;
using TaniGrow2.dbconnect;
using TaniGrow2.Model;

namespace TaniGrow2.Controller
{
    public abstract class ProdukBaseController
    {
        protected readonly connectdata db;

        protected ProdukBaseController()
        {
            db = new connectdata();
        }

        public abstract bool AddProduk(m_produk p);
        public abstract bool UpdateProduk(m_produk p);
        public abstract bool HapusProduk(int id);

        public virtual List<m_produk> GetProdukList()
        {
            var list = new List<m_produk>();

            try
            {
                using var conn = new NpgsqlConnection(db.connstring);
                conn.Open();

                string query = @"
                    SELECT 
                        p.id_produk,
                        p.foto_produk,
                        p.nama_produk,
                        p.stok_produk,
                        p.deskripsi,
                        p.harga_satuan,
                        p.is_deleted,
                        p.id_kategoriproduk,
                        k.nama_kategori
                    FROM produk p
                    LEFT JOIN kategori k ON p.id_kategoriproduk = k.id_kategoriproduk
                    WHERE p.is_deleted = FALSE";

                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new m_produk
                    {
                        IdProduk = reader.GetInt32(reader.GetOrdinal("id_produk")),
                        FotoProduk = reader["foto_produk"] == DBNull.Value ? null : (byte[])reader["foto_produk"],
                        NamaProduk = reader["nama_produk"]?.ToString() ?? "",
                        StokProduk = reader.GetInt32(reader.GetOrdinal("stok_produk")),
                        Deskripsi = reader["deskripsi"]?.ToString() ?? "",
                        HargaSatuan = reader.GetInt32(reader.GetOrdinal("harga_satuan")),
                        IsDeleted = reader.GetBoolean(reader.GetOrdinal("is_deleted")),
                        IdKategoriProduk = reader["id_kategoriproduk"] == DBNull.Value ? null : (int?)reader.GetInt32(reader.GetOrdinal("id_kategoriproduk")),
                        NamaKategori = reader["nama_kategori"]?.ToString() ?? ""
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetProdukList: " + ex.Message);
            }

            return list;
        }
    }

    public class c_produk : ProdukBaseController
    {
        public override bool AddProduk(m_produk p)
        {
            try
            {
                using var conn = new NpgsqlConnection(db.connstring);
                conn.Open();

                string query = @"
                    INSERT INTO produk
                        (foto_produk, nama_produk, stok_produk, deskripsi, harga_satuan, is_deleted, id_kategoriproduk)
                    VALUES
                        (@foto, @nama, @stok, @desk, @harga, FALSE, @kat)";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@foto", (object)p.FotoProduk ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@nama", p.NamaProduk ?? "");
                cmd.Parameters.AddWithValue("@stok", p.StokProduk);
                cmd.Parameters.AddWithValue("@desk", p.Deskripsi ?? "");
                cmd.Parameters.AddWithValue("@harga", p.HargaSatuan);
                cmd.Parameters.AddWithValue("@kat", (object)p.IdKategoriProduk ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error AddProduk: " + ex.Message);
                return false;
            }
        }

        public override bool UpdateProduk(m_produk p)
        {
            try
            {
                using var conn = new NpgsqlConnection(db.connstring);
                conn.Open();

                string query = @"
                    UPDATE produk SET
                        foto_produk = @foto,
                        nama_produk = @nama,
                        stok_produk = @stok,
                        deskripsi = @desk,
                        harga_satuan = @harga,
                        id_kategoriproduk = @kat
                    WHERE id_produk = @id";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@foto", (object)p.FotoProduk ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@nama", p.NamaProduk ?? "");
                cmd.Parameters.AddWithValue("@stok", p.StokProduk);
                cmd.Parameters.AddWithValue("@desk", p.Deskripsi ?? "");
                cmd.Parameters.AddWithValue("@harga", p.HargaSatuan);
                cmd.Parameters.AddWithValue("@kat", (object)p.IdKategoriProduk ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", p.IdProduk);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error UpdateProduk: " + ex.Message);
                return false;
            }
        }

        public override bool HapusProduk(int id)
        {
            try
            {
                using var conn = new NpgsqlConnection(db.connstring);
                conn.Open();

                string query = "UPDATE produk SET is_deleted = TRUE WHERE id_produk = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error HapusProduk: " + ex.Message);
                return false;
            }
        }

        public void UpdateStok(int idProduk, int stokBaru)
        {
            using var conn = db.getConn();
            conn.Open();
            string query = "UPDATE produk SET stok_produk = @stok WHERE id_produk = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@stok", stokBaru);
            cmd.Parameters.AddWithValue("@id", idProduk);
            cmd.ExecuteNonQuery();
        }
        public void CatatSupply(m_stokMasuk data)
        {
            using var conn = db.getConn();
            conn.Open();

            string query = @"
            INSERT INTO stok_masuk (id_produk, jumlah, tanggal_masuk, id_user)
            VALUES (@idp, @jml, @tgl, @usr)";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idp", data.IdProduk);
            cmd.Parameters.AddWithValue("@jml", data.Jumlah);
            cmd.Parameters.AddWithValue("@tgl", data.TanggalMasuk);
            cmd.Parameters.AddWithValue("@usr", (object)data.IdUser ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }



        // ======================================================
        // GET KATEGORI MAP (nama -> id) untuk ComboBox
        // ======================================================
        public Dictionary<string, int> GetKategoriMap()
        {
            var map = new Dictionary<string, int>();

            try
            {
                using var conn = new NpgsqlConnection(db.connstring);
                conn.Open();

                string query = "SELECT id_kategoriproduk, nama_kategori FROM kategori ORDER BY id_kategoriproduk";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("id_kategoriproduk"));
                    string nama = reader["nama_kategori"]?.ToString() ?? "";
                    map[nama] = id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetKategoriMap: " + ex.Message);
            }

            return map;
        }
    }
}
