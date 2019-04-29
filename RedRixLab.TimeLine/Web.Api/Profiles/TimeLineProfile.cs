using AutoMapper;
using Web.Api.Models;
using BL = Models.Sql;

namespace Web.Api.Profiles
{
    public class TimeLineProfile : Profile
    {
        public TimeLineProfile()
        {
            CreateMap<User, BL.User>().ReverseMap();
            CreateMap<Role, BL.Role>().ReverseMap();
            CreateMap<AcademicDegree, BL.AcademicDegree>().ReverseMap();
            CreateMap<AcademicTitle, BL.AcademicTitle>().ReverseMap();
            CreateMap<Address, BL.Address>().ReverseMap();
            CreateMap<BasicInfo, BL.BasicInfo>().ReverseMap();
            CreateMap<Benefits, BL.Benefits>().ReverseMap();
            CreateMap<CentralizedTesting, BL.CentralizedTesting>().ReverseMap();
            CreateMap<Citizenship, BL.Citizenship>().ReverseMap();
            CreateMap<City, BL.City>().ReverseMap();
            CreateMap<Country, BL.Country>().ReverseMap();
            CreateMap<District, BL.District>().ReverseMap();
            CreateMap<EducationType, BL.EducationType>().ReverseMap();
            CreateMap<Enrolle, BL.Enrolle>().ReverseMap();
            CreateMap<EntranceExam, BL.EntranceExam>().ReverseMap();
            CreateMap<Faculty, BL.Faculty>().ReverseMap();
            CreateMap<Gender, BL.Gender>().ReverseMap();
            CreateMap<Group, BL.Group>().ReverseMap();
            CreateMap<GroupSubjectList, BL.GroupSubjectList>().ReverseMap();
            CreateMap<InstitutionName, BL.InstitutionName>().ReverseMap();
            CreateMap<InstitutionType, BL.InstitutionType>().ReverseMap();
            CreateMap<JobsInfo, BL.JobsInfo>().ReverseMap();
            CreateMap<LocallityType, BL.LocallityType>().ReverseMap();
            CreateMap<MaritalStatus, BL.MaritalStatus>().ReverseMap();
            CreateMap<MillitaryRegistration, BL.MillitaryRegistration>().ReverseMap();
            CreateMap<MillitaryRegistrationStatus, BL.MillitaryRegistrationStatus>().ReverseMap();
            CreateMap<PasportDetails, BL.PasportDetails>().ReverseMap();
            CreateMap<Place, BL.Place>().ReverseMap();
            CreateMap<PlaceType, BL.PlaceType>().ReverseMap();
            CreateMap<Position, BL.Position>().ReverseMap();
            CreateMap<Qualification, BL.Qualification>().ReverseMap();
            CreateMap<Reason, BL.Reason>().ReverseMap();
            CreateMap<Region, BL.Region>().ReverseMap();
            CreateMap<RelativesAboutInfo, BL.RelativesAboutInfo>().ReverseMap();
            CreateMap<RelativesAddress, BL.RelativesAddress>().ReverseMap();
            CreateMap<RelativeType, BL.RelativeType>().ReverseMap();
            CreateMap<ScientificSpeciality, BL.ScientificSpeciality>().ReverseMap();
            CreateMap<ScientificTitleIPD, BL.ScientificTitleIPD>().ReverseMap();
            CreateMap<Speciality, BL.Speciality>().ReverseMap();
            CreateMap<SpecialityInfoForEnrolle, BL.SpecialityInfoForEnrolle>().ReverseMap();
            CreateMap<Specialization, BL.Specialization>().ReverseMap();
            CreateMap<Statement, BL.Statement>().ReverseMap();
            CreateMap<StatementLine, BL.StatementLine>().ReverseMap();
            CreateMap<Street, BL.Street>().ReverseMap();
            CreateMap<StreetType, BL.StreetType>().ReverseMap();
            CreateMap<Student, BL.Student>().ReverseMap();
            CreateMap<StudentsInfo, BL.StudentsInfo>().ReverseMap();
            CreateMap<StudyForm, BL.StudyForm>().ReverseMap();
            CreateMap<StudyInfo, BL.StudyInfo>().ReverseMap();
            CreateMap<StudyType, BL.StudyType>().ReverseMap();
            CreateMap<Subdivision, BL.Subdivision>().ReverseMap();
            CreateMap<Subject, BL.Subject>().ReverseMap();
            CreateMap<SubjectDebtInfo, BL.SubjectDebtInfo>().ReverseMap();
            CreateMap<SubjectInfo, BL.SubjectInfo>().ReverseMap();
            CreateMap<SubjectMarkInfo, BL.SubjectMarkInfo>().ReverseMap();
            CreateMap<SubjectTask, BL.SubjectTask>().ReverseMap();
            CreateMap<SubjectTaskInfo, BL.SubjectTaskInfo>().ReverseMap();
            CreateMap<TaskType, BL.TaskType>().ReverseMap();
            CreateMap<Teacher, BL.Teacher>().ReverseMap();
            CreateMap<Training, BL.Training>().ReverseMap();
            CreateMap<Workers, BL.Workers>().ReverseMap();
            CreateMap<WorkersInfo, BL.WorkersInfo>().ReverseMap();
        }
    }
}
