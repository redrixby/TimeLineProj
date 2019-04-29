
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IMaritalStatusService : IDisposable
    {
        Task<ICollection<MaritalStatus>> GetAsync();
        Task SaveAsync(MaritalStatus obj);
        Task DeleteAsync(int id);
        MaritalStatus GetById(int id);
        PagedResult<MaritalStatus> GetPaged(int currentPage, int onPage);
    }
}
