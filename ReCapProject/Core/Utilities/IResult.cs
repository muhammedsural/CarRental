using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IResult
    {
        //Void kodlar için yazılmıştır
        bool Success { get; }
        string Message { get; }
    }
}
