using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>();
        public void Add(User user)
        {
            users.Add(user);
        }

        public void Delete(int id)
        {
            users.RemoveAll(user => user.Id == id);
        }

        public User GetById(int id)
        {
            return users.First(user => user.Id == id);
        }

        public void Update(User user)
        {
            users.RemoveAll(existingUser => user.Id == existingUser.Id);
            users.Add(user);
        }
    }
}
