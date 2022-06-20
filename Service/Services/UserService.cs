using Domain.Dtos;
using Domain.Entities;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        protected bool ValidateUser(UserDto userDto)
        {
            if (userDto == null) { return false; }
            if(string.IsNullOrEmpty(userDto.UserName)) { return false; }
            if(string.IsNullOrEmpty(userDto.Password)) { return false; }
            if(string.IsNullOrEmpty(userDto.Email)) { return false; }
            if(string.IsNullOrEmpty(userDto.Role)) { return false; }
            return true;
        }

        public bool CreateUser(UserDto userDto)
        {
            User user = new User(); 
            if (!ValidateUser(userDto)) { return false; }
            try
            {
                user.UserName = userDto.UserName;
                user.PasswordHash = userDto.Password;
                user.Email = userDto.Email;
                user.DateOfCreation = DateTime.Now;
                _userRepository.Persist(user);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateUser(UserDto userDto)
        {
            User user = new User();
            if (!ValidateUser(userDto)) { return false; }
            try
            {
                user.UserName = userDto.UserName;
                user.PasswordHash = userDto.Password;
                user.Email = userDto.Email;
                _userRepository.Update(user);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
