using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context.ModelBuilders
{
    public static class CategoryModelBuilder
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category 
                { 
                    Id = 1, 
                    Name = "Computer" 
                },
                new Category 
                { 
                    Id = 2, 
                    ParentId = 1, 
                    Name = "Programming" 
                },
                    new Category 
                    { 
                        Id = 5, ParentId = 2, 
                        Name = "Concepts" 
                    },
                    new Category 
                    { 
                        Id = 6, ParentId = 2,
                        Name = "Web" 
                    },
                    new Category 
                    { 
                        Id = 7, ParentId = 2, 
                        Name = "Application" 
                    },
                new Category 
                { 
                    Id=3,
                    ParentId = 3, 
                    Name = "DataBase" 
                },
                new Category 
                {
                    Id=4,
                    ParentId = 4, 
                    Name = "Network" 
                }
                );
        }
    }
}
