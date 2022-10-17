using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class BlogCategory
    {

        public int BlogCategoryID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DetailContent { get; set; }
        public bool Status { get; set; }
        public string ThumbnailImage { get; set; }
        public string BlogCategoryImage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
