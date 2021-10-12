using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal :EfEntityRepositoryBase<Brand, DataContext>,IBrandDal
    {
    }
}
