
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IPositionService : IDisposable
    {
        Task<ICollection<Position>> GetAsync();
        Task SaveAsync(Position obj);
        Task DeleteAsync(int id);
        Position GetById(int id);
        PagedResult<Position> GetPaged(int currentPage, int onPage);
    }
}
