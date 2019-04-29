
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStudyTypeService : IDisposable
    {
        Task<ICollection<StudyType>> GetAsync();
        Task SaveAsync(StudyType obj);
        Task DeleteAsync(int id);
        StudyType GetById(int id);
        PagedResult<StudyType> GetPaged(int currentPage, int onPage);
    }
}
