using System;

namespace Api.DataAccess.Sql.Interfaces
{
    public interface IContextFactory : IDisposable
    {
        ITimeLineContext GetTimeLineContext();
    }
}
