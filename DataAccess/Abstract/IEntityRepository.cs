using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Filtreleme yapmak için(GetAll'ın içi)
        T Get(Expression<Func<T, bool>> filter); //Tek bir şey filtreleme için
        void Add(T entity);
        void Uptade(T entity);
        void Delete(T entity);
    }
}
