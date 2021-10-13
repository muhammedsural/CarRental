using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities;

namespace Bussiness.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<Rental> GetById(int rentalId); //Ürün detayları için kullanılıyor .
    }
}
