
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ITrainingService : IDisposable
    {
        Task<ICollection<Training>> GetAsync();
        Task SaveAsync(Training obj);
        Task DeleteAsync(int id);
        Training GetById(int id);
        PagedResult<Training> GetPaged(int currentPage, int onPage);
    }
}
