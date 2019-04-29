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
    public class SpecialityService : ISpecialityService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public SpecialityService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public Speciality GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.Specialities.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<Speciality>(entity);
            }
        }

        public async Task<ICollection<Speciality>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .Specialities
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<Speciality>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(Speciality entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .Specialities
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.Speciality();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.Specialities.AddAsync(entityModel);
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
                        .Specialities
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.Specialities.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<Speciality> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .Specialities;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<Speciality>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<Speciality>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(Speciality entity, DA.Speciality daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
