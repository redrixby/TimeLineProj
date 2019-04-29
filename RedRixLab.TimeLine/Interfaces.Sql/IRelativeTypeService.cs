
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IRelativeTypeService : IDisposable
    {
        Task<ICollection<RelativeType>> GetAsync();
        Task SaveAsync(RelativeType obj);
        Task DeleteAsync(int id);
        RelativeType GetById(int id);
        PagedResult<RelativeType> GetPaged(int currentPage, int onPage);
    }
}
