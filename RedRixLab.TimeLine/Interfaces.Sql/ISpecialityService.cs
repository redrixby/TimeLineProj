
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface ISpecialityService : IDisposable
    {
        Task<ICollection<Speciality>> GetAsync();
        Task SaveAsync(Speciality obj);
        Task DeleteAsync(int id);
        Speciality GetById(int id);
        PagedResult<Speciality> GetPaged(int currentPage, int onPage);
    }
}
