using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Api.DataAccess.Sql.Interfaces;
using Api.DataAccess.Models;
using Api.DataAccess.Sql.Maps;

namespace Api.DataAccess.Sql.Contexts
{
    public class TimeLineContext : IdentityDbContext<User, Role, int>, ITimeLineContext
    {
        public TimeLineContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(FormOfEducationMap.Instance);

            base.OnModelCreating(builder);
        }

        public DbSet<FormOfEducation> FormsOfEducation { get; set; }
    }
}
