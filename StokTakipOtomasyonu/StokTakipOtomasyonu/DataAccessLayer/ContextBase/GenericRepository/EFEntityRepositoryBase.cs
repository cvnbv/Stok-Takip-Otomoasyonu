using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ContextBase.GenericRepository
{
    public class EFEntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {
        private DatabaseEntities _context = new DatabaseEntities();
        private DbSet<T> _dbSet;

        public EFEntityRepositoryBase()
        {
            _dbSet = _context.Set<T>();
        }

        //Birden Fazla Veriyi Silme
        public void DeleteRange(List<T> entities)
        {

            foreach (var entity in entities)
            {
                Delete(entity);
            }
        

        }

        //gönderilen filter a göre listeleme
        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
           
                return filter == null
                    ? _context.Set<T>().ToList()
                    : _context.Set<T>().Where(filter).ToList();
            
        }

        //kayıt ekleem metedu
        public T Add(T entity)
        {
            var result = _dbSet.Add(entity);
            _context.SaveChanges();
            return result;
        }

        //silme metodu eklendi
        public void Delete(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        //hepsini lsiteleme işlemi
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        // id parametresine göre cekme işlemi eklendi
        public T GetByID(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().SingleOrDefault(filter);
        }
        // nesnelerin güncellenmesi eklendi
        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //gönderilen filter a göre tek nesne gönderme
        public T Get(Expression<Func<T, bool>> filter = null)
        {
           
                return _context.Set<T>().SingleOrDefault(filter);
            
        }
    }
}
