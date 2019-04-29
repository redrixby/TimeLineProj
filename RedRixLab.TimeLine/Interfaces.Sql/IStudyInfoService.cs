
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStudyInfoService : IDisposable
    {
        Task<ICollection<StudyInfo>> GetAsync();
        Task SaveAsync(StudyInfo obj);
        Task DeleteAsync(int id);
        StudyInfo GetById(int id);
        PagedResult<StudyInfo> GetPaged(int currentPage, int onPage);
    }
}
