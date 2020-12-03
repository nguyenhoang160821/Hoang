using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Nguyen Van Hoang",
                        Gender = "Nam",
                        Salary = 16082001
                    },
                     new Product
                     {
                         Name = "Nguyen Ngoc TRung Hiêu",
                         Gender = "Nam",
                         Salary = 12345
                     },
                     new Product
                     {
                         Name = "Nguyen Van Tuan",
                         Gender = "Nam",
                         Salary = 2000
                     },
                      new Product
                      {
                          Name = "Nguyen Van Chinh",
                          Gender = "Nam",
                          Salary = 1000
                      },
                      new Product
                      {
                          Name = "Nguyen Van Hoang",
                          Gender = "Nam",
                          Salary = 7000
                      },
                      new Product
                      {
                          Name = "Nguyen Van Quan",
                          Gender = "Nu",
                          Salary = 1500
                      }
                    );
                context.SaveChanges();
            }
        }
    }

}

