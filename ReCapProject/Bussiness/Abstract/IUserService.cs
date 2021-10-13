using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities;
using Entities;

namespace Bussiness.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<User> GetById(int userId); //Ürün detayları için kullanılıyor .
    }
}
