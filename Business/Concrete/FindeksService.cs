using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FindeksService:IFindeksService
    {
        public IDataResult<int> WhatFindeksScore(int customerId)
        {
            if (customerId != 0)
            {
                return new SuccessDataResult<int>(1900);
            }

            return new ErrorDataResult<int>(0);
        }
    }
}
