using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;

namespace Bussiness.Concrete
{
    public class CarManeger : ICarService
    {
        private ICarDal _carDal;

        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}
