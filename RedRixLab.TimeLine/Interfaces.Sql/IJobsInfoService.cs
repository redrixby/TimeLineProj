
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IJobsInfoService : IDisposable
    {
        Task<ICollection<JobsInfo>> GetAsync();
        Task SaveAsync(JobsInfo obj);
        Task DeleteAsync(int id);
        JobsInfo GetById(int id);
        PagedResult<JobsInfo> GetPaged(int currentPage, int onPage);
    }
}
