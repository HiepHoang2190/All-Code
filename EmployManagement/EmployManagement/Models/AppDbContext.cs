using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagement.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                 new Employee()
                 {
                     AvatarPatch = "images/img_avatar1.png",
                     Department = Dept.IT,
                     Email = "hoangbachhiep2190@gmail.com",
                     Name = "hoangbachhiep",
                     Id = 1,
                     //Key=Guid.Parse("09002689-ebdf-4548-ab56-2549f482e12a")

                 },
                new Employee()
                {
                    AvatarPatch = "images/img_avatar5.png",
                    Department = Dept.HR,
                    Email = "lequangvu11@gmail.com",
                    Name = "lequangvu23",
                    Id = 2,

                },
                 new Employee()
                 {
                     AvatarPatch = "images/img_avatar5.png",
                     Department = Dept.Payroll,
                     Email = "lequangvu11@gmail.com",
                     Name = "lequangvu23",
                     Id = 3
                 },
                  new Employee()
                  {
                      AvatarPatch = "images/img_avatar5.png",
                      Department = Dept.Sale,
                      Email = "lequangvu11@gmail.com",
                      Name = "lequangvu23",
                      Id = 4
                  }

                );
        }

        //public DbSet<Product> products { get; set; }
    }
}
