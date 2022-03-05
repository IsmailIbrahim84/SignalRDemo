using Microsoft.AspNetCore.Builder;
using SignalRDemo.HubConfig;

namespace SignalRDemo
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("AllowAllHeaders");

            app.UseEndpoints(endPointOptions =>
            {
                endPointOptions.MapControllers();
                endPointOptions.MapHub<MyHub>("/toaster");
            });

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.AddSignalR(options =>
            {
                options.EnableDetailedErrors=true;
            });

            services.AddControllers();
        }

    }
}
