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
    public class PlaceService : IPlaceService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public PlaceService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public Place GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.Places.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<Place>(entity);
            }
        }

        public async Task<ICollection<Place>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .Places
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<Place>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(Place entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .Places
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.Place();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.Places.AddAsync(entityModel);
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
                        .Places
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.Places.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<Place> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .Places;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<Place>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<Place>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(Place entity, DA.Place daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
