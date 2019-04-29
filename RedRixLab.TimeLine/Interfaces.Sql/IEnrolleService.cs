
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IEnrolleService : IDisposable
    {
        Task<ICollection<Enrolle>> GetAsync();
        Task SaveAsync(Enrolle obj);
        Task DeleteAsync(int id);
        Enrolle GetById(int id);
        PagedResult<Enrolle> GetPaged(int currentPage, int onPage);
    }
}
