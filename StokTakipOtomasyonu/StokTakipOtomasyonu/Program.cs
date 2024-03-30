using Ninject;
using StokTakipOtomasyonu.Business.Concrete;
using StokTakipOtomasyonu.Business.Dependency.Ninject;
using StokTakipOtomasyonu.Kullanici_Islemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CompositionRoot.Initialize();
            Application.Run(CompositionRoot.Resolve<LoginAna>());

          
        }
    }



    public class CompositionRoot
    {
        private static IKernel ninjectKernel;

        public static void Initialize()
        {

            ninjectKernel = new StandardKernel(new BusinessModel());
        }

        public static T Resolve<T>()
        {
            return ninjectKernel.Get<T>();
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return ninjectKernel.GetAll<T>();
        }
    }
}

