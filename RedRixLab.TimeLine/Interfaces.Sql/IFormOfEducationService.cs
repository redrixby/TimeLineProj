using Api.Models.Sql;
using Api.Models.Sql.PagedModels;
using System.Threading.Tasks;

namespace Api.Interfaces.Sql
{
    public interface IFormOfEducationService<T> : IBaseService<T> where T : class
    {
        FormOfEducation GetById(int id);
        Task SaveAsync(FormOfEducation formOfEducation);
        PagedResult<FormOfEducation> GetPaged(int currentPage, int onPage);
    }
}
