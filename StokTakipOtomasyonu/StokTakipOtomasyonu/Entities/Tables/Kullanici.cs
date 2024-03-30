using StokTakipOtomasyonu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciName { get; set; }
        public string KullaniciPassword { get; set; }
        public int RolID { get; set; }
        public string TelNo { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string TCKimlik { get; set; }
        public string ResimYolu { get; set; }
        public DateTime Dogumtarihi { get; set; }
        public string Cinsiyet { get; set; }
        public bool Onayli { get; set; }

    }
}