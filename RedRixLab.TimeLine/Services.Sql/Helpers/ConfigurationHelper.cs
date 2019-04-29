using Microsoft.Extensions.Configuration;
using System.IO;

namespace Services.Sql.Helpers
{
    public static class ConfigurationHelper
    {
        private static IConfigurationRoot Config => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
    }
}
