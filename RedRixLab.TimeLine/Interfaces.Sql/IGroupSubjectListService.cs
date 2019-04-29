
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IGroupSubjectListService : IDisposable
    {
        Task<ICollection<GroupSubjectList>> GetAsync();
        Task SaveAsync(GroupSubjectList obj);
        Task DeleteAsync(int id);
        GroupSubjectList GetById(int id);
        PagedResult<GroupSubjectList> GetPaged(int currentPage, int onPage);
    }
}
