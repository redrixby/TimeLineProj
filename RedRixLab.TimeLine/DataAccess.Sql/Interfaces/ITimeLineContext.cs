using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Sql.Interfaces
{
    public interface ITimeLineContext : IDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<AcademicDegree> AcademicDegrees { get; set; }
        DbSet<AcademicTitle> AcademicTitles { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<BasicInfo> BasicInfos { get; set; }
        DbSet<Benefits> Benefits { get; set; }
        DbSet<CentralizedTesting> CentralizedTestings { get; set; }
        DbSet<Citizenship> Citizenships { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<EducationType> EducationTypes { get; set; }
        DbSet<Enrolle> Enrolles { get; set; }
        DbSet<EntranceExam> EntranceExams { get; set; }
        DbSet<Faculty> Faculties { get; set; }
        DbSet<Gender> Genders { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<GroupSubjectList> GroupSubjectLists { get; set; }
        DbSet<InstitutionName> InstitutionNames { get; set; }
        DbSet<InstitutionType> InstitutionTypes { get; set; }
        DbSet<JobsInfo> JobsInfos { get; set; }
        DbSet<LocallityType> LocallityTypes { get; set; }
        DbSet<MaritalStatus> MaritalStatuses { get; set; }
        DbSet<MillitaryRegistration> MillitaryRegistrations { get; set; }
        DbSet<MillitaryRegistrationStatus> MillitaryRegistrationStatuses { get; set; }
        DbSet<PasportDetails> PasportDetails { get; set; }
        DbSet<Place> Places { get; set; }
        DbSet<PlaceType> PlaceTypes { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Qualification> Qualifications { get; set; }
        DbSet<Reason> Reasons { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<RelativesAboutInfo> RelativesAboutInfos { get; set; }
        DbSet<RelativesAddress> RelativesAddresses { get; set; }
        DbSet<RelativeType> RelativeTypes { get; set; }
        DbSet<ScientificSpeciality> ScientificSpecialities { get; set; }
        DbSet<ScientificTitleIPD> ScientificTitleIPDs { get; set; }
        DbSet<Speciality> Specialities { get; set; }
        DbSet<SpecialityInfoForEnrolle> SpecialityInfoForEnrolles { get; set; }
        DbSet<Specialization> Specializations { get; set; }
        DbSet<Statement> Statements { get; set; }
        DbSet<StatementLine> StatementLines { get; set; }
        DbSet<Street> Streets { get; set; }
        DbSet<StreetType> StreetTypes { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<StudentsInfo> StudentsInfos { get; set; }
        DbSet<StudyForm> StudyForms { get; set; }
        DbSet<StudyInfo> StudyInfos { get; set; }
        DbSet<StudyType> StudyTypes { get; set; }
        DbSet<Subdivision> Subdivisions { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<SubjectDebtInfo> SubjectDebtInfos { get; set; }
        DbSet<SubjectInfo> SubjectInfos { get; set; }
        DbSet<SubjectMarkInfo> SubjectMarkInfos { get; set; }
        DbSet<SubjectTask> SubjectTasks { get; set; }
        DbSet<SubjectTaskInfo> SubjectTaskInfos { get; set; }
        DbSet<TaskType> TaskTypes { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Training> Trainings { get; set; }
        DbSet<Workers> Workers { get; set; }
        DbSet<WorkersInfo> WorkersInfos { get; set; }
    }
}
