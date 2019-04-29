
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IRegionService : IDisposable
    {
        Task<ICollection<Region>> GetAsync();
        Task SaveAsync(Region obj);
        Task DeleteAsync(int id);
        Region GetById(int id);
        PagedResult<Region> GetPaged(int currentPage, int onPage);
    }
}
