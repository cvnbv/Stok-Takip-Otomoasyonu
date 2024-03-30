using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables.ComplexType
{
    public class MarkaComplexType
    {
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
    }
}
