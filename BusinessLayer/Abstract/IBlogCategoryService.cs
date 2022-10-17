using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IBlogCategoryService
    {
        void BlogCategoryAdd(BlogCategory clogCategory);
        void BlogCategoryDelete(BlogCategory clogCategory);
        void BlogCategoryUpdate(BlogCategory clogCategory);
        List<BlogCategory> GetList();
        BlogCategory GetById(int id);
    }
}
