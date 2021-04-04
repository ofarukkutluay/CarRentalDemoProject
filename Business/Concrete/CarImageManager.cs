using System.Collections.Generic;
using Business.Abstract;
using Core.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarImageManager:ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Add(CarImage entity)
        {
            IResult result = BusinessRules.Run(CheckIfCountOfImageCorrect(entity.CarId));
            if (result != null)
            {
                return result;
            }
            _carImageDal.Add(entity);
            return new SuccessResult(Messages.CarImageAdd);

        }

        [CacheAspect]
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(ci=>ci.Id==id));
        }

        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Update(CarImage entity)
        {
            _carImageDal.Update(entity);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Delete(CarImage entity)
        {
            _carImageDal.Delete(entity);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetCarImagesByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == id));
        }
        
        private IResult CheckIfCountOfImageCorrect(int carId)
        {
            if (_carImageDal.GetAll(ci=>ci.CarId==carId).Count <= 5)
            {
                return new SuccessResult();
            }

            return new ErrorResult(Messages.CarImageCountOfImageError);
        }
        
        
    }
}
