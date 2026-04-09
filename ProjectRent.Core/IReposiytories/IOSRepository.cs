using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.IReposiytories
{
    public interface IOSRepository
    {
        public int Add(OfficeStateDto officeState);

        public List<OfficeStateDto> GetAll();

        public OfficeStateDto GetById(int Id);

        public void Update(OfficeStateDto officeState);

        public void DeleteGetById(int Id);
    }
}
