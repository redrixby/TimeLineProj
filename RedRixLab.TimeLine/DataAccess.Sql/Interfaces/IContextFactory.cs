using System;

namespace DataAccess.Sql.Interfaces
{
    public interface IContextFactory : IDisposable
    {
        ITimeLineContext GetTimeLineContext();
    }
}
