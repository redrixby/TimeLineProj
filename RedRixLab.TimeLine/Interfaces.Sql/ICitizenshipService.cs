using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ICitizenshipService : IDisposable
    {
        Task<ICollection<Citizenship>> GetAsync();
        Task SaveAsync(Citizenship obj);
        Task DeleteAsync(int id);
        Citizenship GetById(int id);
        PagedResult<Citizenship> GetPaged(int currentPage, int onPage);
    }
}
