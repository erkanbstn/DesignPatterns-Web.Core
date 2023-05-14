using Microsoft.EntityFrameworkCore.Query.Internal;
using Repository.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        T TGetById(int id);
        List<T> TGetAll();
    }
}
