
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IInstitutionTypeService : IDisposable
    {
        Task<ICollection<InstitutionType>> GetAsync();
        Task SaveAsync(InstitutionType obj);
        Task DeleteAsync(int id);
        InstitutionType GetById(int id);
        PagedResult<InstitutionType> GetPaged(int currentPage, int onPage);
    }
}
