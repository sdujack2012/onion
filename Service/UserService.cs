using Domain.Entities;
using Domain.Interfaces;
using ServiceInterfaces;
using System;

namespace Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }

        public void DeleteUSer(int id)
        {
            _userRepository.Delete(id);
        }

        public User GetUserById( int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateUSer(User user)
        {
            _userRepository.Update(user);
        }
    }
}
