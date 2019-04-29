
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Sql
{
    public interface IStudentService : IDisposable
    {
        Task<ICollection<Student>> GetAsync();
        Task SaveAsync(Student obj);
        Task DeleteAsync(int id);
        Student GetById(int id);
        PagedResult<Student> GetPaged(int currentPage, int onPage);
    }
}
