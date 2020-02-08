using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetWebApi.DAL
{
    public interface IReposetory<T> where T : class
    {
        T Add(T t);
        T Delete(int Id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Get(int Id);
        IEnumerable<T> GetAll();
    }
}