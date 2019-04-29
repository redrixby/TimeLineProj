using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ICentralizedTestingService : IDisposable
    {
        Task<ICollection<CentralizedTesting>> GetAsync();
        Task SaveAsync(CentralizedTesting obj);
        Task DeleteAsync(int id);
        CentralizedTesting GetById(int id);
        PagedResult<CentralizedTesting> GetPaged(int currentPage, int onPage);
    }
}
