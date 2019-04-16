using Api.Interfaces.Sql;
using Microsoft.Extensions.DependencyInjection;
using Api.Models.Sql;

namespace Api.Services.Sql.Extensions
{
    public static class BusinessLogicExtension
    {
        /// <summary>
        /// Configures services for BusinessLogic
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureBusinessLogic(this IServiceCollection services)
        {
            services.AddTransient<IFormOfEducationService<FormOfEducation>, FormOfEducationService>();

            return services;
        }
    }
}
