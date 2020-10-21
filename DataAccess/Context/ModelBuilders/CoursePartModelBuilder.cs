using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.ModelBuilders
{
    public static class CoursePartModelBuilder
    {
        public static void CoursePartSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursePart>().HasData(
                new CoursePart
                {
                    Id=1,
                    CourseId=1,
                    Title="Get Started",
                    Order=1
                },
                new CoursePart
                {
                    Id=2,
                    CourseId=1,
                    Title="Types",
                    Order=2
                },
                new CoursePart
                {
                    Id=3,
                    CourseId=1,
                    Title="Classes"
                }
                );
        }
    }
}
