using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IKullaniciBasicServices
    {
        Kullanici Add(Kullanici kullanici);
        void Delete(int Id);
        void Update(Kullanici kullanici);

        Kullanici GetById(int Id);
        List<Kullanici> GetAll();
    }
}
