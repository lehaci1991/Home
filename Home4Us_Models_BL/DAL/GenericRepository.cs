using Home4Us_Models;
using Home4Us_Models.Models;
using Home4Us_Models_Interface;
using System;
using System.Data.Entity;
using System.Linq;

namespace Home4Us_Models_BL.BSL
{
    public class GenericRepository<T> : IRepository<T> where T : BaseClassID
    {
        protected readonly DbContext Context;
        protected GenericRepository(DbContext context)
        {
            Context = context;
        }

        public DbSet<T> Entity { get; set; }

        public T Create(T entity)
        {
            var result = Entity.Add(entity);
            return result;
        }

        public void Delete(T entity)
        {
             Entity.Remove(entity);
        }

        public T Read(int id)
        {
           var result =  Entity.FirstOrDefault(x =>x.ID == id);
           return result;
        }

        public T Update(T entity)
        {
            var result = Entity.Attach(entity);
            return result;
        }
    }
}
