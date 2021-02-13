using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IDataResult<Color> GetById(int id);
        IResult Update(Color color);
        IResult Delete(Color color);

    }
}
