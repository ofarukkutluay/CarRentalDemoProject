using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Business
{
    public interface IServiceRepository<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IDataResult<T> GetById(int id);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
