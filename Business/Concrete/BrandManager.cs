using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length>2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka kayıt edildi");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }
    }
}
