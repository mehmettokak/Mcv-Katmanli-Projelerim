using CompanyWeb.BAL.Repositories;
using CompanyWeb.BAL.UnitOfWork;
using CompanyWeb.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.BAL.Provider
{
    public class DbProvider<T> : IRepository<T> where T : class
    {
        private IUnitOfWork _uow;
        private IRepository<T> _userRepository;
        CompanyWebContext _db;

        public DbProvider()
        {
            _db = new CompanyWebContext();
            _uow = new EFUnitOfWork(_db);
            _userRepository = _uow.GetRepository<T>();
            
        }

        public IQueryable<T> GetAll()
        {
            return _userRepository.GetAll();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _userRepository.GetAll(predicate);
        }
        
        public T GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _userRepository.Get(predicate);
        }

        public void Add(T entity)
        {
            _userRepository.Add(entity);
        }

        public void Update(T entity)
        {
            _userRepository.Update(entity);
        }

        public void Delete(T entity)
        {
            _userRepository.Delete(entity);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public int SaveChanges()
        {
            return _uow.SaveChanges();
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
