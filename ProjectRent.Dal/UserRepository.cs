using Microsoft.EntityFrameworkCore;
using ProjectRent.Core;
using ProjectRent.Core.Dtos;
using ProjectRent.Core.IReposiytories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Dal
{
    public class UserRepository : IUserRepository
    {
        private DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        // методы взаимодействия с данными - добавить, изменить, удалить, вернуть
        public int Add(UserDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            else if (user == null || user.NameUser.Trim().Length == 0)
            {
                throw new ArgumentException("None Name!");
            }

            _context.User.Add(user);
            _context.SaveChanges();

            return user.Id;
        }
        public UserDto GetById(int Id)
        {
            var result = _context.User.FirstOrDefault(g => g.Id == Id);

            if (result == null)
            {
                throw new ArgumentException("Пользователя с таким ID нет");
            }
            return result;
        }
        public void DeleteGetById(int Id)
        {
            var crnt = GetById(Id);
            _context.User.Remove(crnt);
            _context.SaveChanges();
        }
        public List<UserDto> GetAll()
        {

            var result = _context.User.ToList();
            return result;

            throw new NotImplementedException();
        }
        public void Update(UserDto user)
        {
            var crnt = GetById(user.Id);
            crnt.NameUser = user.NameUser;

            _context.SaveChanges();
        }
    }
}
