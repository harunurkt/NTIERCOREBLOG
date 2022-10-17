using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class MenuSubCategory
    {
        [Key]
        public int MenuSubCategoryID { get; set; }
        public int MenuCategoryID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DetailContent { get; set; }
        public bool Status { get; set; }
        public string PicturePath { get; set; }
        public bool IsLink { get; set; }
        public string LinkUrl { get; set; }
        public bool LinkOut { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyword { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
        public List<MenuCategory> MenuCategories { get; set; }
    }
}
