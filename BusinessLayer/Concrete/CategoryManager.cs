using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public int CountCategory()
        {
            return categoryDal.GetListAll().Count();
        }

        public Category GetByID(int id)
        {
            return categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            categoryDal.Update(t);
        }
    }
}

