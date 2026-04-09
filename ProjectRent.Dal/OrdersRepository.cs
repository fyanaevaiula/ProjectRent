using Microsoft.EntityFrameworkCore;
using ProjectRent.Core;
using ProjectRent.Core.Dtos;
using ProjectRent.Core.IReposiytories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Dal
{
    public class OrdersRepository : IOrdersRepository
    {
        private DataContext _context;
        public OrdersRepository(DataContext context)
        {
            _context = context;
        }
        // методы взаимодействия с данными - добавить, изменить, удалить, вернуть
        public int Add(OrdersDto orders)
        {
            if (orders == null)
            {
                throw new ArgumentNullException("orders");
            }
            else if (orders == null )
            {
                throw new ArgumentException("None orders!");
            }

            _context.Orders.Add(orders);
            _context.SaveChanges();

            return orders.Id;
        }
        public OrdersDto GetById(int Id)
        {
            var result = _context.Orders.FirstOrDefault(g => g.Id == Id);

            if (result == null)
            {
                throw new ArgumentException("Заявки с таким ID нет");
            }
            return result;
        }

        public void DeleteGetById(int Id)
        {
            var crnt = GetById(Id);
            _context.Orders.Remove(crnt);
            _context.SaveChanges();
        }

        public List<OrdersDto> GetAll()
        {

            var result = _context.Orders.ToList();
            return result;

            throw new NotImplementedException();
        }
        public void Update(OrdersDto orders)
        {
            var crnt = GetById(orders.Id);
            crnt.DateTimeOrders = orders.DateTimeOrders;

            _context.SaveChanges();
        }
    }
}
