using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Add(User entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
