using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (BookStoreTrackerDBContext context = new BookStoreTrackerDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (BookStoreTrackerDBContext context = new BookStoreTrackerDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            using (BookStoreTrackerDBContext context = new BookStoreTrackerDBContext())
            {
                return expression == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(expression).ToList();
            }
        }
        public TEntity GetById(Expression<Func<TEntity, bool>> expression)
        {
            using (BookStoreTrackerDBContext context = new BookStoreTrackerDBContext())
            {
                try
                {
                    return context.Set<TEntity>().SingleOrDefault(expression);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public void Update(TEntity entity)
        {
            using (BookStoreTrackerDBContext context = new BookStoreTrackerDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
