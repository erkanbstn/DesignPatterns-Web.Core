using Repository.BusinessLayer.Abstract;
using Repository.DataAccessLayer.Abstract;
using Repository.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.BusinessLayer.Concrete
{
    public class ProductManager : IGenericService<Product>
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _ProductDal = ProductDal;
        }

        public void TDelete(Product entity)
        {
            _ProductDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _ProductDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _ProductDal.GetById(id);
        }

        public void TInsert(Product entity)
        {
            _ProductDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _ProductDal.Update(entity);
        }
    }
}
