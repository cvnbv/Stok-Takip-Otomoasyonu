using StokTakipOtomasyonu.DataAccessLayer.ContextBase;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ComplexType
{
    public class PersonelMailleri
    {
        public List<PersonelMailleriComplexType> GetPersonelMailleri()
        {

            using (DatabaseEntities database = new DatabaseEntities())
            {


                //innerjoin ile istediğim şekilde bir tablo yapısı oluşturdum
                var result = (from Personel in database.kullanici
                              where Personel.RolID == 3
                              select new PersonelMailleriComplexType()
                              {
                                  PersonelMialler = Personel.Mail,



                              }).ToList();
                return result;
            }
        }
    }
}
