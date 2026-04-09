using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.Dtos
{
    public class BusinessCenterDto
    {
        public int Id { get; set; }

        public string? Address { get; set; }

        //public bool? IsDeleted { get; set; }

        public string? NameBusinessCenter { get; set; }

        public string? PhotoBusinessCenter { get; set; }

        // в одном бизнес-центре много офисов
        public List<OfficeDto> Office { get; set; } = new List<OfficeDto>();

        // пользователи выбирают нужные им бизнес-центры
        public List<UserDto> User { get; set; } = new List<UserDto>(); 
    }
}

