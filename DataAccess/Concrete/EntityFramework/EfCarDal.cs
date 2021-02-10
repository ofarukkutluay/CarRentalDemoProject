﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

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
                    join cl in context.Colors on c.ColorId equals cl.Id
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.Name,
                        ColorName = cl.Name,
                        DailyPrice = c.DailyPrice,
                        ModelYear = c.ModelYear,
                        Description = c.Description
                    };
                return result.ToList();
            } 
        }
    }
}
