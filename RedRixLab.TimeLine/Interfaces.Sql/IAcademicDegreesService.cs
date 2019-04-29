using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IAcademicDegreesService : IDisposable
    {
        Task<ICollection<AcademicDegree>> GetAsync();
        Task SaveAsync(AcademicDegree obj);
        Task DeleteAsync(int id);
        AcademicDegree GetById(int id);
        PagedResult<AcademicDegree> GetPaged(int currentPage, int onPage);
    }
}
