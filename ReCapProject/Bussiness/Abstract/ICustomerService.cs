using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<Customer> GetById(int customerId); //Ürün detayları için kullanılıyor .
    }
}
