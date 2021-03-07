using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Core.Abstract
{
    public interface ICarImageService:IServiceRepository<CarImage>
    {
        IDataResult<List<CarImage>> GetCarImagesByCarId(int id);
    }
}
