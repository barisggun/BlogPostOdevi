﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        Context context = new Context();
        public void Create(TEntity entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> ListAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
