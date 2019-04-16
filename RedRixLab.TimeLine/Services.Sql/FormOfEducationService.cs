using AutoMapper;
using Api.DataAccess.Sql.Interfaces;
using Api.Interfaces.Sql;
using Microsoft.EntityFrameworkCore;
using Api.Models.Sql;
using Api.Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DA = Api.DataAccess.Models;

namespace Api.Services.Sql
{
    public class FormOfEducationService : IFormOfEducationService<FormOfEducation>
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public FormOfEducationService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public FormOfEducation GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                return _mapper.Map<FormOfEducation>(context.FormsOfEducation.FirstOrDefault(x => x.Id == id));
            }
        }

        public async Task<ICollection<FormOfEducation>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entityFormOfEducation = await timeLineContext
                    .FormsOfEducation
                    .ToListAsync().ConfigureAwait(false);

                return entityFormOfEducation.Select(item =>
                {
                    var formOfEducation = _mapper.Map<FormOfEducation>(item);
                    return formOfEducation;
                }).ToList();
            }
        }

        public async Task SaveAsync(FormOfEducation formOfEducation)
        {
            try
            {
                if (formOfEducation == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityFormOfEducation = await timeLineContext
                        .FormsOfEducation
                        .FirstOrDefaultAsync(item => item.Id.Equals(formOfEducation.Id)).ConfigureAwait(false);

                    if (entityFormOfEducation == null)
                    {
                        entityFormOfEducation = new DA.FormOfEducation();
                        MapForUpdateFormOfEducation(formOfEducation, entityFormOfEducation);
                        await timeLineContext.FormsOfEducation.AddAsync(entityFormOfEducation).ConfigureAwait(false);
                    }
                    else
                    {
                        MapForUpdateFormOfEducation(formOfEducation, entityFormOfEducation);
                    }


                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(int id)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entityFormOfEducation = timeLineContext
                    .FormsOfEducation
                    .FirstOrDefault(item => item.Id.Equals(id));

                if (entityFormOfEducation == null) return;

                timeLineContext.FormsOfEducation.Remove(entityFormOfEducation);

                timeLineContext.SaveChanges();
            }
        }

        public PagedResult<FormOfEducation> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .FormsOfEducation;

                var trainers = query
                    .OrderBy(item => item.Description)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<FormOfEducation>
                {
                    Items = trainers.Select(item =>
                    {
                        var trainer = _mapper.Map<FormOfEducation>(item);
                        return trainer;
                    }).OrderBy(item => item.Description).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateFormOfEducation(FormOfEducation trainer, DA.FormOfEducation entityTrainer)
        {
            entityTrainer.Description = trainer.Description;
        }

        public void Dispose()
        {
        }
    }
}
