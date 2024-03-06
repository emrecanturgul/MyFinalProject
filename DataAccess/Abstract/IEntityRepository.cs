using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{    
    //class : referans tip olmamız laızm 
    //int ref tip değil
    //herhangi bir class yazamasın 
    //new lenebilri olmalı  IEntity new lenemez 
    
    public interface IEntityRepository<T> where T : class , IEntity ,new()
    {   
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //tüm datayı da getirebilir filtreleyerek de getirebilir 
        T Get(Expression<Func<T,bool>> filter); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
