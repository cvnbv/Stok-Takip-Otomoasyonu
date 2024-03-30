using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Tables.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Abstract
{
    public interface IUrunServices
    {
        Urun Add(Urun urun);
        void Delete(int Id);
        void Update(Urun urun);

        Urun GetById(int Id);
        List<Urun> GetAll();
        void DeleteRange(List<Urun> uruns);
        List<Urun> GetKategoriID(int kategoriID);
        List<UrunComplexType> GetAllStoktakilerwithMarkaKategori();
        List<UrunStokBitenComplexType> GetAllStokBiten();
        List<UrunComplexType> Getistenilenfiltre(int kategoriID, int markaID);
        Urun GetBarkodNo(string BarkodNo);
        bool AynıBarkodMu(string barkodNo);

    }
}
