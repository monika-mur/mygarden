using AutoMapper;
using Garden.Application.Commands.GardenKnowledge;
using Garden.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyGarden.Domain.GardenKnowledge.Plants;
using MyGarden.Infrastructure;
using MediatR;
using CommandBase;
using MyGarden.Web;
using Garden.Gateway;

namespace MyGarden
{
    public class Startup
    {
        private readonly string swaggerVersion = "v1";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(swaggerVersion, new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My Garden API", Version = swaggerVersion });
            });

            services.AddControllers();

            services.AddDbContext<GardenDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("MyGarden.Web")));

            var config = new MapperConfiguration(c => c.AddMaps(typeof(GardenMappingProfile).Assembly));
            services.AddSingleton(s => config.CreateMapper());

            services.AddTransient<IPlantKnowledgeRepository, PlantKnowledgeRepository>();

            services.AddMediatR(typeof(Startup));

            services.AddCommandQueryHandlers(typeof(IRequestHandler<,>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{swaggerVersion}/swagger.json", "My Garden API");
                c.RoutePrefix = string.Empty;
            });

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
