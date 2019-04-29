
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubjectInfoService : IDisposable
    {
        Task<ICollection<SubjectInfo>> GetAsync();
        Task SaveAsync(SubjectInfo obj);
        Task DeleteAsync(int id);
        SubjectInfo GetById(int id);
        PagedResult<SubjectInfo> GetPaged(int currentPage, int onPage);
    }
}
