
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubdivisionService : IDisposable
    {
        Task<ICollection<Subdivision>> GetAsync();
        Task SaveAsync(Subdivision obj);
        Task DeleteAsync(int id);
        Subdivision GetById(int id);
        PagedResult<Subdivision> GetPaged(int currentPage, int onPage);
    }
}
