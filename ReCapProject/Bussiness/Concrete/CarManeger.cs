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
    public class CarManeger : ICarService
    {
        //Maneger da sadece ilgili entitynin dal loosing coupled olarak dahil edilir. Başka entity bağımlı hale getirilemez service i kullanılır.
        private ICarDal _carDal;

        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public IDataResult<List<Car>> GetAll()
        {
            var result = _carDal.GetAll();
            return new SuccessDataResult<List<Car>>(result,Messages.ProductsListed);
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Car> GetById(int carId)
        {
            var result = _carDal.Get(c => c.Id == carId);
            return new SuccessDataResult<Car>(result);
        }
    }
}
