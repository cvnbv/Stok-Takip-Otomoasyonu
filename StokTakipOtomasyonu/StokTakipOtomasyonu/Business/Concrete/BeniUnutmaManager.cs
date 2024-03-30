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
    public class BeniUnutmaManager : IBeniUnutmaServices
    {
        IEntityRepository<BeniUnutma> _context = new EFEntityRepositoryBase<BeniUnutma>();

        public BeniUnutma Add(BeniUnutma kullanici)
        {
            var r = _context.Add(kullanici);
            return r;
        }

        public List<BeniUnutma> GetAll()
        {
            return _context.GetAll();
        }

        public void Update(BeniUnutma kullanici)
        {
           _context.Update(kullanici);
        }

        public BeniUnutma GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);
        }
    }
}
