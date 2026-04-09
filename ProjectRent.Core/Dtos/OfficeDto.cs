using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.Dtos
{
    public class OfficeDto
    {
        public int Id { get; set; }

        public double? Square { get; set; }

        public int? Floor { get; set; }

        public double? RentalRate { get; set; }

        public string? PhotoOffice { get; set; }

        // офис относится к одному бизнес-центру
        public BusinessCenterDto? BusinessCenter { get; set; }

        // офис может принимать только одного состояние (занято/свободно)
        public OfficeStateDto? OfficeState { get; set; }

        // офис может попасть в разные заявки, а договор на аренду заключен с одним арендатором
        public List<OrdersDto> Orders { get; set; } = new List<OrdersDto>();
    }
}
