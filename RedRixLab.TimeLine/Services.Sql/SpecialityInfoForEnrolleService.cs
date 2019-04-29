using AutoMapper;
using DataAccess.Sql.Interfaces;
using Interfaces.Sql;
using Microsoft.EntityFrameworkCore;
using Models.Sql;
using Models.Sql.PagedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DA = DataAccess.Models;

namespace Services.Sql
{
    public class SpecialityInfoForEnrolleService : ISpecialityInfoForEnrolleService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public SpecialityInfoForEnrolleService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public SpecialityInfoForEnrolle GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.SpecialityInfoForEnrolles.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<SpecialityInfoForEnrolle>(entity);
            }
        }

        public async Task<ICollection<SpecialityInfoForEnrolle>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .SpecialityInfoForEnrolles
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<SpecialityInfoForEnrolle>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(SpecialityInfoForEnrolle entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .SpecialityInfoForEnrolles
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.SpecialityInfoForEnrolle();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.SpecialityInfoForEnrolles.AddAsync(entityModel);
                    }
                    else
                    {
                        MapForUpdateentity(entity, entityModel);
                    }


                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = timeLineContext
                        .SpecialityInfoForEnrolles
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.SpecialityInfoForEnrolles.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<SpecialityInfoForEnrolle> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .SpecialityInfoForEnrolles;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<SpecialityInfoForEnrolle>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<SpecialityInfoForEnrolle>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(SpecialityInfoForEnrolle entity, DA.SpecialityInfoForEnrolle daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
