using Ninject.Modules;
using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Business.Dependency.Ninject
{
    public class BusinessModel : NinjectModule
    {
        public override void Load()
        {
            Bind<IKullaniciServices>().To<KullaniciManagerGeneric>();
            Bind<IBeniUnutmaServices>().To<BeniUnutmaManager>();
            Bind<IKategoriServices>().To<KategoriManager>();
            Bind<IUrunServices>().To<UrunManager>();
            Bind<ISepetServices>().To<SepetManager>();
            Bind<IRolServices>().To<RolManager>();
            Bind<ISatisServices>().To<SatisManager>();
           
            Bind<IMarkaServices>().To<MarkaManager>();
        }
    }
}
