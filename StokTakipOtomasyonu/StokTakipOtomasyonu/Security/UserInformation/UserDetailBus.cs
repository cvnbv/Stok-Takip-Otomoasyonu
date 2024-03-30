using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Security.UserInformation
{
    public class UserDetailBus
    {
        public static int Id { get; set; }
        public static string KullaniciName { get; set; }
        public static string KullaniciPassword { get; set; }
        public static string TelNo { get; set; }
        public static string Mail { get; set; }
        public static string Adres { get; set; }
        public static string TCKimlik { get; set; }
        public static string ResimYolu { get; set; }
        public static DateTime Dogumtarihi { get; set; }
        public static string Cinsiyet { get; set; }
        public static int RolID { get; set; }
        public static bool Onayli { get; set; }
    }           
}
