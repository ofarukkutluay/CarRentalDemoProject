using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Core.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Brand entity)
        {
            if (entity.Name.Length > 2 )
            {
                if (CheckIfBrandNameExists(entity.Name).Success)
                {
                    _brandDal.Add(entity);
                    return new SuccessResult(Messages.BrandAdded);
                }
            }

            return new ErrorResult(Messages.BrandInvalidError);
        }

        [CacheAspect]
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id));
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.BrandUpdated);
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.BrandDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        private IResult CheckIfBrandNameExists(string brandName)
        {
            if (_brandDal.GetAll(b=>b.Name.ToLower()==brandName.ToLower()).Any())
            {
                return new ErrorResult(Messages.BrandNameAlreadyExists);
            }

            return new SuccessResult();
        }

        
    }
}
