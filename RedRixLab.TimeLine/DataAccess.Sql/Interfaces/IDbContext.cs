using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace DataAccess.Sql.Interfaces
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();

        EntityEntry Entry(object entity);
    }
}
