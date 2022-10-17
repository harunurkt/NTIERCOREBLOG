using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
   public class EfContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HARUN-PC\\SQLEXPRESS;database=CoreBlogDb;trusted_connection=true; integrated security=true");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<MenuSubCategory> MenuSubCategories { get; set; }
        public DbSet<About> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Writer> Writers { get; set; }



    }
}
