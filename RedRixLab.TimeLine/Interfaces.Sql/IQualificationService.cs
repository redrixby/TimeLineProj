
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IQualificationService : IDisposable
    {
        Task<ICollection<Qualification>> GetAsync();
        Task SaveAsync(Qualification obj);
        Task DeleteAsync(int id);
        Qualification GetById(int id);
        PagedResult<Qualification> GetPaged(int currentPage, int onPage);
    }
}
