using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IBenefitsService : IDisposable
    {
        Task<ICollection<Benefits>> GetAsync();
        Task SaveAsync(Benefits obj);
        Task DeleteAsync(int id);
        Benefits GetById(int id);
        PagedResult<Benefits> GetPaged(int currentPage, int onPage);
    }
}
