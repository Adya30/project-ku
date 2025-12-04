namespace TaniGrow2.Model
{
    public class m_transaksi
    {
        public int id_transaksi { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public string status_transaksi { get; set; }
        public string pembayaran { get; set; }
        public string alamat { get; set; }
        public int? id_user { get; set; }
    }
}
