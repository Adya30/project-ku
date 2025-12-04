using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaniGrow2.Model
{
    public class m_detailtransaksi
    {
        public int id_detailtransaksi { get; set; }
        public int jumlah_transaksi { get; set; }
        public int? id_transaksi { get; set; }
        public int? id_produk { get; set; }
        public int HargaSatuan { get; set; }
    }

}
