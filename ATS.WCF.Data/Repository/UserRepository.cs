using System;
using System.Linq;
using ATS.WCF.Data.Models;
using ATS.WCF.Data.Interface;

namespace ATS.WCF.Data.Repository
{
  public  class UserRepository:GenericRepository<User>,IUserRepository
    {
        public IQueryable<User> GetAll()
        {
            return base.GetAll();
        }

        public IQueryable<User> FindBy(System.Linq.Expressions.Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(User entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
