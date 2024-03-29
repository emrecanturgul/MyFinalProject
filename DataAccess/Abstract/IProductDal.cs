﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
