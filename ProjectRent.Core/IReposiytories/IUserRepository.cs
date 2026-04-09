using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.IReposiytories
{
    public interface IUserRepository
    {
        public int Add(UserDto user);

        public List<UserDto> GetAll();

        public UserDto GetById(int Id);

        public void Update(UserDto user);

        public void DeleteGetById(int Id);
    }
}
