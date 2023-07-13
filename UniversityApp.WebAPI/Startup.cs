using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using UniversityApp.BL.Abstract;
using UniversityApp.BL.Services;
using UniversityApp.DAL.Abstract;
using UniversityApp.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using UniversityApp.DAL.Models;

namespace UniversityApp.WebAPI
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
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IPdfGenerationService, PdfGenerationService>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddDbContext<UniveristyContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnectionString")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "UniversityApp.WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UniversityApp.WebAPI v1"));
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
