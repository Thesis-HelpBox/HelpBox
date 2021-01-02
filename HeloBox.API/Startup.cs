using HelpBox.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HelpBox.Core.Repositories;
using HelpBox.Core.Service;
using HelpBox.Data.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpBox.Data.Repositories;
using HelpBox.Data;
using Microsoft.EntityFrameworkCore;
using HelpBox.Core.UnitOfWork;

namespace HeloBox.API
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
            //IRepository ile ilgili iþlemler için Repository tipinde nesne oluþtur.
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            //ICategoryService ile ilgili iþlemler için CategoryService tipinde nesne oluþturur. 
            //Generic olmadýðýndan böyle yazýlýr.
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<IProductionRequestRepository, ProductionRequestService>();
            //services.AddScoped<ICustomerService, CustomerService>();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConStr"].ToString(), o =>
                {
                    o.MigrationsAssembly("HelpBox.Data");
                });
            });

            //bir request yapýlýrken nesnenin constructor'ýnda IUnitOfWork ile karþýlaþýrsa
            //UnitOfWork'ten nesne örneði al.
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
