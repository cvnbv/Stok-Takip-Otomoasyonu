using StokTakipOtomasyonu.DataAccessLayer.ContextBase;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ComplexType
{
    public class SatislarCompexTypeManager
    {

        public List<SatislarComplexType> GetAllSatislarWithUser()
        {

            using (DatabaseEntities database = new DatabaseEntities())
            {


                //innerjoin ile istediğim şekilde bir tablo yapısı oluşturdum
                var result = (from Satislar in database.satislar
                              join AlanKukllanici in database.kullanici on Satislar.UserID equals AlanKukllanici.Id
                              join SatanKullanici in database.kullanici on Satislar.SatisiOnaylayanUserID equals SatanKullanici.Id
                              select new SatislarComplexType()
                              {
                                  Id = Satislar.Id,
                                  UserID = Satislar.UserID,
                                  SatinAlanName= AlanKukllanici.KullaniciName,
                                  BarkodNo = Satislar.BarkodNo,
                                  UrunAdi = Satislar.UrunAdi,
                                  Miktar = Satislar.Miktar,
                                  MiktarTuru = Satislar.MiktarTuru,
                                  Fiyat = Satislar.Fiyat,
                                  Tutar = Satislar.Tutar,
                                  SatisiOnaylayanName = SatanKullanici.KullaniciName,
                                  SatisiOnaylayanUserID = SatanKullanici.Id,
                                  SatisYapilanTarih= Satislar.SatisYapilanTarih
                                
                              }).ToList();
                return result;
            }


        }
    }
}
