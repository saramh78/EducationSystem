using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataAccess.Model;
using DataAccess.Context;
using DataAccess.Repositories.Class;
using DataAccess.Repositories.Interface;
using EducationSystem.Services.Interface;
using EducationSystem.Services.Class;

namespace EducationSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

           var connectionString = Configuration.GetConnectionString("EducationSystemConnectionStringSara");

           services.AddDbContext<EducationSystemContext>(options => options.UseSqlServer(connectionString));

            //Repositories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICoursePartRepository, CoursePartRepository>();
            services.AddScoped<ICoursePartArticleRepository, CoursePartArticleRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ILinkRepository, LinkRepository>();

            //Services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICoursePartService, CoursePartService>();
            services.AddScoped<ICoursePartArticleService, CoursePartArticleService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ILinkService, LinkService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
