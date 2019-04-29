
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IRelativesAddressService : IDisposable
    {
        Task<ICollection<RelativesAddress>> GetAsync();
        Task SaveAsync(RelativesAddress obj);
        Task DeleteAsync(int id);
        RelativesAddress GetById(int id);
        PagedResult<RelativesAddress> GetPaged(int currentPage, int onPage);
    }
}
