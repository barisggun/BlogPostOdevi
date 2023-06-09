﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Create(Blog blog)
        {
            _blogDal.Create(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog Get(int id)
        {
            return _blogDal.Get(id);
        }

        public List<Blog> ListAll()
        {
            return _blogDal.ListAll();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
