using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult <T> :IResult  
    {     //interface interface i implement ederse zaten öbür interfaceden propertyleri alırım 

        T Data { get; } 

    }
}
