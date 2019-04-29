
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISubjectService : IDisposable
    {
        Task<ICollection<Subject>> GetAsync();
        Task SaveAsync(Subject obj);
        Task DeleteAsync(int id);
        Subject GetById(int id);
        PagedResult<Subject> GetPaged(int currentPage, int onPage);
    }
}
