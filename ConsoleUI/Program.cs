using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public  class Program
    {    
        static void Main(string[] args) {

            ProductManager productManager = new ProductManager(new EfProductDal());
            
        } 
    }
}
