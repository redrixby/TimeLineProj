
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ITeacherService : IDisposable
    {
        Task<ICollection<Teacher>> GetAsync();
        Task SaveAsync(Teacher obj);
        Task DeleteAsync(int id);
        Teacher GetById(int id);
        PagedResult<Teacher> GetPaged(int currentPage, int onPage);
    }
}
