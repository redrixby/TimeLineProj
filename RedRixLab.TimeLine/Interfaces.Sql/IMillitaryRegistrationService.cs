
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IMillitaryRegistrationService : IDisposable
    {
        Task<ICollection<MillitaryRegistration>> GetAsync();
        Task SaveAsync(MillitaryRegistration obj);
        Task DeleteAsync(int id);
        MillitaryRegistration GetById(int id);
        PagedResult<MillitaryRegistration> GetPaged(int currentPage, int onPage);
    }
}
