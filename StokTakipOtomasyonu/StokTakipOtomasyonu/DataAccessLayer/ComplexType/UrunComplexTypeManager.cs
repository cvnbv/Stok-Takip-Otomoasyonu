using StokTakipOtomasyonu.DataAccessLayer.ContextBase;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ComplexType
{
    public class UrunComplexTypeManager
    {

        public List<UrunComplexType> GetUrunWithMarkaKategori()
        {

            using (DatabaseEntities database = new DatabaseEntities())
            {


                //innerjoin ile istediğim şekilde bir tablo yapısı oluşturdum
                var result = (from urun in database.urun
                              join marka in database.marka on urun.MarkaID equals marka.Id
                              join kategori in database.kategori on urun.KategoriID equals kategori.Id
                              where (urun.MiktarSayisi > 0)
                              select new UrunComplexType()
                              {
                                  Id = urun.Id,
                                  BarkodNo = urun.BarkodNo,
                                  UrunAdi = urun.UrunAdi,
                                  MarkaID = marka.Id,
                                  MarkaAdi = marka.MarkaAdi,
                                  MiktarTane = urun.MiktarTane,
                                  MiktarSayisi = urun.MiktarSayisi,
                                  MiktarTuru = urun.MiktarTuru,
                                  SatisFiyati = urun.SatisFiyati,
                                  KategoriID = kategori.Id,
                                  KategoriAdi = kategori.KategoriAdi,
                                  resim = urun.ResimYolu,
                                  ResimYolu = urun.ResimYolu,
                                  AlisFiyati = urun.AlisFiyati


                              }).ToList();
                return result;
            }


        }
        public List<UrunComplexType> GetistenilenFiltre(int kategoriID,int markaID)
        {

            using (DatabaseEntities database = new DatabaseEntities())
            {


                //innerjoin ile istediğim şekilde bir tablo yapısı oluşturdum
                var result = (from urun in database.urun
                              join marka in database.marka on urun.MarkaID equals marka.Id
                              join kategori in database.kategori on urun.KategoriID equals kategori.Id
                              where (urun.MiktarSayisi > 0) && urun.MarkaID ==markaID && urun.KategoriID == kategoriID
                              select new UrunComplexType()
                              {
                                  Id = urun.Id,
                                  BarkodNo = urun.BarkodNo,
                                  UrunAdi = urun.UrunAdi,
                                  MarkaID = marka.Id,
                                  MarkaAdi = marka.MarkaAdi,
                                  MiktarTane = urun.MiktarTane,
                                  MiktarSayisi = urun.MiktarSayisi,
                                  MiktarTuru = urun.MiktarTuru,
                                  SatisFiyati = urun.SatisFiyati,
                                  KategoriID = kategori.Id,
                                  KategoriAdi = kategori.KategoriAdi,
                                  resim = urun.ResimYolu,
                                  ResimYolu = urun.ResimYolu,
                                  AlisFiyati = urun.AlisFiyati


                              }).ToList();
                return result;
            }


        }


    }
}
