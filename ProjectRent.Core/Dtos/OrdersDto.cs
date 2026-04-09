using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.Dtos
{
    public class OrdersDto
    {
        public int Id { get; set; }

        public DateOnly? DateTimeOrders { get; set; }

        // в одной заявке может быть много офисов
        public List<OfficeDto> Office { get; set; } = new List<OfficeDto>();

        // в заявке может быть указан только один пользователь
        public UserDto? User { get; set; }
    }
}
