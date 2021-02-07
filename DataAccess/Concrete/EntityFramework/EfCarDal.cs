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
    public class EfCarDal:ICarDal
    {
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Add(Car entity)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakaldık
                addedEntity.State = EntityState.Added; //database e eklemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani ekledik
            }
        }

        public void Update(Car entity)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakaldık
                updatedEntity.State = EntityState.Modified; //database e güncellemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani güncelledik
            }
        }

        public void Delete(Car entity)
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
