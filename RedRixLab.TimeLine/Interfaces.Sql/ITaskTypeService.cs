
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ITaskTypeService : IDisposable
    {
        Task<ICollection<TaskType>> GetAsync();
        Task SaveAsync(TaskType obj);
        Task DeleteAsync(int id);
        TaskType GetById(int id);
        PagedResult<TaskType> GetPaged(int currentPage, int onPage);
    }
}
