using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,DataContext>, ICarDal
    {
       //Dto methodları set edilecek DataContext temsili olarak yazıldı.


       public List<CarDetailDto> GetCarDetails()
       {
           using (DataContext contex = new DataContext())
           {
               var result = from c in contex.Cars join b in contex.Brands on c.BrandId equals b.Id 
                   select new CarDetailDto()
                   {
                       CarId = c.Id,
                       CarName = c.Description,
                       BrandName = b.BrandName,
                       ColorName = co.ColorName,
                       DailyPrice = c.DailyPrice
                   };
           }
       }
    }
}
