
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IPasportDetailsService : IDisposable
    {
        Task<ICollection<PasportDetails>> GetAsync();
        Task SaveAsync(PasportDetails obj);
        Task DeleteAsync(int id);
        PasportDetails GetById(int id);
        PagedResult<PasportDetails> GetPaged(int currentPage, int onPage);
    }
}
