
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IEducationTypeService : IDisposable
    {
        Task<ICollection<EducationType>> GetAsync();
        Task SaveAsync(EducationType obj);
        Task DeleteAsync(int id);
        EducationType GetById(int id);
        PagedResult<EducationType> GetPaged(int currentPage, int onPage);
    }
}
