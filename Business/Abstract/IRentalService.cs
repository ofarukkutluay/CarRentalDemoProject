using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Core.Abstract
{
    public interface IRentalService:IServiceRepository<Rental>
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();

    }
}
