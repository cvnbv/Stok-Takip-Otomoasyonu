using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface ISepetServices
    {
        Sepet Add(Sepet sepet);
        void Delete(int Id);
        void Update(Sepet sepet);

        Sepet GetById(int Id);
        List<Sepet> GetAll();
        List<Sepet> GetAllKullaniciyaAitOlan(int Id);
        Sepet GetKullaniciyaAitOlan(int UserId);
        Sepet GetByBarkodNo(string barkodNo);

    }
}
