﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IGenericDal<Blog>
    {
        //public void AddBlog(Blog blog)
        //{
        //    using var c = new EfContext();
        //    c.Add(blog);
        //    c.SaveChanges();
        //}

        //public void DeleteBlog(Blog blog)
        //{
        //    using var c = new EfContext();
        //    c.Remove(blog);
        //    c.SaveChanges();
        //}

        //public Blog GetById(int id)
        //{
        //    using var c = new EfContext();
        //    return c.Blogs.Find(id);
        //}

        //public List<Blog> ListAllBlog()
        //{
        //    using var c = new EfContext();
        //    return c.Blogs.ToList();
        //}

        //public void UpdateBlog(Blog blog)
        //{
        //    using var c = new EfContext();
        //    c.Update(blog);
        //    c.SaveChanges();
        //}
        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}
