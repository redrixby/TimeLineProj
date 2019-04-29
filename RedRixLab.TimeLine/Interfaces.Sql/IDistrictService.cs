
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IDistrictService : IDisposable
    {
        Task<ICollection<District>> GetAsync();
        Task SaveAsync(District obj);
        Task DeleteAsync(int id);
        District GetById(int id);
        PagedResult<District> GetPaged(int currentPage, int onPage);
    }
}
