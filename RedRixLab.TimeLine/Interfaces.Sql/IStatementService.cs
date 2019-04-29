
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStatementService : IDisposable
    {
        Task<ICollection<Statement>> GetAsync();
        Task SaveAsync(Statement obj);
        Task DeleteAsync(int id);
        Statement GetById(int id);
        PagedResult<Statement> GetPaged(int currentPage, int onPage);
    }
}
