
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStreetService : IDisposable
    {
        Task<ICollection<Street>> GetAsync();
        Task SaveAsync(Street obj);
        Task DeleteAsync(int id);
        Street GetById(int id);
        PagedResult<Street> GetPaged(int currentPage, int onPage);
    }
}
