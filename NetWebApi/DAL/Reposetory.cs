using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace NetWebApi.DAL
{
    public class Reposetory<T> : IReposetory<T> where T : class
    {
        private DbContext _context;
        public Reposetory(DbContext _context)
        {
            this._context = _context;
        }

        public T Add(T t)
        {
            return _context.Set<T>().Add(t);
        }


        public T Get(int Id)
        {
            return _context.Set<T>().Find(Id);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }


        public T Delete(int Id)
        {
            T t = _context.Set<T>().Find(Id);
            return _context.Set<T>().Remove(t);
        }


    }
}