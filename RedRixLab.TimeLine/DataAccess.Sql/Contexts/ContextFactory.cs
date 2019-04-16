using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Api.DataAccess.Sql.Interfaces;

namespace Api.DataAccess.Sql.Contexts
{
    public class ContextFactory : IContextFactory
    {
        private readonly IConfiguration _configuration;

        public ContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ITimeLineContext GetTimeLineContext()
        {

            var dbOptionsBuilder = new DbContextOptionsBuilder();
            dbOptionsBuilder.UseSqlServer(_configuration.GetConnectionString("RedRixLab.TimeLine"));

            return new TimeLineContext(dbOptionsBuilder.Options);
        }

        public void Dispose()
        {
        }
    }
}
