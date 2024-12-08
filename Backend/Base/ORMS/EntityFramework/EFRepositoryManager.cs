using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Base.ORMS.EntityFramework
{
    public class EFRepositoryManager<T, TContext> : IRepositoryService<T> where T : class, IEntity, new() where TContext : DbContext, new()
    {

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            using var context = new TContext();
            return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
        }

        public T Add(T entity)
        {
            using var context = new TContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            using var context = new TContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }

        public int Count(Expression<Func<T, bool>>? filter)
        {
            using var context = new TContext();
            return filter == null ? context.Set<T>().Count() : context.Set<T>().Count(filter);
        }

        public T Delete(T entity)
        {
            using var context = new TContext();
            entity.Deleted = true;
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }

        public T? Get(Expression<Func<T, bool>> filter)
        {
            using var context = new TContext();
            return context.Set<T>().SingleOrDefault(filter);
        }
    }
}
