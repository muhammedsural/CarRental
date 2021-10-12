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
        IDataResult<List<Car>> GetAllByCategoryId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IResult Add(Car product);
        IDataResult<Car> GetById(int productId); //Ürün detayları için kullanılıyor .

    }
}
