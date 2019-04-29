using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ICityService : IDisposable
    {
        Task<ICollection<City>> GetAsync();
        Task SaveAsync(City obj);
        Task DeleteAsync(int id);
        City GetById(int id);
        PagedResult<City> GetPaged(int currentPage, int onPage);
    }
}
