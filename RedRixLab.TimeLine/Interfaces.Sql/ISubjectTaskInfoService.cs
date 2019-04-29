
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubjectTaskInfoService : IDisposable
    {
        Task<ICollection<SubjectTaskInfo>> GetAsync();
        Task SaveAsync(SubjectTaskInfo obj);
        Task DeleteAsync(int id);
        SubjectTaskInfo GetById(int id);
        PagedResult<SubjectTaskInfo> GetPaged(int currentPage, int onPage);
    }
}
