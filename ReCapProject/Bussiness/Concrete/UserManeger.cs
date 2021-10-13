using System;
using System.Collections.Generic;
using System.Text;
using Bussiness.Abstract;
using Core.Utilities;
using Entities;

namespace Bussiness.Concrete
{
    public class UserManeger : IUserService
    {
        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Add(User user)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
