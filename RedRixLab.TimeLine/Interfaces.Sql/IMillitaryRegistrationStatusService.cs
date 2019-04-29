
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IMillitaryRegistrationStatusService : IDisposable
    {
        Task<ICollection<MillitaryRegistrationStatus>> GetAsync();
        Task SaveAsync(MillitaryRegistrationStatus obj);
        Task DeleteAsync(int id);
        MillitaryRegistrationStatus GetById(int id);
        PagedResult<MillitaryRegistrationStatus> GetPaged(int currentPage, int onPage);
    }
}
