using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IRolServices
    {
        Rol Add(Rol rol);
        void Delete(int Id);
        void Update(Rol rol);

        Rol GetById(int Id);
        List<Rol> GetAll();
    }
}
