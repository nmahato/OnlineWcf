using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATS.WCF.Data.Interface;
using ATS.WCF.Data.Models;

namespace ATS.WCF.Data.Repository
{
   public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
       private readonly OnlineDBContext context;
        private IDbSet<T> entities;

       public GenericRepository()
        {
        this.context = new OnlineDBContext();
        }
        public GenericRepository(OnlineDBContext _context)
        {
        this.context = _context;
        }
       
        public virtual IQueryable<T> GetAll()
        {
           
                IQueryable<T> query = context.Set<T>();
        return query;
            
        }

        public virtual IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }
    }
}
