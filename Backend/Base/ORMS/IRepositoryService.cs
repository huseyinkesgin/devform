using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.ORMS
{
    public interface IRepositoryService<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter);
        T? Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        int Count(Expression<Func<T, bool>> filter);


    }
}
