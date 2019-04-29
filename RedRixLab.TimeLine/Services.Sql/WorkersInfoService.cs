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
    public class WorkersInfoService : IWorkersInfoService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public WorkersInfoService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public WorkersInfo GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.WorkersInfos.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<WorkersInfo>(entity);
            }
        }

        public async Task<ICollection<WorkersInfo>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .WorkersInfos
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<WorkersInfo>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(WorkersInfo entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .WorkersInfos
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.WorkersInfo();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.WorkersInfos.AddAsync(entityModel);
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
                        .WorkersInfos
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.WorkersInfos.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<WorkersInfo> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .WorkersInfos;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<WorkersInfo>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<WorkersInfo>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(WorkersInfo entity, DA.WorkersInfo daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
