using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarRentalDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalDatabaseContext context=new CarRentalDatabaseContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join cl in context.Colors 
                        on c.ColorId equals cl.Id
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.Name,
                        ColorName = cl.Name,
                        DailyPrice = c.DailyPrice,
                        ModelYear = c.ModelYear,
                        Description = c.Description,
                        ImagePath = (from a in context.CarImages where c.Id==a.CarId select a.ImagePath).FirstOrDefault(),
                        FindeksScore = c.FindeksScore
                    };
                return result.ToList();
            } 
        }

        public List<CarDetailDto> GetCarDetailsById(int carId)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join cl in context.Colors
                        on c.ColorId equals cl.Id
                    where c.Id == carId
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.Name,
                        ModelYear = c.ModelYear,
                        ColorName = cl.Name,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description,
                        ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault(),
                        FindeksScore = c.FindeksScore
                    };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ModelYear = c.ModelYear,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault(),
                                 FindeksScore = c.FindeksScore

                             };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ModelYear = c.ModelYear,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault(),
                                 FindeksScore = c.FindeksScore

                             };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandAndColor(int brandId, int colorId)
        {
            using (CarRentalDatabaseContext context = new CarRentalDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.BrandId == brandId
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ModelYear = c.ModelYear,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault(),
                                 FindeksScore = c.FindeksScore

                             };

                return result.ToList();
            }
        }
    }
}
