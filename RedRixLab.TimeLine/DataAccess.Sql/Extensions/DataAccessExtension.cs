using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Api.DataAccess.Sql.Contexts;
using Api.DataAccess.Sql.Interfaces;
using Api.DataAccess.Models;
using System;

namespace Api.DataAccess.Sql.Extensions
{
    public static class DataAccessExtensions
    {
        /// <summary>
        /// Configures services for DataAccess assembly
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString">database connection string</param>
        /// <returns></returns>
        public static IServiceCollection ConfigureDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IContextFactory, ContextFactory>();
            services.AddTransient<ITimeLineContext, TimeLineContext>();

            services.AddDbContext<TimeLineContext>(
                options => options.UseSqlServer(connectionString));

            services.AddEntityFrameworkSqlServer();

            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<TimeLineContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(150);
                options.LoginPath = "/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                options.LogoutPath = "/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Account/AccessDenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = true;
            });

            return services;
        }
    }
}
