using StokTakipOtomasyonu.DataAccessLayer.ContextBase;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ComplexType
{
    public class MarkaComplexTypeManager 
    {

        public List<MarkaComplexType> GetAllMarkaWithKategori()
        {

            using (DatabaseEntities database = new DatabaseEntities())
            {
                

                //innerjoin ile istediğim şekilde bir tablo yapısı oluşturdum
                var result = (from Marka in database.marka
                              join Kategori in database.kategori on Marka.KategoriID equals Kategori.Id
                              select new MarkaComplexType()
                              {
                                  MarkaAdi = Marka.MarkaAdi,
                                  MarkaID = Marka.Id,
                                  KategoriID = Kategori.Id,
                                  KategoriAdi = Kategori.KategoriAdi

                              }).ToList();
                return result;
            }


        }
    }
}
