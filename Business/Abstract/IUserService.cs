using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Entities.Concrete;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface IUserService:IServiceRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
