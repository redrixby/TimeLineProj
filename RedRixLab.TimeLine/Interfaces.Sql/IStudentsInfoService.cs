
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStudentsInfoService : IDisposable
    {
        Task<ICollection<StudentsInfo>> GetAsync();
        Task SaveAsync(StudentsInfo obj);
        Task DeleteAsync(int id);
        StudentsInfo GetById(int id);
        PagedResult<StudentsInfo> GetPaged(int currentPage, int onPage);
    }
}
