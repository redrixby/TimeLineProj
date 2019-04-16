using System;
using AutoMapper;
using Api.Interfaces.Sql;
using Microsoft.AspNetCore.Mvc;
using Api.Models.Sql;
using Api.Web.Api.Models;

namespace Api.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormOfEducationController : ControllerBase
    {
        private readonly IFormOfEducationService<FormOfEducation> _formOfEducationService;

        private readonly IMapper _mapper;

        public FormOfEducationController(IFormOfEducationService<FormOfEducation> formOfEducationService, IMapper mapper)
        {
            _formOfEducationService = formOfEducationService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var formOfEducation = _formOfEducationService.GetById(id);

                return Ok(_mapper.Map<FormOfEducation, FormOfEducationModel>(formOfEducation));
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
    }
}
