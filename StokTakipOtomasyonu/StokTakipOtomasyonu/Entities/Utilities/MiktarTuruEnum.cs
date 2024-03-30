using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Utilities
{
    public static class MiktarTuruEnum
    {
       public static List<string> MiktarTurleri()
        {
            List<string> Turler = new List<string>();
            Turler.Add("Adet");
            Turler.Add("Kilogram");
            Turler.Add("Litre");
            Turler.Add("Metre");
            Turler.Add("Palet");
            Turler.Add("Ton");

            return Turler;

        }

    }
}
