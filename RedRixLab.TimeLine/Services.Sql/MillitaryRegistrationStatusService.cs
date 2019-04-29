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
    public class MillitaryRegistrationStatusService : IMillitaryRegistrationStatusService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public MillitaryRegistrationStatusService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public MillitaryRegistrationStatus GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.MillitaryRegistrationStatuses.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<MillitaryRegistrationStatus>(entity);
            }
        }

        public async Task<ICollection<MillitaryRegistrationStatus>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .MillitaryRegistrationStatuses
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<MillitaryRegistrationStatus>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(MillitaryRegistrationStatus entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .MillitaryRegistrationStatuses
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.MillitaryRegistrationStatus();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.MillitaryRegistrationStatuses.AddAsync(entityModel);
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
                        .MillitaryRegistrationStatuses
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.MillitaryRegistrationStatuses.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<MillitaryRegistrationStatus> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .MillitaryRegistrationStatuses;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<MillitaryRegistrationStatus>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<MillitaryRegistrationStatus>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(MillitaryRegistrationStatus entity, DA.MillitaryRegistrationStatus daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
