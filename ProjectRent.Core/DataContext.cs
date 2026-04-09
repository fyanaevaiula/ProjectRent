using Microsoft.EntityFrameworkCore;
using ProjectRent.Core.Dtos;

namespace ProjectRent.Core
{
    public class DataContext : DbContext
    {
        public DbSet<BusinessCenterDto> BusinessCenter { get; set; }

        public DbSet<OfficeDto> Office { get; set; }

        public DbSet<OfficeStateDto> OfficeState { get; set; }

        public DbSet<OrdersDto> Orders { get; set; }

        public DbSet<UserDto> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=Rent5;";
            optionsBuilder.UseNpgsql(connectionString);
        }

    }
}
