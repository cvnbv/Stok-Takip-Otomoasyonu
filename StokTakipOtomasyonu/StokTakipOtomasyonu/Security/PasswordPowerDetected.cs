using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Security
{

    public class PasswordPowerDetected
    {

     
        public int GeneratePasswordScore(string password)
        {
            if (password == null)
            {
                return 0;
            }

            int lengthScore = UzunlukPuani(password);
            int lowerScore = KucukHarfPuani(password);
            int upperScore = BuyukHarfPuani(password);
            int digitScore = RakamPuani(password);
            int symbolScore = SembolPuani(password);

            return lengthScore + lowerScore + upperScore + digitScore + symbolScore;
        }

        public PasswordStrength GetPasswordStrength(string password)
        {
            int score = GeneratePasswordScore(password);

            if (score < 50)
                return PasswordStrength.Gecersiz;
            else if (score < 60)
                return PasswordStrength.Zayif;
            else if (score < 80)
                return PasswordStrength.Normal;
            else if (score < 90)
                return PasswordStrength.Guclu;
            else
                return PasswordStrength.Guvenli;
        }

        public enum PasswordStrength
        {
            Gecersiz,
            Zayif,
            Normal,
            Guclu,
            Guvenli
        }

        private int UzunlukPuani(string password)
        {
            return Math.Min(10, password.Length) * 6;
        }

        private int KucukHarfPuani(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[a-z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int BuyukHarfPuani(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int RakamPuani(string password)
        {
            int rawScore = password.Length - Regex.Replace(password, "[0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }

        private int SembolPuani(string password)
        {
            int rawScore = Regex.Replace(password, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawScore) * 5;
        }
    }
}
