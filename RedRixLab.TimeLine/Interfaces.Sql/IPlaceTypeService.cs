
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IPlaceTypeService : IDisposable
    {
        Task<ICollection<PlaceType>> GetAsync();
        Task SaveAsync(PlaceType obj);
        Task DeleteAsync(int id);
        PlaceType GetById(int id);
        PagedResult<PlaceType> GetPaged(int currentPage, int onPage);
    }
}
