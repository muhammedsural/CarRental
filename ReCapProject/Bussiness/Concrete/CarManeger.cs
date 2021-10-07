using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Abstract;
using DataAccess.Abstract;

namespace Bussiness.Concrete
{
    public class CarManeger : ICarService
    {
        private ICarDal _carDal;

        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }
    }
}
