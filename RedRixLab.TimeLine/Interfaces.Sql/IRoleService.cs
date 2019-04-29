
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IRoleService : IDisposable
    {
        Task<ICollection<Role>> GetAsync();
        Task SaveAsync(Role obj);
        Task DeleteAsync(int id);
        Role GetById(int id);
        PagedResult<Role> GetPaged(int currentPage, int onPage);
    }
}
