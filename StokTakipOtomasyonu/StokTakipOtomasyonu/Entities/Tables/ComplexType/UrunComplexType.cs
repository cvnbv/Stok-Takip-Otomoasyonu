using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables.ComplexType
{
    public  class UrunComplexType
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }

        public string MiktarTuru { get; set; }
        public decimal MiktarTane { get; set; }
        public decimal MiktarSayisi { get; set; }
   
        public decimal SatisFiyati { get; set; }

        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string resim { get; set; }

        //Kapsülleme örneği

        private string _resimYolu;

        public string ResimYolu
        {
            get
            {
                return _resimYolu;
            }

            set
            {
                if (resim != null)
                {                           //resim null gelirse yol ona standart resim yolunu vericek
                    _resimYolu = value;
                }
                else
                {
                    _resimYolu = "Wıxı.png";
                }
            }
        }

        public decimal AlisFiyati { get; set; }



    }
}
