using AutoMapper;
using Api.Models.Sql;
using DA = Api.DataAccess.Models;

namespace Api.Services.Sql.Profiles
{
    public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<FormOfEducation, DA.FormOfEducation>().ReverseMap();
        }
    }
}
