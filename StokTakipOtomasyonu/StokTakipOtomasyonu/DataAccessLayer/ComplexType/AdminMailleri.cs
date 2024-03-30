using StokTakipOtomasyonu.DataAccessLayer.ContextBase;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ComplexType
{
    public class AdminMailleri
    {

        public List<AdminMaillerComplexType> GetAdminMailleri()
        {

            using (DatabaseEntities database = new DatabaseEntities())
            {


                //innerjoin ile istediğim şekilde bir tablo yapısı oluşturdum
                var result = (from Admin in database.kullanici
                              where Admin.RolID ==1
                              select new AdminMaillerComplexType()
                              {
                                     AdminmailAdres = Admin.Mail,
                                    


                              }).ToList();
                return result;
            }
        }
    }
}
