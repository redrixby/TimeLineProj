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
    public class SubjectMarkInfoService : ISubjectMarkInfoService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public SubjectMarkInfoService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public SubjectMarkInfo GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.SubjectMarkInfos.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<SubjectMarkInfo>(entity);
            }
        }

        public async Task<ICollection<SubjectMarkInfo>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .SubjectMarkInfos
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<SubjectMarkInfo>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(SubjectMarkInfo entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .SubjectMarkInfos
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.SubjectMarkInfo();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.SubjectMarkInfos.AddAsync(entityModel);
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
                        .SubjectMarkInfos
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.SubjectMarkInfos.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<SubjectMarkInfo> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .SubjectMarkInfos;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<SubjectMarkInfo>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<SubjectMarkInfo>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(SubjectMarkInfo entity, DA.SubjectMarkInfo daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
