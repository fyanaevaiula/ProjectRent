using ProjectRent.Core;
using ProjectRent.Core.Dtos;
using ProjectRent.Core.IReposiytories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Dal
{
    public class BCRepository : IBCRepository
    {
        private DataContext _context;
        public BCRepository(DataContext context)
        {
            _context = context;
        }
        // методы взаимодействия с данными - добавить, изменить, удалить, вернуть
        public int Add(BusinessCenterDto business)
        {
            if (business == null) 
            {
                throw new ArgumentNullException("business");
            }
            // Trim - могут стоять пробелы
            else if(business.Address == null || business.Address.Trim().Length == 0)
            { 
                throw new ArgumentException("None Address!");
            }

            //business.IsDeleted = false;

            _context.BusinessCenter.Add(business);
            _context.SaveChanges();
            
            return business.Id;
        }
        public BusinessCenterDto GetById(int Id)
        {
            // OrDefault - если ничего не нашли, то вернем null
            // First() - возвращает первый найденный элемент
            // FirstOrDefault() используем если ищем что-то одно
            // Single() - проверяет, что найденный элемент один. Если больше одного - ошибка
            // SingleOrDefault() - чаще используют First(), потому что он безопаснее
            // Where.ToList()  если ищем офисы в БЦ
            var result = _context.BusinessCenter.FirstOrDefault(g => g.Id == Id);

            if (result == null)
            {
                throw new ArgumentException("Бизнес-центра с таким ID нет");
            }
            return result;
        }

        public void DeleteGetById(int Id)
        {
            var crnt = GetById(Id);
            _context.BusinessCenter.Remove(crnt);
            _context.SaveChanges();
        }
        
        //public void SoftDeleteById(int id)
        //{
        //    var crnt = GetById(id);
        //    crnt.IsDeleted = true;

        //    _context.SaveChanges();
        //}
        public List<BusinessCenterDto> GetAll()
        {

            var result = _context.BusinessCenter.ToList();
            // фильтр на удаленные бизнес-центры
            //var result = _context.BusinessCenter.Where(g=>!(bool)g.IsDeleted).ToList();
            return result;

            throw new NotImplementedException();
        }
        public void Update(BusinessCenterDto business)
        {
            var crnt = GetById(business.Id);
            crnt.Address = business.Address;

            _context.SaveChanges();
            
            // _context.Groups.Update(group); Неоптимально - сссылка на ссылку, может быть ошибка
        }
    }
}
