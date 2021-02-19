using System;
using System.Data.SqlTypes;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2020,10,5)
            });
            //rentalManager.Delete(new Rental
            //{
            //    Id = 9
            //});

            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                    rental.Id,rental.CarBrandName,rental.CustomerName,rental.UserName,rental.RentDate,rental.ReturnDate);
            }



        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(1).Data) // ColorId 1 yani beyaz olanları listeler
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------------------------------------------------------------------");
            foreach (var car in carManager.GetCarsByBrandId(3).Data) // BrandId yani BMW olanları listeler
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------------------------------------------------------------------");


            //carManager.Add(new Car{BrandId = 1,ColorId = 2,DailyPrice = 100,Description = "Renault Clio",ModelYear = 2019});

            foreach (var car in carManager.GetAll().Data) // ColorId 1 yani beyaz olanları listeler
            {
                Console.WriteLine("{0} id {1} Marka numaralı {2} renk numaralı {3} günlük fiyatlı {4} Model yılında {5} araç",
                    car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);
            }

            Console.WriteLine("------------------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails().Data) // ColorId 1 yani beyaz olanları listeler
            {
                Console.WriteLine("{0} id {1} Marka numaralı {2} renk numaralı {3} günlük fiyatlı {4} Model yılında {5} araç",
                    car.Id, car.BrandName, car.ColorName, car.DailyPrice, car.ModelYear, car.Description);
            }

            Console.WriteLine("------------------------------------------------------------------");

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data) //Tüm markaları listeler
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
