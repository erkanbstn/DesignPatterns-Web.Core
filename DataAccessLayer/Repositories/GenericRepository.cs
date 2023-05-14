using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }
        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _context.Set<T>().Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.Set<T>().UpdateRange(t);
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
        }
    }
}
