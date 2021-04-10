using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentCardDal:EfEntityRepositoryBase<PaymentCard,CarRentalDatabaseContext>,IPaymentCardDal
    {
    }
}
