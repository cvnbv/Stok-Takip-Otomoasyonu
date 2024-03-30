using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.DataAccessLayer.ComplexType;
using StokTakipOtomasyonu.DataAccessLayer.ContextBase.GenericRepository;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Concrete
{
    public class SatisManager : ISatisServices
    {
        IEntityRepository<Satislar> _context = new EFEntityRepositoryBase<Satislar>();
        public Satislar Add(Satislar Satislar)
        {
            return _context.Add(Satislar);
        }

        public void Delete(int Id)
        {
            var silinicek = _context.GetByID(h => h.Id == Id);

            _context.Delete(silinicek);

        }

        public List<Satislar> GetAll()
        {
            return _context.GetAll();
        }

        public Satislar GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);

        }

        public List<SatislarComplexType> GetSatislarwithUser()
        {
            SatislarCompexTypeManager satis = new SatislarCompexTypeManager();

            return satis.GetAllSatislarWithUser();
        }

        public void Update(Satislar Satislar)
        {
            _context.Update(Satislar);
        }

    }
}
