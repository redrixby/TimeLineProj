
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IScientificSpecialityService : IDisposable
    {
        Task<ICollection<ScientificSpeciality>> GetAsync();
        Task SaveAsync(ScientificSpeciality obj);
        Task DeleteAsync(int id);
        ScientificSpeciality GetById(int id);
        PagedResult<ScientificSpeciality> GetPaged(int currentPage, int onPage);
    }
}
