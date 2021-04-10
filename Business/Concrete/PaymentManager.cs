using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PaymentManager:IPaymentService
    {
        private IPaymentCardDal _paymentCardDal;

        public PaymentManager(IPaymentCardDal paymentCardDal)
        {
            _paymentCardDal = paymentCardDal;
        }
        public IResult IsPaymentSuccess(PaymentCard paymentCard)
        {
            if (paymentCard!=null)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public IDataResult<PaymentCard> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<PaymentCard>(_paymentCardDal.Get(p => p.CustomerId == customerId));
        }

        public IDataResult<List<PaymentCard>> GetAll()
        {
            return new SuccessDataResult<List<PaymentCard>>(_paymentCardDal.GetAll());
        }

        public IResult Add(PaymentCard entity)
        {
            _paymentCardDal.Add(entity);
            return new SuccessResult();
        }

        public IDataResult<PaymentCard> GetById(int id)
        {
            return new SuccessDataResult<PaymentCard>(_paymentCardDal.Get(p => p.Id == id));
        }

        public IResult Update(PaymentCard entity)
        {
            _paymentCardDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(PaymentCard entity)
        {
            _paymentCardDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
