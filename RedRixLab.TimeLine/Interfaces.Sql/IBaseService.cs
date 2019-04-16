using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Interfaces.Sql
{
    public interface IBaseService<T> : IDisposable where T : class
    {
        Task<ICollection<T>> GetAsync();

        Task SaveAsync(T obj);

        Task Delete(int id);
    }
}
