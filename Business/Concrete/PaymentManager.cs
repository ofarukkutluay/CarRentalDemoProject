using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PaymentManager:IPaymentService
    {
        public IResult IsPaymentSuccess(PaymentCard paymentCard)
        {
            if (paymentCard!=null)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }
    }
}
