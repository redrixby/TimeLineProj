
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStudyFormService : IDisposable
    {
        Task<ICollection<StudyForm>> GetAsync();
        Task SaveAsync(StudyForm obj);
        Task DeleteAsync(int id);
        StudyForm GetById(int id);
        PagedResult<StudyForm> GetPaged(int currentPage, int onPage);
    }
}
