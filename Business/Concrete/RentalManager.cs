using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Core.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;
        

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
            
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Add(Rental entity)
        {

            //if (CheckCarReturnDate(entity.CarId).Success)
            //{
            //    _rentalDal.Add(entity);
            //    return new SuccessResult(Messages.RentalAdded);
            //}

            //return new ErrorResult();
            _rentalDal.Add(entity);
            return new SuccessResult(Messages.RentalAdded);

        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        private IResult CheckCarReturnDate(int carId)
        {
            var result = _rentalDal.Get(r => r.CarId == carId).ReturnDate;
            if (result!=null)
            {
                return new ErrorResult(Messages.RentalReturnDateInvalidError);
            }

            return new SuccessResult();
        }

    }
}
