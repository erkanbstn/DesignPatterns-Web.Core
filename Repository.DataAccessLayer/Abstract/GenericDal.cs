using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DataAccessLayer.Abstract
{
    public interface GenericDal<T> where T: class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
