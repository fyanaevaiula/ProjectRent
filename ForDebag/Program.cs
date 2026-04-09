using Microsoft.EntityFrameworkCore;
using ProjectRent.Core;
using ProjectRent.Core.Dtos;
using ProjectRent.Dal;
using Npgsql;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace ForDebag
{
    public class Program
    {
        static void Main(string[] args)
        {
            // !!! Вариант 1 добавления данных !!!
            //DataContext dataContext = new DataContext();
            //dataContext.Database.EnsureCreated();

            // добавление нового бизнес-центра
            //BusinessCenterDto BC1 = new BusinessCenterDto() { Id = 1, NameBusinessCenter = "Арт-Плаза", Address = "Х.Давлетшиной, д.9" }; //IsDeleted = false
            //BusinessCenterDto BC2 = new BusinessCenterDto() { Id = 2, NameBusinessCenter = "Империал", Address = "Аксакова, д.18" }; //IsDeleted = false
            //BusinessCenterDto BC3 = new BusinessCenterDto() { Id = 3, NameBusinessCenter = "Статус", Address = "8 Марта, д.34" }; //IsDeleted = false 

            //OfficeDto Office1 = new OfficeDto() { Id = 1, Square = 15, Floor = 1, RentalRate = 1200 };
            //OfficeDto Office2 = new OfficeDto() { Id = 2, Square = 8.7, Floor = 2, RentalRate = 1250 };
            //OfficeDto Office3 = new OfficeDto() { Id = 3, Square = 12.3, Floor = 3, RentalRate = 1300 };
            //OfficeDto Office4 = new OfficeDto() { Id = 4, Square = 16.1, Floor = 4, RentalRate = 1270 };
            //OfficeDto Office5 = new OfficeDto() { Id = 5, Square = 14.8, Floor = 5, RentalRate = 1285 };
            //OfficeDto Office6 = new OfficeDto() { Id = 6, Square = 20.1, Floor = 1, RentalRate = 1300 };

            //UserDto User1 = new UserDto() { Id = 1, NameUser = "Иванов", Email = "sert@mail.ru", Phone = "8-961-200-20-00" };
            //UserDto User2 = new UserDto() { Id = 2, NameUser = "Петров", Email = "dart@yandex.ru", Phone = "8-965-764-35-21" };

            //OrdersDto Orders1 = new OrdersDto() { Id = 1, DateTimeOrders = new DateOnly(2026, 3, 21) };
            //OrdersDto Orders2 = new OrdersDto() { Id = 2, DateTimeOrders = new DateOnly(2026, 3, 31) };

            //OfficeStateDto OffS1 = new OfficeStateDto() { Id = 1, OfficeState = "Занято" };
            //OfficeStateDto OffS2 = new OfficeStateDto() { Id = 2, OfficeState = "Свободно" };

            //BC1.Office.Add(Office1);
            //BC1.Office.Add(Office2);
            //BC1.Office.Add(Office3);
            //BC2.Office.Add(Office4);
            //BC3.Office.Add(Office5);
            //BC3.Office.Add(Office6);

            //BC1.User.Add(User1);
            //BC2.User.Add(User2);
            //BC3.User.Add(User1);

            //Orders1.Office.Add(Office1);
            //Orders1.Office.Add(Office2);
            //Orders1.Office.Add(Office3);
            //Orders2.Office.Add(Office4);
            //Orders2.Office.Add(Office5);
            //Orders2.Office.Add(Office6);

            //User1.Orders.Add(Orders1);
            //User2.Orders.Add(Orders2);

            //OffS1.Office.Add(Office1);
            //OffS1.Office.Add(Office5);
            //OffS2.Office.Add(Office2);
            //OffS2.Office.Add(Office3);
            //OffS2.Office.Add(Office4);
            //OffS2.Office.Add(Office6);

            //dataContext.BusinessCenter.Add(BC1);
            //dataContext.BusinessCenter.Add(BC2);
            //dataContext.BusinessCenter.Add(BC3);
            //dataContext.Office.Add(Office1);
            //dataContext.Office.Add(Office2);
            //dataContext.Office.Add(Office3);
            //dataContext.Office.Add(Office4);
            //dataContext.Office.Add(Office5);
            //dataContext.Office.Add(Office6);
            //dataContext.User.Add(User1);
            //dataContext.User.Add(User2);
            //dataContext.Orders.Add(Orders1);
            //dataContext.Orders.Add(Orders2);
            //dataContext.OfficeState.Add(OffS1);
            //dataContext.OfficeState.Add(OffS2);

            ////dataContext.BusinessCenter.Add(new ProjectRent.Core.Dtos.BusinessCenterDto() { Id = 1, NameBusinessCenter = "Арт-Плаза", Address = "Х.Давлетшиной, д.9"  }); //IsDeleted = false
            ////dataContext.BusinessCenter.Add(new ProjectRent.Core.Dtos.BusinessCenterDto() { Id = 2, NameBusinessCenter = "Империал", Address = "Аксакова, д.18"  }); //IsDeleted = false
            ////dataContext.BusinessCenter.Add(new ProjectRent.Core.Dtos.BusinessCenterDto() { Id = 3, NameBusinessCenter = "Статус", Address = "8 Марта, д.34" }); //IsDeleted = false 

            ////dataContext.Office.Add(new ProjectRent.Core.Dtos.OfficeDto() { Id = 1, Square = 15, Floor = 1, RentalRate = 1200 });
            ////dataContext.Office.Add(new ProjectRent.Core.Dtos.OfficeDto() { Id = 2, Square = 8.7, Floor = 2, RentalRate = 1250 });
            ////dataContext.Office.Add(new ProjectRent.Core.Dtos.OfficeDto() { Id = 3, Square = 12.3, Floor = 3, RentalRate = 1300 });
            ////dataContext.Office.Add(new ProjectRent.Core.Dtos.OfficeDto() { Id = 4, Square = 16.1, Floor = 4, RentalRate = 1270 });
            ////dataContext.Office.Add(new ProjectRent.Core.Dtos.OfficeDto() { Id = 5, Square = 14.8, Floor = 5, RentalRate = 1285 });
            ////dataContext.Office.Add(new ProjectRent.Core.Dtos.OfficeDto() { Id = 6, Square = 20.1, Floor = 1, RentalRate = 1300 });

            ////dataContext.OfficeState.Add(new ProjectRent.Core.Dtos.OfficeStateDto() { Id = 1, OfficeState = "Занято" });
            ////dataContext.OfficeState.Add(new ProjectRent.Core.Dtos.OfficeStateDto() { Id = 2, OfficeState = "Свободно" });

            ////dataContext.Orders.Add(new ProjectRent.Core.Dtos.OrdersDto() { Id = 1, DateTimeOrders = new DateOnly(2026, 3, 21) }); 
            ////dataContext.Orders.Add(new ProjectRent.Core.Dtos.OrdersDto() { Id = 2, DateTimeOrders = new DateOnly(2026, 3, 31) });

            ////dataContext.User.Add(new ProjectRent.Core.Dtos.UserDto() { Id = 1, NameUser = "Иванов", Email = "sert@mail.ru", Phone = "8-961-200-20-00" });
            ////dataContext.User.Add(new ProjectRent.Core.Dtos.UserDto() { Id = 2, NameUser = "Петров", Email = "dart@yandex.ru", Phone = "8-965-764-35-21" });

            // сохранение изменений
            //dataContext.SaveChanges();

            // просмотр списка бизнес-центров
            //var i = dataContext.BusinessCenter.ToList();

            // !!! Вариант 2 добавления данных !!!
            DataContext dataContext = new DataContext();
            dataContext.Database.EnsureCreated();

            // добавление нового бизнес-центра
            BusinessCenterDto BC1 = new BusinessCenterDto() { Id = 1, NameBusinessCenter = "Арт-Плаза", Address = "Х.Давлетшиной, д.9" }; //IsDeleted = false
            BusinessCenterDto BC2 = new BusinessCenterDto() { Id = 2, NameBusinessCenter = "Империал", Address = "Аксакова, д.18" }; //IsDeleted = false
            BusinessCenterDto BC3 = new BusinessCenterDto() { Id = 3, NameBusinessCenter = "Статус", Address = "8 Марта, д.34" }; //IsDeleted = false 

            OfficeDto Office1 = new OfficeDto() { Id = 1, Square = 15, Floor = 1, RentalRate = 1200 };
            OfficeDto Office2 = new OfficeDto() { Id = 2, Square = 8.7, Floor = 2, RentalRate = 1250 };
            OfficeDto Office3 = new OfficeDto() { Id = 3, Square = 12.3, Floor = 3, RentalRate = 1300 };
            OfficeDto Office4 = new OfficeDto() { Id = 4, Square = 16.1, Floor = 4, RentalRate = 1270 };
            OfficeDto Office5 = new OfficeDto() { Id = 5, Square = 14.8, Floor = 5, RentalRate = 1285 };
            OfficeDto Office6 = new OfficeDto() { Id = 6, Square = 20.1, Floor = 1, RentalRate = 1300 };

            UserDto User1 = new UserDto() { Id = 1, NameUser = "Иванов", Email = "sert@mail.ru", Phone = "8-961-200-20-00" };
            UserDto User2 = new UserDto() { Id = 2, NameUser = "Петров", Email = "dart@yandex.ru", Phone = "8-965-764-35-21" };

            OrdersDto Orders1 = new OrdersDto() { Id = 1, DateTimeOrders = new DateOnly(2026, 3, 21) };
            OrdersDto Orders2 = new OrdersDto() { Id = 2, DateTimeOrders = new DateOnly(2026, 3, 31) };

            OfficeStateDto OffS1 = new OfficeStateDto() { Id = 1, OfficeState = "Занято" };
            OfficeStateDto OffS2 = new OfficeStateDto() { Id = 2, OfficeState = "Свободно" };

            BC1.Office.Add(Office1);
            BC1.Office.Add(Office2);
            BC1.Office.Add(Office3);
            BC2.Office.Add(Office4);
            BC3.Office.Add(Office5);
            BC3.Office.Add(Office6);

            BC1.User.Add(User1);
            BC2.User.Add(User2);
            BC3.User.Add(User1);

            Orders1.Office.Add(Office1);
            Orders1.Office.Add(Office2);
            Orders1.Office.Add(Office3);
            Orders2.Office.Add(Office4);
            Orders2.Office.Add(Office5);
            Orders2.Office.Add(Office6);

            User1.Orders.Add(Orders1);
            User2.Orders.Add(Orders2);

            OffS1.Office.Add(Office1);
            OffS1.Office.Add(Office5);
            OffS2.Office.Add(Office2);
            OffS2.Office.Add(Office3);
            OffS2.Office.Add(Office4);
            OffS2.Office.Add(Office6);

            dataContext.BusinessCenter.Add(BC1);
            dataContext.BusinessCenter.Add(BC2);
            dataContext.BusinessCenter.Add(BC3);
            dataContext.Office.Add(Office1);
            dataContext.Office.Add(Office2);
            dataContext.Office.Add(Office3);
            dataContext.Office.Add(Office4);
            dataContext.Office.Add(Office5);
            dataContext.Office.Add(Office6);
            dataContext.User.Add(User1);
            dataContext.User.Add(User2);
            dataContext.Orders.Add(Orders1);
            dataContext.Orders.Add(Orders2);
            dataContext.OfficeState.Add(OffS1);
            dataContext.OfficeState.Add(OffS2);

            BCRepository repository1 = new BCRepository(dataContext);
            OfficeRepository repository2 = new OfficeRepository(dataContext);
            OSRepository repository3 = new OSRepository(dataContext);
            OrdersRepository repository4 = new OrdersRepository(dataContext);
            UserRepository repository5 = new UserRepository(dataContext);

            repository1.Add(BC1);
            repository1.Add(BC2);
            repository1.Add(BC3);
            repository2.Add(Office1);
            repository2.Add(Office2);
            repository2.Add(Office3);
            repository2.Add(Office4);
            repository2.Add(Office5);
            repository2.Add(Office6);
            repository3.Add(OffS1);
            repository3.Add(OffS2);
            repository4.Add(Orders1);
            repository4.Add(Orders2);
            repository5.Add(User1);
            repository5.Add(User2);

            //var BC1 = repository1.Add(new BusinessCenterDto() { Id = 1, NameBusinessCenter = "Арт-Плаза", Address = "Х.Давлетшиной, д.9" });
            //var BC2 = repository1.Add(new BusinessCenterDto() { Id = 2, NameBusinessCenter = "Империал", Address = "Аксакова, д.18" });
            //var BC3 = repository1.Add(new BusinessCenterDto() { Id = 3, NameBusinessCenter = "Статус", Address = "8 Марта, д.34" });

            //var Office1 = repository2.Add(new OfficeDto() { Id = 1, Square = 15, Floor = 1, RentalRate = 1200 });
            //var Office2 = repository2.Add(new OfficeDto() { Id = 2, Square = 8.7, Floor = 2, RentalRate = 1250 });
            //var Office3 = repository2.Add(new OfficeDto() { Id = 3, Square = 12.3, Floor = 3, RentalRate = 1300 });
            //var Office4 = repository2.Add(new OfficeDto() { Id = 4, Square = 16.1, Floor = 4, RentalRate = 1270 });
            //var Office5 = repository2.Add(new OfficeDto() { Id = 5, Square = 14.8, Floor = 5, RentalRate = 1285 });
            //var Office6 = repository2.Add(new OfficeDto() { Id = 6, Square = 20.1, Floor = 1, RentalRate = 1300 });

            //var OffS1 = repository3.Add(new OfficeStateDto() { Id = 1, OfficeState = "Занято" });
            //var OffS2 = repository3.Add(new OfficeStateDto() { Id = 2, OfficeState = "Свободно" });

            //var Orders1 = repository4.Add(new OrdersDto() { Id = 1, DateTimeOrders = new DateOnly(2026, 3, 21) });
            //var Orders2 = repository4.Add(new OrdersDto() { Id = 2, DateTimeOrders = new DateOnly(2026, 3, 31) });

            //var User1 = repository5.Add(new UserDto() { Id = 1, NameUser = "Иванов", Email = "sert@mail.ru", Phone = "8-961-200-20-00" });
            //var User2 = repository5.Add(new UserDto() { Id = 2, NameUser = "Петров", Email = "dart@yandex.ru", Phone = "8-965-764-35-21" });

            var a = repository1.GetAll();
            var b = repository2.GetAll();
            var c = repository3.GetAll();
            var d = repository4.GetAll();
            var e = repository5.GetAll();
        }
    }
}
