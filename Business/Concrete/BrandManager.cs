using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka eklendi");
            }
            else
            {
                Console.WriteLine("Araba markası ismi en az iki karakter olmalıdır. Girdiğiniz değer:" + (brand.BrandName));
            }
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >=2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka başarıyla güncellendi");
            }
            else
            {
                Console.WriteLine("Araba markası ismi en az iki karakter olmalıdır. Girdiğiniz değer:" + (brand.BrandName));
            }
        }
    }
}
