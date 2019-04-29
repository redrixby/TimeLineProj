
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IRelativesAboutInfoService : IDisposable
    {
        Task<ICollection<RelativesAboutInfo>> GetAsync();
        Task SaveAsync(RelativesAboutInfo obj);
        Task DeleteAsync(int id);
        RelativesAboutInfo GetById(int id);
        PagedResult<RelativesAboutInfo> GetPaged(int currentPage, int onPage);
    }
}
