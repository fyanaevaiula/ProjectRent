using Microsoft.EntityFrameworkCore;
using ProjectRent.Core;
using ProjectRent.Core.Dtos;
using ProjectRent.Core.IReposiytories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Dal
{
    public class OfficeRepository : IOfficeRepository
    {
        private DataContext _context;
        public OfficeRepository(DataContext context)
        {
            _context = context;
        }
        // методы взаимодействия с данными - добавить, изменить, удалить, вернуть
        public int Add(OfficeDto office)
        {
            if (office == null)
            {
                throw new ArgumentNullException("office");
            }
            else if (office == null || office.Square == 0)
            {
                throw new ArgumentException("None Square!");
            }

            _context.Office.Add(office);
            _context.SaveChanges();

            return office.Id;
        }
        public OfficeDto GetById(int Id)
        {
            var result = _context.Office.FirstOrDefault(g => g.Id == Id);

            if (result == null)
            {
                throw new ArgumentException("Офиса с таким ID нет");
            }
            return result;
        }
        public void DeleteGetById(int Id)
        {
            var crnt = GetById(Id);
            _context.Office.Remove(crnt);
            _context.SaveChanges();
        }
        public List<OfficeDto> GetAll()
        {

            var result = _context.Office.Include(g => g.OfficeState).ToList();
            return result;

            throw new NotImplementedException();
        }
        public void Update(OfficeDto office)
        {
            var crnt = GetById(office.Id);
            crnt.Square = office.Square;

            _context.SaveChanges();
        }
        public List<OfficeDto> GetByOffState(int OffSt)
        {
            var result = _context.Office
                .Include(g => g.OfficeState).ToList();
            return result;
        }
    }
}
