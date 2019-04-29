
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IWorkersInfoService : IDisposable
    {
        Task<ICollection<WorkersInfo>> GetAsync();
        Task SaveAsync(WorkersInfo obj);
        Task DeleteAsync(int id);
        WorkersInfo GetById(int id);
        PagedResult<WorkersInfo> GetPaged(int currentPage, int onPage);
    }
}
