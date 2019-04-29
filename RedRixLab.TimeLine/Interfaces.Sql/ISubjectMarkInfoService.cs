
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubjectMarkInfoService : IDisposable
    {
        Task<ICollection<SubjectMarkInfo>> GetAsync();
        Task SaveAsync(SubjectMarkInfo obj);
        Task DeleteAsync(int id);
        SubjectMarkInfo GetById(int id);
        PagedResult<SubjectMarkInfo> GetPaged(int currentPage, int onPage);
    }
}
