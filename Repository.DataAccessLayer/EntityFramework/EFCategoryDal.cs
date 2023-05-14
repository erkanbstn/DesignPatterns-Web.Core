using Repository.DataAccessLayer.Abstract;
using Repository.DataAccessLayer.Concrete;
using Repository.DataAccessLayer.Repositories;
using Repository.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EFCategoryDal(Context context) : base(context)
        {
        }
    }
}
