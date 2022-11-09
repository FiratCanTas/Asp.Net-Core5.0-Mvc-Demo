using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {   
        Context _db = new Context();
        public void Delete(T t)
        {
          _db.Remove(t);
          _db.SaveChanges();
            
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _db.Add(t);
            _db.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
           return _db.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            _db.Update(t);
            _db.SaveChanges();
        }
    }
}
