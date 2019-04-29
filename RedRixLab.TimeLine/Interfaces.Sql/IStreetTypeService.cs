
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStreetTypeService : IDisposable
    {
        Task<ICollection<StreetType>> GetAsync();
        Task SaveAsync(StreetType obj);
        Task DeleteAsync(int id);
        StreetType GetById(int id);
        PagedResult<StreetType> GetPaged(int currentPage, int onPage);
    }
}
