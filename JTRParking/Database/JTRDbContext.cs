using BarcodeStandard;
using JTRParking.Classes;
using JTRParking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JTRParking.Database
{
    public class JTRDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Parking> Parkings { get; set; }

        public JTRDbContext() { }
        public JTRDbContext(DbContextOptions<JTRDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Admin", Username = "admin", Password = "admin", Role = User.UserRole.ADMIN },
                new User { Id = 2, Name = "Employee IN", Username = "employeein", Password = "employeein", Role = User.UserRole.EMPLOYEE_IN },
                new User { Id = 3, Name = "Employee OUT", Username = "employeeout", Password = "employeeout", Role = User.UserRole.EMPLOYEE_OUT }
            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting { Id = 1, Key = "first_hour_rate", Value = "50" },
                new Setting { Id = 2, Key = "hourly_rate", Value = "20" },
                new Setting { Id = 3, Key = "currency_symbol", Value = "MAD" },
                new Setting { Id = 4, Key = "parking_ticket_header_title", Value = "JTR Parking" },
                new Setting { Id = 5, Key = "parking_ticket_header_sub_title", Value = "JTR Solutions" }

            );




            modelBuilder.Entity<Parking>().HasData(

                new Parking
                {
                    Id = 1,
                    VehicleType = "Car",
                    DriverName = "Hassan",
                    DriverMobile = "+15485949548",
                    Barcode = DateTime.Now.ToString("yyyyMMddHHmmss") + 1,
                    InTime = DateTime.Now,
                    Amount = 0,
                    Status = Models.Parking.ParkingStatus.PENDING,
                    CreatedBy = 1,
                    CreatedAt = DateTime.Now,
                },
                new Parking
                {
                    Id = 2,
                    VehicleType = "Motor",
                    DriverName = "Hassan",
                    DriverMobile = "+164598756",
                    Barcode = DateTime.Now.AddHours(5).ToString("yyyyMMddHHmmss") + 1,
                    InTime = DateTime.Now.AddHours(5),
                    Amount = 0,
                    Status = Models.Parking.ParkingStatus.PENDING,
                    CreatedBy = 1,
                    CreatedAt = DateTime.Now,
                });

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=jtr_parking;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
