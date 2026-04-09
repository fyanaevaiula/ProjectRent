using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string? NameUser { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        // пользователь может выбрать много бизнес-центров
        public List<BusinessCenterDto> BusinessCenter { get; set; } = new List<BusinessCenterDto>();

        // пользователь может оформить несколько заявок
        public List<OrdersDto> Orders { get; set; } = new List<OrdersDto>();
    }
}
