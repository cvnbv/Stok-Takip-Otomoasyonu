using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.DataAccessLayer.ContextBase.GenericRepository
{
    public interface IEntityRepository<T>
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        void DeleteRange(List<T> entities);
        T GetByID(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
    }
}
