using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Concrete.EntityFramework
{   //NuGet 
    //orm sql tablolarını class gibi gösteren bir framework 

    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        //IProductDal içerisinde sadece ürüne ait özel operasyonlar koymamızı sağlar
        //ürün ve katgoriye join atmak gibi Iproductdal a dto koyarsak sadece productlar ile meşgul oluruz
        public List<ProductDetailDTO> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {   
               

                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetailDTO
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock


                             };
                return result.ToList();


            }
        }
    }
}