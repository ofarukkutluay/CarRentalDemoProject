using System.Collections.Generic;
using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [CacheAspect]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        [CacheRemoveAspect("IServiceRepository")]
        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult(Messages.ColorAdded);

        }

        [CacheAspect]
        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(cl => cl.Id == id));
        }

        [CacheRemoveAspect("IServiceRepository")]
        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.ColorUpdated);
        }

        [CacheRemoveAspect("IServiceRepository")]
        public IResult Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(Messages.ColorDeleted);
        }
    }
}
