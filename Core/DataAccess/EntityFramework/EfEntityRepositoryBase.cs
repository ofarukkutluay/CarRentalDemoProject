using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity> 
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakaldık
                addedEntity.State = EntityState.Added; //database e eklemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani ekledik
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakaldık
                updatedEntity.State = EntityState.Modified; //database e güncellemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani güncelledik
            };
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı yakaldık
                deletedEntity.State = EntityState.Deleted; //database e silmeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani sildik
            }
        }
    }
}
