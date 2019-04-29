
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ILocallityTypeService : IDisposable
    {
        Task<ICollection<LocallityType>> GetAsync();
        Task SaveAsync(LocallityType obj);
        Task DeleteAsync(int id);
        LocallityType GetById(int id);
        PagedResult<LocallityType> GetPaged(int currentPage, int onPage);
    }
}
