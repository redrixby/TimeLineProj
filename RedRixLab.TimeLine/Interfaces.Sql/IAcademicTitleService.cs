using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IAcademicTitleService : IDisposable
    {
        Task<ICollection<AcademicTitle>> GetAsync();
        Task SaveAsync(AcademicTitle obj);
        Task DeleteAsync(int id);
        AcademicTitle GetById(int id);
        PagedResult<AcademicTitle> GetPaged(int currentPage, int onPage);
    }
}
