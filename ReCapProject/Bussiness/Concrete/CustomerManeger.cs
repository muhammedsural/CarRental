using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Abstract;
using Core.Utilities;
using Entities;

namespace Bussiness.Concrete
{
    public class CustomerManeger:ICustomerService
    {
        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
