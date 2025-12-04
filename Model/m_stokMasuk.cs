using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaniGrow2.Model
{
    public class m_stokMasuk
    {
        public int IdStokMasuk { get; set; }
        public int IdProduk { get; set; }
        public int Jumlah { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public int? IdUser { get; set; }
    }

}
