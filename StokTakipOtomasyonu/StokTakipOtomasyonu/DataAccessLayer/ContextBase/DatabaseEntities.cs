using StokTakipOtomasyonu.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ContextBase
{
   public class DatabaseEntities:DbContext
    {
        public DatabaseEntities()
        {
           
        }

        public DbSet<Kullanici> kullanici { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<BeniUnutma> beniUnutma { get; set; }
        public DbSet<Kategori> kategori { get; set; }
        public DbSet<Urun> urun { get; set; }
        public DbSet<Sepet> sepet { get; set; }
        public DbSet<Satislar> satislar { get; set; }
  
        public DbSet<Marka> marka { get; set; }
      


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Kullanici>().ToTable("Kullanici");
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<BeniUnutma>().ToTable("BeniUnutma");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Urun>().ToTable("Urun");
            modelBuilder.Entity<Sepet>().ToTable("Sepet");
            modelBuilder.Entity<Satislar>().ToTable("Satislar");
            
            modelBuilder.Entity<Marka>().ToTable("Marka");
        


            base.OnModelCreating(modelBuilder);
        }
    }
}
