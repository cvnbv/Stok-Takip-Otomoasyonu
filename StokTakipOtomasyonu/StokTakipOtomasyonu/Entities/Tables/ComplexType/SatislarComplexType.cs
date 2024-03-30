using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables.ComplexType
{
    public class SatislarComplexType
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string SatinAlanName { get; set; }
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public decimal Miktar { get; set; }
        public string MiktarTuru { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
        public int SatisiOnaylayanUserID { get; set; }
        public string SatisiOnaylayanName { get; set; }
        public DateTime? SatisYapilanTarih { get; set; }

    }
}
