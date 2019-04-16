using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace Api.DataAccess.Sql.Interfaces
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();

        EntityEntry Entry(object entity);
    }
}
