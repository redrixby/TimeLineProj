using System;
using System.IO;
using System.Reflection;
using Api.Services.Sql.Profiles;
using AutoMapper;
using DataAccess.Sql.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Sql.ConfigModels;
using Services.Sql.Extensions;
using Swashbuckle.AspNetCore.Swagger;
using Web.Api.Config;
using Web.Api.Profiles;

namespace Web.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private StartupOptions StartupOpts { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //Получаем настройки
            StartupOpts = new StartupOptions();
            var appSettings = Configuration.GetSection("AppSettings");
            StartupOpts.EnableSwagger = bool.Parse(
                appSettings.GetValue<string>("EnableSwagger") ?? "true"
            );
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<StartupOptions>(StartupOpts);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", builder =>
                {
                    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials();
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options =>
            {
                options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            services.Configure<AppConfig>(Configuration.GetSection("ApiConfig"));

            if (StartupOpts.EnableSwagger)
            {
                // Register the Swagger generator
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "API Doc", Version = "v1" });

                    // Set the comments path for the Swagger JSON and UI.
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    c.IncludeXmlComments(xmlPath);
                });
            }

            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<BusinessLogicProfile>();
                cfg.AddProfile<TimeLineProfile>();
            });

            services.ConfigureDataAccess(Configuration.GetConnectionString("RedRixLab.TimeLine"))
                    .ConfigureBusinessLogic();

            services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowAllOrigins");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (StartupOpts.EnableSwagger)
            {
                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();

                // Enable middleware to serve swagger-ui
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseMvc(routes =>
            {
                routes.MapRoute("api", "api/{controller}", new { controller = "Setting", action = "Index" });
            });

            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value) && !context.Request.Path.Value.Contains("api/"))
                {
                    context.Request.Path = "/index.html"; // Put your Angular root page here 
                    context.Response.StatusCode = 200; // Make sure we update the status code, otherwise it returns 404
                    await next();
                }
            });

            // Microsoft.AspNetCore.StaticFiles: API for starting the application from wwwroot.
            // Uses default files as index.html.
            app.UseDefaultFiles();
            // Uses static file for the current path.

            app.UseStaticFiles();
        }
    }
}
