using Microsoft.EntityFrameworkCore;
using ProjectRent.Core;
using ProjectRent.Core.Dtos;
using ProjectRent.Core.IReposiytories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Dal
{
    public class OSRepository : IOSRepository
    {
        private DataContext _context;
        public OSRepository(DataContext context)
        {
            _context = context;
        }
        // методы взаимодействия с данными - добавить, изменить, удалить, вернуть
        public int Add(OfficeStateDto officeState)
        {
            if (officeState == null)
            {
                throw new ArgumentNullException("officeState");
            }
            else if (officeState == null || officeState.OfficeState.Trim().Length == 0)
            {
                throw new ArgumentException("None OfficeState!");
            }

            _context.OfficeState.Add(officeState);
            _context.SaveChanges();

            return officeState.Id;
        }
        public OfficeStateDto GetById(int Id)
        {
            var result = _context.OfficeState.FirstOrDefault(g => g.Id == Id);

            if (result == null)
            {
                throw new ArgumentException("Статуса офиса с таким ID нет");
            }
            return result;
        }

        public void DeleteGetById(int Id)
        {
            var crnt = GetById(Id);
            _context.OfficeState.Remove(crnt);
            _context.SaveChanges();
        }

        public List<OfficeStateDto> GetAll()
        {

            var result = _context.OfficeState.ToList();
            return result;

            throw new NotImplementedException();
        }
        public void Update(OfficeStateDto officeState)
        {
            var crnt = GetById(officeState.Id);
            crnt.OfficeState = officeState.OfficeState;

            _context.SaveChanges();
        }
    }
}
