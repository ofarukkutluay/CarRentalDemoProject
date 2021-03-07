using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Entities.Concrete;

namespace Core.Abstract
{
    public interface ICustomerService:IServiceRepository<Customer>
    {
    }
}
