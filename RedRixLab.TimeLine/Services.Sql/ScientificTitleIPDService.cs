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
    public class ScientificTitleIPDService : IScientificTitleIPDService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public ScientificTitleIPDService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public ScientificTitleIPD GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.ScientificTitleIPDs.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<ScientificTitleIPD>(entity);
            }
        }

        public async Task<ICollection<ScientificTitleIPD>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .ScientificTitleIPDs
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<ScientificTitleIPD>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(ScientificTitleIPD entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .ScientificTitleIPDs
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.ScientificTitleIPD();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.ScientificTitleIPDs.AddAsync(entityModel);
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
                        .ScientificTitleIPDs
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.ScientificTitleIPDs.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<ScientificTitleIPD> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .ScientificTitleIPDs;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<ScientificTitleIPD>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<ScientificTitleIPD>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(ScientificTitleIPD entity, DA.ScientificTitleIPD daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
