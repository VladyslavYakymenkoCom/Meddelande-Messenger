using Mapster;
using ME.Api.Extensions;
using ME.Business.Logic.Scopes.Chats;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ME.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //TODO: Config Mapster for preserving references, ignore nulls;
            TypeAdapterConfig.GlobalSettings.Scan(typeof(ChatMapsterRegister).Assembly);
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Init(Configuration);

            services.AddDatabase(); 
            services.AddRepositories(); 
            services.AddUnitOfWork();
            services.AddScopes();  
            services.AddControllers();
        }

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
