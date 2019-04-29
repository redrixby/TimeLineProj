
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISpecialityInfoForEnrolleService : IDisposable
    {
        Task<ICollection<SpecialityInfoForEnrolle>> GetAsync();
        Task SaveAsync(SpecialityInfoForEnrolle obj);
        Task DeleteAsync(int id);
        SpecialityInfoForEnrolle GetById(int id);
        PagedResult<SpecialityInfoForEnrolle> GetPaged(int currentPage, int onPage);
    }
}
