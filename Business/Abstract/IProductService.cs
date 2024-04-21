using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {   //SOLID ı kullanmayacağın bir şeyi yazma
        IDataResult <List<Product>>GetAll();// bir product listesi döndürür //burda IResult 

        IDataResult<List<Product>>GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDTO>> GetProductDetails();

        IResult Add(Product product);
        IDataResult<List<Product>> GetById(int productId); 


    }
}
