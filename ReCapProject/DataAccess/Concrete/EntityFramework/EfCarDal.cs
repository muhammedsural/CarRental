using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,DataContext>, ICarDal
    {
       //Dto methodları set edilecek DataContext temsili olarak yazıldı.
    }
}
