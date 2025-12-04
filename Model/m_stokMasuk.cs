namespace TaniGrow2.Model
{
    public class m_stokMasuk
    {
        public int IdStokMasuk { get; set; }
        public int IdProduk { get; set; }
        public int Jumlah { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public int? IdUser { get; set; }

        public m_produk Produk { get; set; }
        public User User { get; set; }
    }

}
