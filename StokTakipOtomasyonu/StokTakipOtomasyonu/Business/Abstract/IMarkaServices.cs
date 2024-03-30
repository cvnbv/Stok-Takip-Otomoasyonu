using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using StokTakipOtomasyonu.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IMarkaServices
    {
        Marka Add(Marka marka);
        void Delete(int Id);
        void Update(Marka marka);

        Marka GetById(int Id);
        void DeleteRanger(List<Marka> markas);
        List<Marka> SeciliKategori(int Id);

        List<Marka> GetAll();
        bool VarMi(string markaAdi, int kategoriID);


        List<MarkaComplexType> GetAllMarkawithKategori();

    }
}
