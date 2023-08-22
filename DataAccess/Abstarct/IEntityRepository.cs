using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstarct
{
    public interface IEntityRepository<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
    }
}
