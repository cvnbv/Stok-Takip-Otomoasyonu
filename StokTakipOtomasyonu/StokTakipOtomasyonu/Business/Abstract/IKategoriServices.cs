using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IKategoriServices
    {
        Kategori Add(Kategori kategori);
        void Delete(int Id);
        void Update(Kategori kategori);

        Kategori GetById(int Id);
        List<Kategori> GetAll();
     
        bool varMi(string ad);

    }
}
