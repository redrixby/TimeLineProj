
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IGroupService : IDisposable
    {
        Task<ICollection<Group>> GetAsync();
        Task SaveAsync(Group obj);
        Task DeleteAsync(int id);
        Group GetById(int id);
        PagedResult<Group> GetPaged(int currentPage, int onPage);
    }
}
