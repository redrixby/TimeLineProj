
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IPlaceService : IDisposable
    {
        Task<ICollection<Place>> GetAsync();
        Task SaveAsync(Place obj);
        Task DeleteAsync(int id);
        Place GetById(int id);
        PagedResult<Place> GetPaged(int currentPage, int onPage);
    }
}
