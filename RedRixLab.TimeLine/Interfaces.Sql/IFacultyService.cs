
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IFacultyService : IDisposable
    {
        Task<ICollection<Faculty>> GetAsync();
        Task SaveAsync(Faculty obj);
        Task DeleteAsync(int id);
        Faculty GetById(int id);
        PagedResult<Faculty> GetPaged(int currentPage, int onPage);
    }
}
