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
    public class UrunManager:IUrunServices
    {
        IEntityRepository<Urun> _context = new EFEntityRepositoryBase<Urun>();

        public Urun Add(Urun Urun)
        {
            return _context.Add(Urun);
        }

        public bool AynıBarkodMu(string barkodNo)
        {
            var silinicek = _context.Get(h => h.BarkodNo == barkodNo);

            if (silinicek != null)
            {
              return  true;
            }

            return false;
        }

        public void Delete(int Id)
        {
            var silinicek = _context.GetByID(h => h.Id == Id);

            _context.Delete(silinicek);

        }

        public void DeleteRange(List<Urun> uruns)
        {
            _context.DeleteRange(uruns);

        }
        public List<Urun> GetAll()
        {
            return _context.GetAll();
        }

        public List<UrunComplexType> GetAllStoktakilerwithMarkaKategori()
        {
            UrunComplexTypeManager urun = new UrunComplexTypeManager();

            return urun.GetUrunWithMarkaKategori();
        }

        public List<UrunStokBitenComplexType> GetAllStokBiten()
        {
            UrunStokBitenComplexTypeManager urun = new UrunStokBitenComplexTypeManager();

            return urun.GetUrunStokBiten();
        }

        public List<UrunComplexType> Getistenilenfiltre(int kategoriID,int markaID)
        {
            UrunComplexTypeManager urun = new UrunComplexTypeManager();

            return urun.GetistenilenFiltre(kategoriID,markaID);
        }

        public List<Urun> GetKategoriID(int kategoriID)
        {
            var istenilenlsite = _context.GetList(h => h.KategoriID == kategoriID );

            return istenilenlsite;
        }
        public Urun GetBarkodNo(string BarkodNo)
        {
            return _context.Get(h => h.BarkodNo == BarkodNo);
        }

        public Urun GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);

        }

        public void Update(Urun Urun)
        {
            _context.Update(Urun);
        }

    }
}
