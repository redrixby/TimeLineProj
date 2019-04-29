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
    public class SubjectTaskInfoService : ISubjectTaskInfoService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public SubjectTaskInfoService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public SubjectTaskInfo GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.SubjectTaskInfos.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<SubjectTaskInfo>(entity);
            }
        }

        public async Task<ICollection<SubjectTaskInfo>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .SubjectTaskInfos
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<SubjectTaskInfo>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(SubjectTaskInfo entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .SubjectTaskInfos
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.SubjectTaskInfo();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.SubjectTaskInfos.AddAsync(entityModel);
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
                        .SubjectTaskInfos
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.SubjectTaskInfos.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<SubjectTaskInfo> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .SubjectTaskInfos;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<SubjectTaskInfo>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<SubjectTaskInfo>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(SubjectTaskInfo entity, DA.SubjectTaskInfo daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
