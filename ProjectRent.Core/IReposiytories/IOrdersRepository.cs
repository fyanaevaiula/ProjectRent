using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.IReposiytories
{
    public interface IOrdersRepository
    {
        public int Add(OrdersDto orders);

        public List<OrdersDto> GetAll();

        public OrdersDto GetById(int Id);

        public void Update(OrdersDto orders);

        public void DeleteGetById(int Id);
    }
}
