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
    public class SepetManager : ISepetServices
    {
        IEntityRepository<Sepet> _context = new EFEntityRepositoryBase<Sepet>();
        public Sepet Add(Sepet Sepet)
        {
            return _context.Add(Sepet);
        }

        public void Delete(int Id)
        {
            var silinicek = _context.GetByID(h => h.Id == Id);

            _context.Delete(silinicek);

        }

        public List<Sepet> GetAll()
        {
            return _context.GetAll();
        }

        public List<Sepet> GetAllKullaniciyaAitOlan(int Id)
        {
            return _context.GetList(h => h.UserID == Id);

        }

        public Sepet GetKullaniciyaAitOlan(int UserId)
        {
            return _context.Get(h => h.UserID == UserId);

        }
        public Sepet GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);

        }
        public Sepet GetByBarkodNo(string barkodNo)
        {
            return _context.Get(h => h.BarkodNo == barkodNo);

        }

        public void Update(Sepet Sepet)
        {
            _context.Update(Sepet);
        }
    }
}
