using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IBasicInfoService : IDisposable
    {
        Task<ICollection<BasicInfo>> GetAsync();
        Task SaveAsync(BasicInfo obj);
        Task DeleteAsync(int id);
        BasicInfo GetById(int id);
        PagedResult<BasicInfo> GetPaged(int currentPage, int onPage);
    }
}
