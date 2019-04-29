
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ICountryService : IDisposable
    {
        Task<ICollection<Country>> GetAsync();
        Task SaveAsync(Country obj);
        Task DeleteAsync(int id);
        Country GetById(int id);
        PagedResult<Country> GetPaged(int currentPage, int onPage);
    }
}
