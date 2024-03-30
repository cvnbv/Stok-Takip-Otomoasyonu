using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface ISatisServices
    {
        Satislar Add(Satislar satislar);
        void Delete(int Id);
        void Update(Satislar satislar);

        Satislar GetById(int Id);
        List<Satislar> GetAll();

        List<SatislarComplexType> GetSatislarwithUser();

    }
}
