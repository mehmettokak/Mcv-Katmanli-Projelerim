using CompanyWeb.BAL.Repositories;
using System;

namespace CompanyWeb.BAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
