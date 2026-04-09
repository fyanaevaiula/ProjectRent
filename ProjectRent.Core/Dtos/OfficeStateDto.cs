using ProjectRent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRent.Core.Dtos
{
    public class OfficeStateDto
    {
        public int Id { get; set; }

        public string? OfficeState { get; set; }

        // у одного состояния (занято/свободно) может быть много офисов
        public List<OfficeDto> Office { get; set; } = new List<OfficeDto>();
    }
}
