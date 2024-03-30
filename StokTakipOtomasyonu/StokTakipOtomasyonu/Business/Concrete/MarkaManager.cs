using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.DataAccessLayer.ComplexType;
using StokTakipOtomasyonu.DataAccessLayer.ContextBase;
using StokTakipOtomasyonu.DataAccessLayer.ContextBase.GenericRepository;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using StokTakipOtomasyonu.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Concrete
{
    public class MarkaManager : IMarkaServices
    {
        IEntityRepository<Marka> _context = new EFEntityRepositoryBase<Marka>();
        public Marka Add(Marka Marka)
        {
            return _context.Add(Marka);
        }

        public void Delete(int Id)
        {
            var silinicek = _context.GetByID(h => h.Id == Id);

            _context.Delete(silinicek);

        }
        public void DeleteRanger(List<Marka> markas)
        {
            _context.DeleteRange(markas);


        }

        public List<Marka> GetAll()
        {
            return _context.GetAll();
        }

        public Marka GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);

        }

        public List<Marka> SeciliKategori(int Id)
        {
            return _context.GetList(h => h.KategoriID == Id).ToList();
        }

        public void Update(Marka Marka)
        {
            _context.Update(Marka);
        }

        public bool VarMi(string markaAdi, int kategoriID)
        {
            var result = _context.GetList(h => h.KategoriID == kategoriID  && h.MarkaAdi == markaAdi);

            if (result.Count == 0)
            {
                return true;
            }

            return false;
        }


        public List<MarkaComplexType> GetAllMarkawithKategori()
        {

            MarkaComplexTypeManager markaComplexType = new MarkaComplexTypeManager();

            return markaComplexType.GetAllMarkaWithKategori();
        }
    }
}
