using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //where to write product-related data access codes
        List<Product> _products;
        //bellekten ref alınca çalışacak blok 
        public InMemoryProductDal()
        {    //oracle,sql Server,Postgres,MongoDb'den geliyormuş gibi simüle edildi 
            _products = new List<Product>() {
                new Product{ProductId=1,CategoryId = 1, ProductName = "Bardak",UnitPrice= 15 ,UnitsInStock = 15 },
                new Product{ProductId=2,CategoryId = 1, ProductName = "Kamera",UnitPrice= 500 ,UnitsInStock = 3 },
                new Product{ProductId=3,CategoryId = 2, ProductName = "Telefon",UnitPrice= 1500 ,UnitsInStock =2 },
                new Product{ProductId=4,CategoryId = 2, ProductName = "Klavye",UnitPrice= 150 ,UnitsInStock = 65 },
                new Product{ProductId=5,CategoryId = 2, ProductName = "Fare",UnitPrice= 85 ,UnitsInStock = 1 }
            }; 


        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {     
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId );
            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //veri tabanındaki datayı business'a vermek zorundayız
            return _products; 

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();//yazdığın şartları yeni tablo olarak ekler 


        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {   //gönderdiğim ürün id'sine sahip olan ürün id'sine sahip ürünü bul 

            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice; 
            productToUpdate.UnitsInStock = product.UnitsInStock; 


        }
    }
}
