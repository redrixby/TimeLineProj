using AutoMapper;
using Models.Sql;
using DA = DataAccess.Models;

namespace Api.Services.Sql.Profiles
{
    public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<User, DA.User>().ReverseMap();
            CreateMap<Role, DA.Role>().ReverseMap();
            CreateMap<AcademicDegree, DA.AcademicDegree>().ReverseMap();
            CreateMap<AcademicTitle, DA.AcademicTitle>().ReverseMap();
            CreateMap<Address, DA.Address>().ReverseMap();
            CreateMap<BasicInfo, DA.BasicInfo>().ReverseMap();
            CreateMap<Benefits, DA.Benefits>().ReverseMap();
            CreateMap<CentralizedTesting, DA.CentralizedTesting>().ReverseMap();
            CreateMap<Citizenship, DA.Citizenship>().ReverseMap();
            CreateMap<City, DA.City>().ReverseMap();
            CreateMap<Country, DA.Country>().ReverseMap();
            CreateMap<District, DA.District>().ReverseMap();
            CreateMap<EducationType, DA.EducationType>().ReverseMap();
            CreateMap<Enrolle, DA.Enrolle>().ReverseMap();
            CreateMap<EntranceExam, DA.EntranceExam>().ReverseMap();
            CreateMap<Faculty, DA.Faculty>().ReverseMap();
            CreateMap<Gender, DA.Gender>().ReverseMap();
            CreateMap<Group, DA.Group>().ReverseMap();
            CreateMap<GroupSubjectList, DA.GroupSubjectList>().ReverseMap();
            CreateMap<InstitutionName, DA.InstitutionName>().ReverseMap();
            CreateMap<InstitutionType, DA.InstitutionType>().ReverseMap();
            CreateMap<JobsInfo, DA.JobsInfo>().ReverseMap();
            CreateMap<LocallityType, DA.LocallityType>().ReverseMap();
            CreateMap<MaritalStatus, DA.MaritalStatus>().ReverseMap();
            CreateMap<MillitaryRegistration, DA.MillitaryRegistration>().ReverseMap();
            CreateMap<MillitaryRegistrationStatus, DA.MillitaryRegistrationStatus>().ReverseMap();
            CreateMap<PasportDetails, DA.PasportDetails>().ReverseMap();
            CreateMap<Place, DA.Place>().ReverseMap();
            CreateMap<PlaceType, DA.PlaceType>().ReverseMap();
            CreateMap<Position, DA.Position>().ReverseMap();
            CreateMap<Qualification, DA.Qualification>().ReverseMap();
            CreateMap<Reason, DA.Reason>().ReverseMap();
            CreateMap<Region, DA.Region>().ReverseMap();
            CreateMap<RelativesAboutInfo, DA.RelativesAboutInfo>().ReverseMap();
            CreateMap<RelativesAddress, DA.RelativesAddress>().ReverseMap();
            CreateMap<RelativeType, DA.RelativeType>().ReverseMap();
            CreateMap<ScientificSpeciality, DA.ScientificSpeciality>().ReverseMap();
            CreateMap<ScientificTitleIPD, DA.ScientificTitleIPD>().ReverseMap();
            CreateMap<Speciality, DA.Speciality>().ReverseMap();
            CreateMap<SpecialityInfoForEnrolle, DA.SpecialityInfoForEnrolle>().ReverseMap();
            CreateMap<Specialization, DA.Specialization>().ReverseMap();
            CreateMap<Statement, DA.Statement>().ReverseMap();
            CreateMap<StatementLine, DA.StatementLine>().ReverseMap();
            CreateMap<Street, DA.Street>().ReverseMap();
            CreateMap<StreetType, DA.StreetType>().ReverseMap();
            CreateMap<Student, DA.Student>().ReverseMap();
            CreateMap<StudentsInfo, DA.StudentsInfo>().ReverseMap();
            CreateMap<StudyForm, DA.StudyForm>().ReverseMap();
            CreateMap<StudyInfo, DA.StudyInfo>().ReverseMap();
            CreateMap<StudyType, DA.StudyType>().ReverseMap();
            CreateMap<Subdivision, DA.Subdivision>().ReverseMap();
            CreateMap<Subject, DA.Subject>().ReverseMap();
            CreateMap<SubjectDebtInfo, DA.SubjectDebtInfo>().ReverseMap();
            CreateMap<SubjectInfo, DA.SubjectInfo>().ReverseMap();
            CreateMap<SubjectMarkInfo, DA.SubjectMarkInfo>().ReverseMap();
            CreateMap<SubjectTask, DA.SubjectTask>().ReverseMap();
            CreateMap<SubjectTaskInfo, DA.SubjectTaskInfo>().ReverseMap();
            CreateMap<TaskType, DA.TaskType>().ReverseMap();
            CreateMap<Teacher, DA.Teacher>().ReverseMap();
            CreateMap<Training, DA.Training>().ReverseMap();
            CreateMap<Workers, DA.Workers>().ReverseMap();
            CreateMap<WorkersInfo, DA.WorkersInfo>().ReverseMap();
        }
    }
}
