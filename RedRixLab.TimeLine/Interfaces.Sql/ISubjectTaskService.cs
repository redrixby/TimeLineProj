
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubjectTaskService : IDisposable
    {
        Task<ICollection<SubjectTask>> GetAsync();
        Task SaveAsync(SubjectTask obj);
        Task DeleteAsync(int id);
        SubjectTask GetById(int id);
        PagedResult<SubjectTask> GetPaged(int currentPage, int onPage);
    }
}
