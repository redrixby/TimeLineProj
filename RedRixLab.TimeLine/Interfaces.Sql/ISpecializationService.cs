
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISpecializationService : IDisposable
    {
        Task<ICollection<Specialization>> GetAsync();
        Task SaveAsync(Specialization obj);
        Task DeleteAsync(int id);
        Specialization GetById(int id);
        PagedResult<Specialization> GetPaged(int currentPage, int onPage);
    }
}
