
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IGenderService : IDisposable
    {
        Task<ICollection<Gender>> GetAsync();
        Task SaveAsync(Gender obj);
        Task DeleteAsync(int id);
        Gender GetById(int id);
        PagedResult<Gender> GetPaged(int currentPage, int onPage);
    }
}
