using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //set olmayanlar constructor içinde set edilebilir constructor yapısıyla set etmesini istiyorum sadece 
        //do not repeat yourself 
        public Result(bool success, string message): this(success) // dizinin tek parametreli olan fonksiyonuna result kendisine getirir 
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
