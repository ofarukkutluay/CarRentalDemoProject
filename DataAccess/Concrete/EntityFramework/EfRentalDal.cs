using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,CarRentalDatabaseContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalDatabaseContext context=new CarRentalDatabaseContext())
            {
                
                var result = from r in context.Rentals
                    join cu in context.Customers on r.CustomerId equals cu.Id
                    join u in context.Users on cu.UserId equals u.Id 
                    join car in context.Cars on r.CarId equals car.Id
                    join br in context.Brands on car.BrandId equals br.Id
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        CarBrandName = br.Name,
                        CustomerName = cu.CompanyName,
                        UserName = u.FirstName+" "+u.LastName,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
