using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int carId); //Ürün detayları için kullanılıyor .

    }
}
