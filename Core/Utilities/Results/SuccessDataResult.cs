﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult <T> :DataResult<T>
    {
         public SuccessDataResult(T data , string message) : base(data,true,message)
        {
            
        }
        public SuccessDataResult(T data) : base(data,true)
        {     
            
        }
        public SuccessDataResult(string message) : base(default,true,message)
        {    
                 //default demek  dataya karşılık geliyor 
                 
                 
        }
        public SuccessDataResult() : base(default,true)
        { 
                
        }

    }
}
