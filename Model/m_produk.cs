namespace TaniGrow2.Model
{
    public class m_produk
    {
        public int IdProduk { get; set; }
        public byte[]? FotoProduk { get; set; }
        public string NamaProduk { get; set; }
        public int StokProduk { get; set; }
        public string Deskripsi { get; set; }
        public bool IsDeleted { get; set; }
        public int HargaSatuan { get; set; }
        public int? IdKategoriProduk { get; set; }
        public string NamaKategori { get; set; }
    }
}
