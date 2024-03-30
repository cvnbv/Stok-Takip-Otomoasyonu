using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IKullaniciServices : IKullaniciBasicServices
    {
       
        List<Kullanici> GetAllOnayBekleyenler();
        List<Kullanici> GetAllPersonel();
        List<Kullanici> GetAllMusteri();
        Kullanici GetAllMusteriSepeti(int id);
       

        bool GenericIsLOgin(string tc,string username, string sifre);

        bool BilgiKontrol(string ad, string tc, string date, string Cinsiyet);

        bool KullaniciVarMi(string tc, string username);

    }
}
