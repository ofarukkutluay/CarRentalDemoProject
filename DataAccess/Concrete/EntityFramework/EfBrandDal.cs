using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:IBrandDal
    {
        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                return filter == null 
                    ? context.Set<Brand>().ToList() 
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Add(Brand entity)
        {
            using (CarRentalDatabaseContext context=new CarRentalDatabaseContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakaldık
                addedEntity.State = EntityState.Added; //database e eklemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani ekledik
            }
        }

        public void Update(Brand entity)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakaldık
                updatedEntity.State = EntityState.Modified; //database e güncellemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani güncelledik
            }
        }

        public void Delete(Brand entity)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı yakaldık
                deletedEntity.State = EntityState.Deleted; //database e silmeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani sildik
            }
        }
    }
}
