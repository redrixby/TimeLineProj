
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IWorkersService : IDisposable
    {
        Task<ICollection<Workers>> GetAsync();
        Task SaveAsync(Workers obj);
        Task DeleteAsync(int id);
        Workers GetById(int id);
        PagedResult<Workers> GetPaged(int currentPage, int onPage);
    }
}
