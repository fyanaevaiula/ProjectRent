using Microsoft.EntityFrameworkCore.Update.Internal;
using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.IReposiytories
{
    public interface IBCRepository
    {
        public int Add(BusinessCenterDto business);

        public List<BusinessCenterDto> GetAll();

        public BusinessCenterDto GetById(int Id);

        public void Update(BusinessCenterDto business);

        public void DeleteGetById(int Id);
    }
}
