using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Abstract
{
    //where koşulunda T nin clas türünden olmasını ve veri tabanı tablosu olmasını sağlıyoruz
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(Expression<Func<T, bool>> filter);
    }
}
