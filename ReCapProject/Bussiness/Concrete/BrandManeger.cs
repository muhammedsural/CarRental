using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;

namespace Bussiness.Concrete
{
    public class BrandManeger : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManeger(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result,Messages.ProductsListed);
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var result = _brandDal.Get(c => c.Id == brandId);
            return new SuccessDataResult<Brand>(result);
        }
    }
}
