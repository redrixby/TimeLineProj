using AutoMapper;
using Api.Models.Sql;
using System.Globalization;
using Api.Web.Api.Models;

namespace Api.Web.Api.Profiles
{
    public class TimeLineProfile : Profile
    {
        public TimeLineProfile()
        {
            var ruCulture = new CultureInfo("ru-Ru");

            CreateMap<FormOfEducation, FormOfEducationModel>().ReverseMap();
        }
    }
}
