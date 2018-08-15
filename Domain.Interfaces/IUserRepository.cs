using Domain.Entities;
using System;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);
        void Add(User user);
        void Delete(int id);
        void Update(User user);
    }
}
