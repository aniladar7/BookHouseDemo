using BookHouse.Business.Repository.Abstract;
using BookHouse.DataAccess.Concrete;
using BookHouse.DataAccess.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.Business.Repository.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        BookHouseContext context = new BookHouseContext();

        public void Add(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
