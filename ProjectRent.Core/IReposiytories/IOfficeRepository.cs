using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.IReposiytories
{
    public interface IOfficeRepository
    {
        public int Add(OfficeDto office);

        public List<OfficeDto> GetAll();

        public OfficeDto GetById(int Id);

        public void Update(OfficeDto office);

        public void DeleteGetById(int Id);
    }
}
