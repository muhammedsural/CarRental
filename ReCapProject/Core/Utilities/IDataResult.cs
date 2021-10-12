using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    //Geriye mesaj ve başarı bilgisi dışında data döndürmek isteyen işler için.
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
