using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }

        public List<Blog> GetLast3Blog()
        {
            return blogDal.GetListAll().TakeLast(3).ToList(); // Son 3 postu getir
        }

        public Blog GetByID(int id)
        {
            return blogDal.GetByID(id);
        }

        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return blogDal.GetListWithCategoryByWriter(id);
        }

        public Blog GetBlogByID(int id)
        {
            return blogDal.Get(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return blogDal.GetListAll();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return blogDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            t.BlogStatus = true;
            t.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blogDal.Update(t);
        }

        public int CountBlogs()
        {
           return blogDal.GetListAll().Count();
        }

        public int CountBlogsByWriter(int id)
        {
            return blogDal.GetCountBlogWithWriter(1);
        }
    }
}
