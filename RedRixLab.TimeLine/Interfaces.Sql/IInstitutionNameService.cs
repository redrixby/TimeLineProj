
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IInstitutionNameService : IDisposable
    {
        Task<ICollection<InstitutionName>> GetAsync();
        Task SaveAsync(InstitutionName obj);
        Task DeleteAsync(int id);
        InstitutionName GetById(int id);
        PagedResult<InstitutionName> GetPaged(int currentPage, int onPage);
    }
}
