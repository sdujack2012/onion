using Domain.Entities;
using System;

namespace ServiceInterfaces
{
    public interface IUserService
    {
        User GetUserById(int id);
        void DeleteUSer(int id);
        void UpdateUSer(User user);
        void AddUser(User user);
    }
}
