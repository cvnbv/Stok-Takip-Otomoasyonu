using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.DataAccessLayer.ContextBase.GenericRepository;
using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Concrete
{
    public class RolManager : IRolServices
    {
        IEntityRepository<Rol> _context = new EFEntityRepositoryBase<Rol>();
        public Rol Add(Rol Rol)
        {
            return _context.Add(Rol);
        }

        public void Delete(int Id)
        {
            var silinicek = _context.GetByID(h => h.Id == Id);

            _context.Delete(silinicek);

        }

        public List<Rol> GetAll()
        {
            return _context.GetAll();
        }

        public Rol GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);

        }

        public void Update(Rol Rol)
        {
            _context.Update(Rol);
        }
    }
}
