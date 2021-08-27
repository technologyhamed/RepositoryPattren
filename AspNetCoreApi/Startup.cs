using AspNetCoreApi.Controllers;
using AspNetCoreApi.DBContext;
using AspNetCoreApi.FileRepository;
using AspNetCoreApi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreApi
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
            services.AddDbContextPool<WebApiContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();


            services.AddScoped<EfCoreRepositoryUser>();

            services.AddScoped<EfCoreRepositoryUserRole>();
            services.AddTransient<IFileService,FileRepository.FileRepository>();

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

                endpoints.MapControllerRoute(
                     name: "User",
                       pattern: "{controller}/{action}/{id?}",
                     defaults: new { action = "GetTask" });

                endpoints.MapControllerRoute(
                     name: "File",
                       pattern: "{controller}/{action}/{id?}",
                     defaults: new { action = "Upload" });
                // endpoints.MapControllerRoute(
                //     name: "api",
                //     pattern: "{controller}/{id?}");

            });
        }
    }
}
