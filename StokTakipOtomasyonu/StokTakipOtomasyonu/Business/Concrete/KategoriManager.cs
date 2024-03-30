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
    public class KategoriManager :IKategoriServices
    {
        IEntityRepository<Kategori> _context = new EFEntityRepositoryBase<Kategori>();

        public Kategori Add(Kategori kategori)
        {
            return _context.Add(kategori);
        }

        public void Delete(int Id)
        {
            var silinicek = _context.GetByID(h => h.Id == Id);

            _context.Delete(silinicek);

        }

        public List<Kategori> GetAll()
        {
            return _context.GetAll();
        }

        public Kategori GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);
            
        }

        public void Update(Kategori kategori)
        {
            _context.Update(kategori);
        }

        public bool varMi(string ad)
        {
            var result = _context.GetList(h => h.KategoriAdi == ad);

            if (result.Count == 0 )
            {
                return true;
            }

            return false;
        }


       
    }
}
