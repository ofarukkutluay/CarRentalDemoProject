using System;
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

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(1)) // ColorId 1 yani beyaz olanları listeler
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------------------------------------------------------------");
            foreach (var car in carManager.GetCarsByBrandId(3)) // BrandId yani BMW olanları listeler
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------------------------------------------------------------------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll()) //Tüm markaları listeler
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine("------------------------------------------------------------------");
            //carManager.Add(new Car{BrandId = 1,ColorId = 2,DailyPrice = 100,Description = "Renault Clio",ModelYear = 2019});

            foreach (var car in carManager.GetAll()) // ColorId 1 yani beyaz olanları listeler
            {
                Console.WriteLine("{0} id {1} Marka numaralı {2} renk numaralı {3} günlük fiyatlı {4} Model yılında {5} araç",
                    car.Id,car.BrandId,car.ColorId,car.DailyPrice,car.ModelYear,car.Description);
            }
            Console.WriteLine("------------------------------------------------------------------");

        }
    }
}
