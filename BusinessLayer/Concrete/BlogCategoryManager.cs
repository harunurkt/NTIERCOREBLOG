using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework.EfBlogCategoryRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogCategoryManager : IBlogCategoryService
    {
        EfBlogCategoryRepository efBlogCategoryRepository;

        public BlogCategoryManager()
        {
            efBlogCategoryRepository = new EfBlogCategoryRepository();
        }
        public void BlogCategoryAdd(BlogCategory blogCategory)
        {
            efBlogCategoryRepository.Insert(blogCategory);
        }

        public void BlogCategoryDelete(BlogCategory blogCategory)
        {
            efBlogCategoryRepository.Delete(blogCategory);
        }

        public void BlogCategoryUpdate(BlogCategory blogCategory)
        {
            efBlogCategoryRepository.Update(blogCategory);
        }

        public BlogCategory GetById(int id)
        {
            return efBlogCategoryRepository.GetById(id);
        }

        public List<BlogCategory> GetList()
        {
            return efBlogCategoryRepository.GetListAll();
        }
    }
}
