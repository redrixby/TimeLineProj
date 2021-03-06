﻿using AutoMapper;
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
    public class TrainingService : ITrainingService
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public TrainingService(IMapper mapper, IContextFactory contextFactory)
        {
            _mapper = mapper;
            _contextFactory = contextFactory;
        }

        public Training GetById(int id)
        {
            using (var context = _contextFactory.GetTimeLineContext())
            {
                var entity = context.Trainings.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<Training>(entity);
            }
        }

        public async Task<ICollection<Training>> GetAsync()
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var entity = await timeLineContext
                    .Trainings
                    .ToListAsync();

                return entity.Select(item =>
                {
                    var mapEntity = _mapper.Map<Training>(item);
                    return mapEntity;
                }).ToList();
            }
        }

        public async Task SaveAsync(Training entity)
        {
            try
            {
                if (entity == null) return;

                using (var timeLineContext = _contextFactory.GetTimeLineContext())
                {
                    var entityModel = await timeLineContext
                        .Trainings
                        .FirstOrDefaultAsync(item => item.Id.Equals(entity.Id));

                    if (entityModel == null)
                    {
                        entityModel = new DA.Training();
                        MapForUpdateentity(entity, entityModel);
                        await timeLineContext.Trainings.AddAsync(entityModel);
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
                        .Trainings
                        .FirstOrDefault(item => item.Id.Equals(id));

                    if (entityModel == null) return;

                    await Task.Run(() => timeLineContext.Trainings.Remove(entityModel));

                    timeLineContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PagedResult<Training> GetPaged(int currentPage, int onPage)
        {
            using (var timeLineContext = _contextFactory.GetTimeLineContext())
            {
                var offset = (currentPage - 1) * onPage;

                var query = timeLineContext
                    .Trainings;

                var array = query
                    .OrderBy(item => item.Id)
                    .ThenBy(item => item.Id)
                    .Skip(offset)
                    .Take(onPage)
                    .ToList();

                var result = new PagedResult<Training>
                {
                    Items = array.Select(item =>
                    {
                        var element = _mapper.Map<Training>(item);
                        return element;
                    }).OrderBy(item => item.Id).ToList(),

                    Offset = offset,
                    PageSize = onPage,
                    TotalCount = query.Count()
                };

                return result;
            }
        }

        private void MapForUpdateentity(Training entity, DA.Training daEntity)
        {
            daEntity.Id = entity.Id;
        }

        public void Dispose()
        {
        }
    }
}
