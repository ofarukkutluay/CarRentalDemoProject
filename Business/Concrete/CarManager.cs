using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==01)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
            }
            
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id)) ;
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice<=0)
            {
                return new ErrorResult(Messages.CarDailyPriceInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
           
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails()) ;
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id)) ;
        }

        public IResult Update(int id)
        {
            Car car = (Car)GetById(id);
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
