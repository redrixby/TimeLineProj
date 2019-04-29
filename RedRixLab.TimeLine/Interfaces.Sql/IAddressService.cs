using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IAddressService : IDisposable
    {
        Task<ICollection<Address>> GetAsync();
        Task SaveAsync(Address obj);
        Task DeleteAsync(int id);
        Address GetById(int id);
        PagedResult<Address> GetPaged(int currentPage, int onPage);
    }
}
