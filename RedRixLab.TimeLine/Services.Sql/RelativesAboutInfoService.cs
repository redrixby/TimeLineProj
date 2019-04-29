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
    public class RelativesAboutInfoService : IRelativesAboutInfoService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public RelativesAboutInfoService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public RelativesAboutInfo GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.RelativesAboutInfos.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<RelativesAboutInfo>(entity);
            }
        }

        public async Task<ICollection<RelativesAboutInfo>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .RelativesAboutInfos
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<RelativesAboutInfo>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(RelativesAboutInfo entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .RelativesAboutInfos
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.RelativesAboutInfo();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.RelativesAboutInfos.AddAsync(entityModel);
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
                        .RelativesAboutInfos
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.RelativesAboutInfos.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<RelativesAboutInfo> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .RelativesAboutInfos;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<RelativesAboutInfo>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<RelativesAboutInfo>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(RelativesAboutInfo entity, DA.RelativesAboutInfo daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
