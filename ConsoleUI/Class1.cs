using Business.Concrete;
using Microsoft.EntityFrameworkCore;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{    
    //solid (o) open closed principle
    //yeni bir özellik istiyorsak mevcut kodlara dokunamayız
    

    class Program 
    { 
        static void Main(string[] args)
         {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //Console.WriteLine("product.ProductName");
            foreach (var product in productManager.GetByUnitPrice(6,90))
            {
               Console.WriteLine(product.ProductName); 
            }    
         }

    }
}