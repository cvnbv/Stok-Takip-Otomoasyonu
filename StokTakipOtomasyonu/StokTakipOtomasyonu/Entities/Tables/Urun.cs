using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int MarkaID { get; set; }
        public string MiktarTuru { get; set; }
        public decimal MiktarTane { get; set; }
        public decimal MiktarSayisi { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int KategoriID { get; set; }



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
                    _resimYolu = value;
            }
        }
    }
}
