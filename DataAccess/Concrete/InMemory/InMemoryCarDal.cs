using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 75,ModelYear = new DateTime(2020),Description = "Renault Symbol"},
                new Car{Id = 2,BrandId = 2,ColorId = 1,DailyPrice = 150,ModelYear = new DateTime(2020),Description = "Mercedes A180"},
                new Car{Id = 3,BrandId = 3,ColorId = 2,DailyPrice = 175,ModelYear = new DateTime(2020),Description = "BMW 520d"},
                new Car{Id = 4,BrandId = 4,ColorId = 3,DailyPrice = 250,ModelYear = new DateTime(2020),Description = "Jaguar Xtype"},
                new Car{Id = 5,BrandId = 5,ColorId = 1,DailyPrice = 300,ModelYear = new DateTime(2020),Description = "Land Rover Evoque"}
            };
        }


        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}
