using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IBeniUnutmaServices
    {
        BeniUnutma Add(BeniUnutma kullanici);
        void Update(BeniUnutma kullanici);
        List<BeniUnutma> GetAll();

        BeniUnutma GetById(int id);
    }
}
