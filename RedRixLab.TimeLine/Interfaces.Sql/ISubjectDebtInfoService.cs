
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubjectDebtInfoService : IDisposable
    {
        Task<ICollection<SubjectDebtInfo>> GetAsync();
        Task SaveAsync(SubjectDebtInfo obj);
        Task DeleteAsync(int id);
        SubjectDebtInfo GetById(int id);
        PagedResult<SubjectDebtInfo> GetPaged(int currentPage, int onPage);
    }
}
