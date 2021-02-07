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
    public class EfColorDal:IColorDal
    {
        public Color Get(Expression<Func<Color,bool>> filter)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color,bool>> filter = null)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Add(Color entity)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakaldık
                addedEntity.State = EntityState.Added; //database e eklemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani ekledik
            }
        }

        public void Update(Color entity)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakaldık
                updatedEntity.State = EntityState.Modified; //database e güncellemeyi set ettik
                context.SaveChanges(); // Değişiklikleri kaydettik yani güncelledik
            }
        }

        public void Delete(Color entity)
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
