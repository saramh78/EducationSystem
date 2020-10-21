using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.ModelBuilders
{
    public static class CourseModelBuilder
    {
        public static void CourseSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course 
                { 
                    Id=1, 
                    CategoryId=7, 
                    Name="C#"
                },
                new Course
                {
                    Id=2,
                    CategoryId=7,
                    Name="Android"
                },
                new Course
                {
                    Id=3,
                    CategoryId=7,
                    Name="Flutter"
                },
                new Course
                {
                    Id=4,
                    CategoryId=6,
                    Name="c++"
                }
                );
        }
    }
}
