
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IEntranceExamService : IDisposable
    {
        Task<ICollection<EntranceExam>> GetAsync();
        Task SaveAsync(EntranceExam obj);
        Task DeleteAsync(int id);
        EntranceExam GetById(int id);
        PagedResult<EntranceExam> GetPaged(int currentPage, int onPage);
    }
}
