
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IUserService : IDisposable
    {
        Task<ICollection<User>> GetAsync();
        Task SaveAsync(User obj);
        Task DeleteAsync(int id);
        User GetById(int id);
        PagedResult<User> GetPaged(int currentPage, int onPage);
    }
}
