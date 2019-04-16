using Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.Sql.Interfaces
{
    public interface ITimeLineContext : IDbContext
    {
        DbSet<FormOfEducation> FormsOfEducation { get; set; }
    }
}
