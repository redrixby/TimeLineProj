﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Interfaces.Sql;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Models;
using BL = Models.Sql;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyInfoController : Controller
    {
        private readonly IStudyInfoService _service;

        private readonly IMapper _mapper;

        public StudyInfoController(IStudyInfoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var entity = _service.GetById(id);

                return Ok(_mapper.Map<BL.StudyInfo, StudyInfo>(entity));
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var entity = await _service.GetAsync();

                return Ok(_mapper.Map<ICollection<BL.StudyInfo>, ICollection<StudyInfo>>(entity));
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]StudyInfo value)
        {
            try
            {
                var entity = _mapper.Map<BL.StudyInfo>(value);
                var id = _service.SaveAsync(entity);
                return Ok(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]StudyInfo value)
        {
            try
            {
                var entity = _mapper.Map<BL.StudyInfo>(value);
                var id = _service.SaveAsync(entity);
                return Ok(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entity = _service.DeleteAsync(id);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
