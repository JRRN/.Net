using System;
using Repository.Repositories;

namespace Repository
{
    public interface IUnitOfWork
    {
        void Save();
    }
}