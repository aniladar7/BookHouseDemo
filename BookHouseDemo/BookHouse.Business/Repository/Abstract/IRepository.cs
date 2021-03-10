using BookHouse.DataAccess.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.Business.Repository.Abstract
{
    public interface IRepository<T> where T:class,IEntity
    {
        List<T> GetList();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
