
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IReasonService : IDisposable
    {
        Task<ICollection<Reason>> GetAsync();
        Task SaveAsync(Reason obj);
        Task DeleteAsync(int id);
        Reason GetById(int id);
        PagedResult<Reason> GetPaged(int currentPage, int onPage);
    }
}
