
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IScientificTitleIPDService : IDisposable
    {
        Task<ICollection<ScientificTitleIPD>> GetAsync();
        Task SaveAsync(ScientificTitleIPD obj);
        Task DeleteAsync(int id);
        ScientificTitleIPD GetById(int id);
        PagedResult<ScientificTitleIPD> GetPaged(int currentPage, int onPage);
    }
}
