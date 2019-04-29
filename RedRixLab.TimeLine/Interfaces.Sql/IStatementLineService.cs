
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStatementLineService : IDisposable
    {
        Task<ICollection<StatementLine>> GetAsync();
        Task SaveAsync(StatementLine obj);
        Task DeleteAsync(int id);
        StatementLine GetById(int id);
        PagedResult<StatementLine> GetPaged(int currentPage, int onPage);
    }
}
