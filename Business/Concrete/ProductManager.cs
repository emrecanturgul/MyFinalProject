using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Concrete
{


   public class ProductManager : IProductService
    {
        IProductDal _productDal;  
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }

        public IResult Add(Product product)
        {   //core yazdıktan osnra her projede kullanbiliriz
            //bussiness codes  
            if (product.ProductName.Length < 2 )
            {   //magic string stringleri ayrı ayreı yazma 
                return new ErrorResult(Messages.ProductNameInvalid); 
            }


                    
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);//bunu yapabilmenin yöntemi constructor eklemektir
        }

        public IDataResult<List<Product>> GetAll()
        {    if(DateTime.Now.Hour == 22 )
            {
                return new ErrorDataResult(); 
            }
              return  new DataSuccessResult<List<Product>>(_productDal.GetAll(),true,"ürünler listelendi");
            //İş kodları  - Yetkisi var mı ? 
            //bir iş sınıfı başka bir sınıfı newlemez.
        }

       

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);    
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId); 

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min&&p.UnitPrice<=max); 
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
           return _productDal.GetProductDetails(); 

        }
    }
}
