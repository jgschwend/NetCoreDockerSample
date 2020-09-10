using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Backend.DataAccess;
using Backend.Extension;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Backend
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        private NpgsqlConnectionStringBuilder DatabaseConnection { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var connection = Configuration.GetSection("Database").Get<DatabaseSettings>();
            DatabaseConnection = new NpgsqlConnectionStringBuilder
            {
                Database = connection.Database,
                Host = connection.Host,
                Port = connection.Port,
                Username = connection.Username,
                Password = connection.Password
            };
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<WeatherContext>(options => options.UseNpgsql(DatabaseConnection.ConnectionString));
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

            app.MigrateDatabase<WeatherContext>();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
