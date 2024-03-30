using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.DataAccessLayer.ContextBase.GenericRepository;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Utilities;
using StokTakipOtomasyonu.Security;
using StokTakipOtomasyonu.Security.UserInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Concrete
{
    public class KullaniciManagerGeneric : IKullaniciServices
    {
        IEntityRepository<Kullanici> _context = new EFEntityRepositoryBase<Kullanici>();

        public Kullanici Add(Kullanici kullanici)
        {
            var r = _context.Add(kullanici);
            return r;
        }

        public void Delete(int Id)
        {
            var r = _context.GetByID(h => h.Id == Id);
            _context.Delete(r);
        }

        public List<Kullanici> GetAll()
        {
            return _context.GetAll();
        }

        public Kullanici GetById(int Id)
        {
            return _context.GetByID(h => h.Id == Id);
        }

        public void Update(Kullanici kullanici)
        {
          _context.Update(kullanici);
        }

        public bool GenericIsLOgin(string tc,string username, string sifre)
        {
            var user = _context.GetByID(h => h.KullaniciName == username && h.KullaniciPassword == sifre && h.TCKimlik == tc);

            if (user != null)
            {

                //Giriş yapılırsa doğru kimlik ile bilgileri burda class a dolucak
                //Class ı statik tanımlayıp bilgileri içerisinde sabit tuttum

                UserDetailBus.Id = user.Id;
                UserDetailBus.KullaniciName = user.KullaniciName;
                UserDetailBus.KullaniciPassword = user.KullaniciPassword;
                UserDetailBus.RolID = user.RolID;
                UserDetailBus.Mail = user.Mail;
                UserDetailBus.ResimYolu = user.ResimYolu;
                UserDetailBus.TelNo = user.TelNo;
                UserDetailBus.Adres = user.Adres;
                UserDetailBus.TCKimlik = user.TCKimlik;
                UserDetailBus.Dogumtarihi = user.Dogumtarihi;
                UserDetailBus.Cinsiyet = user.Cinsiyet;
                UserDetailBus.Onayli = user.Onayli;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BilgiKontrol(string ad, string tc, string date, string Cinsiyet)
        {

            var user = _context.GetByID(h => h.KullaniciName == ad && h.TCKimlik == tc && h.Dogumtarihi.ToString() == date && h.Cinsiyet == Cinsiyet);

            if (user != null)
            {
                UserDetailBus.Id = user.Id;
                UserDetailBus.KullaniciName = user.KullaniciName;
                UserDetailBus.KullaniciName = user.KullaniciName;
                UserDetailBus.RolID = user.RolID;
                UserDetailBus.Mail = user.Mail;
                UserDetailBus.ResimYolu = user.ResimYolu;
                UserDetailBus.TelNo = user.TelNo;
                UserDetailBus.Adres = user.Adres;
                UserDetailBus.TCKimlik = user.TCKimlik;
                UserDetailBus.Dogumtarihi = user.Dogumtarihi;
                UserDetailBus.Cinsiyet = user.Cinsiyet;
                UserDetailBus.Onayli = user.Onayli;

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Kullanici> GetAllPersonel()
        {
            return _context.GetList(h => h.RolID == 3).ToList();
        }

        public List<Kullanici> GetAllMusteri()
        {
            return _context.GetList(h => h.RolID == 2).ToList();
        }

        public Kullanici GetAllMusteriSepeti(int id)
        {
            return _context.Get(h => h.RolID == 2 && h.Id == id);
        }

        public List<Kullanici> GetAllOnayBekleyenler()
        {
            return _context.GetList(h => h.RolID == 0 && h.Onayli == false).ToList();
        }

        public bool KullaniciVarMi(string tc, string username)
        {
            var result = _context.GetList(h => h.TCKimlik == tc && h.KullaniciName == username);

            if (result.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
