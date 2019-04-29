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
    public class SubdivisionService : ISubdivisionService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public SubdivisionService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public Subdivision GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.Subdivisions.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<Subdivision>(entity);
            }
        }

        public async Task<ICollection<Subdivision>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .Subdivisions
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<Subdivision>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(Subdivision entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .Subdivisions
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.Subdivision();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.Subdivisions.AddAsync(entityModel);
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
                        .Subdivisions
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.Subdivisions.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<Subdivision> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .Subdivisions;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<Subdivision>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<Subdivision>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(Subdivision entity, DA.Subdivision daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
