using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataAccess.Sql.Interfaces;
using DataAccess.Models;
using System.Linq;

namespace DataAccess.Sql.Contexts
{
    public class TimeLineContext : IdentityDbContext<User, Role, int>, ITimeLineContext
    {
        public TimeLineContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<AcademicDegree>().HasIndex(ad => ad.Name).HasName("AcademicDegreeUnique").IsUnique();
            builder.Entity<AcademicTitle>().HasIndex(at => at.Name).HasName("cademicTitleUnique").IsUnique();
            builder.Entity<Address>().HasIndex(ad => new { ad.CountryId, ad.RegionId, ad.CityId, ad.DistrictId, ad.StreetId, ad.HouseNumber, ad.Corps, ad.RoomNumber }).HasName("AddressUnique").IsUnique();
            builder.Entity<BasicInfo>().HasIndex(bi => bi.Id).HasName("BasicInfoUnique").IsUnique();
            builder.Entity<Benefits>().HasIndex(bn => bn.Name).HasName("BenefitsUnique").IsUnique();
            builder.Entity<CentralizedTesting>().HasIndex(ct => new { ct.EnrolleId, ct.SubjectId }).HasName("CentralizedTestingUnique").IsUnique();
            builder.Entity<Citizenship>().HasIndex(cz => cz.Name).HasName("CitizenshipDegreeUnique").IsUnique();
            builder.Entity<City>().HasIndex(ci => new { ci.DistrictId, ci.LocallityTypeId, ci.Name }).HasName("CityUnique").IsUnique();
            builder.Entity<Country>().HasIndex(ct => ct.Name).HasName("CountryUnique").IsUnique();
            builder.Entity<District>().HasIndex(dt => new { dt.RegionId, dt.Name }).HasName("DistrictUnique").IsUnique();
            builder.Entity<EducationType>().HasIndex(et => et.Name).HasName("EducationTypeUnique").IsUnique();
            builder.Entity<Enrolle>().HasIndex(en => en.Id).HasName("EnrolleUnique").IsUnique();
            builder.Entity<EntranceExam>().HasIndex(ee => new { ee.EnrolleId, ee.SubjectId }).HasName("EntranceExamUnique").IsUnique();
            builder.Entity<Faculty>().HasIndex(fa => fa.Name).HasName("FacultyUnique").IsUnique();
            builder.Entity<Gender>().HasIndex(ge => ge.Name).HasName("GenderUnique").IsUnique();
            builder.Entity<Group>().HasIndex(gr => new { gr.SpecialityId, gr.GroupName }).HasName("GroupUnique").IsUnique();
            builder.Entity<GroupSubjectList>().HasIndex(gs => gs.Id).HasName("GroupSubjectListUnique").IsUnique();
            builder.Entity<InstitutionName>().HasIndex(it => new { it.Name, it.InstitutionTypeId }).HasName("InstitutionNameUnique").IsUnique();
            builder.Entity<InstitutionType>().HasIndex(it => it.Name).HasName("InstitutionTypeUnique").IsUnique();
            builder.Entity<JobsInfo>().HasIndex(ji => new { ji.UserId, ji.WorkPlace, ji.SubdivisionId, ji.PositionId }).HasName("JobsInfoUnique").IsUnique();
            builder.Entity<LocallityType>().HasIndex(lt => lt.Name).HasName("LocallityTypeUnique").IsUnique();
            builder.Entity<MaritalStatus>().HasIndex(ms => ms.Name).HasName("MaritalStatusUnique").IsUnique();
            builder.Entity<MillitaryRegistration>().HasIndex(mr => mr.Id).HasName("MillitaryRegistrationUnique").IsUnique();
            builder.Entity<MillitaryRegistrationStatus>().HasIndex(ms => ms.Name).HasName("MillitaryRegistrationStatusUnique").IsUnique();
            builder.Entity<PasportDetails>().HasIndex(pd => pd.Id).HasName("PasportDetailsUnique").IsUnique();
            builder.Entity<Place>().HasIndex(pl => new { pl.UserId, pl.PlaceTypeId }).HasName("PlaceUnique").IsUnique();
            builder.Entity<PlaceType>().HasIndex(pt => pt.Name).HasName("PlaceTypeUnique").IsUnique();
            builder.Entity<Position>().HasIndex(ps => ps.Name).HasName("PositionUnique").IsUnique();
            builder.Entity<Qualification>().HasIndex(qa => qa.Name).HasName("QualificationUnique").IsUnique();
            builder.Entity<Reason>().HasIndex(rs => rs.Name).HasName("ReasonUnique").IsUnique();
            builder.Entity<Region>().HasIndex(rg => new { rg.CountryId, rg.Name }).HasName("RegionUnique").IsUnique();
            builder.Entity<RelativesAboutInfo>().HasIndex(ra => new { ra.UserId, ra.RelativeTypeId, ra.FirstName, ra.LastName, ra.MiddleName }).HasName("RelativesAboutInfoUnique").IsUnique();
            builder.Entity<RelativesAddress>().HasIndex(rt => rt.Id).HasName("RelativesAddressUnique").IsUnique();
            builder.Entity<RelativeType>().HasIndex(rt => rt.Name).HasName("RelativeTypeUnique").IsUnique();
            builder.Entity<ScientificSpeciality>().HasIndex(ss => ss.Name).HasName("ScientificSpecialityUnique").IsUnique();
            builder.Entity<ScientificTitleIPD>().HasIndex(st => st.Name).HasName("ScientificTitleIPDUnique").IsUnique();
            builder.Entity<Speciality>().HasIndex(sp => new { sp.FacultyId, sp.Name }).HasName("SpecialityUnique").IsUnique();
            builder.Entity<SpecialityInfoForEnrolle>().HasIndex(si => new { si.SpecialityId, si.StudyFormId, si.DateCreated }).HasName("SpecialityInfoForEnrolleUnique").IsUnique();
            builder.Entity<Specialization>().HasIndex(sz => new { sz.SpecialityId, sz.Name }).HasName("SpecializationUnique").IsUnique();
            builder.Entity<Statement>().HasIndex(st => new { st.DateCreated, st.SubjectId, st.StatementName }).HasName("StatementUnique").IsUnique();
            builder.Entity<StatementLine>().HasIndex(sl => new { sl.StatementId, sl.GroupId, sl.StudentId }).HasName("StatementLineUnique").IsUnique();
            builder.Entity<Street>().HasIndex(st => new { st.CityId, st.StreetTypeId, st.Name }).HasName("StreetUnique").IsUnique();
            builder.Entity<StreetType>().HasIndex(st => st.Name).HasName("StreetTypeUnique").IsUnique();
            builder.Entity<Student>().HasIndex(st => st.Id).HasName("StudentUnique").IsUnique();
            builder.Entity<StudentsInfo>().HasIndex(si => si.StudentId).HasName("StudentsInfoUnique").IsUnique();
            builder.Entity<StudyForm>().HasIndex(sf => sf.Name).HasName("StudyFormUnique").IsUnique();
            builder.Entity<StudyInfo>().HasIndex(si => new { si.UserId, si.EducationTypeId, si.InstitutionNameId, si.SpecializationId, si.QualificationId }).HasName("StudyInfoUnique").IsUnique();
            builder.Entity<StudyType>().HasIndex(st => st.Name).HasName("StudyTypeUnique").IsUnique();
            builder.Entity<Subdivision>().HasIndex(sb => sb.Name).HasName("SubdivisionUnique").IsUnique();
            builder.Entity<Subject>().HasIndex(su => su.Name).HasName("SubjectUnique").IsUnique();
            builder.Entity<SubjectDebtInfo>().HasIndex(sb => sb.Id).HasName("SubjectDebtInfoUnique").IsUnique();
            builder.Entity<SubjectInfo>().HasIndex(si => new { si.SubjectId, si.AllottedStudyTime, si.CourseOfStudy, si.Semmester }).HasName("SubjectInfoUnique").IsUnique();
            builder.Entity<SubjectMarkInfo>().HasIndex(sm => sm.Id).HasName("SubjectMarkInfoUnique").IsUnique();
            builder.Entity<SubjectTask>().HasIndex(st => new { st.SubjectId, st.TaskTypeId }).HasName("SubjectTaskUnique").IsUnique();
            builder.Entity<SubjectTaskInfo>().HasIndex(si => si.Id).HasName("SubjectTaskInfoUnique").IsUnique();
            builder.Entity<TaskType>().HasIndex(tt => tt.Name).HasName("TaskTypeUnique").IsUnique();
            builder.Entity<Teacher>().HasIndex(te => te.Id).HasName("TeacherUnique").IsUnique();
            builder.Entity<Training>().HasIndex(tr => new { tr.WorkersId, tr.DateTraining, tr.InstitutionNameId, tr.DateEndTraining }).HasName("TrainingUnique").IsUnique();
            builder.Entity<Workers>().HasIndex(wr => wr.Id).HasName("WorkersUnique").IsUnique();
            builder.Entity<WorkersInfo>().HasIndex(wi => wi.WorkersId).HasName("WorkersInfoUnique").IsUnique();

            base.OnModelCreating(builder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<AcademicTitle> AcademicTitles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BasicInfo> BasicInfos { get; set; }
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<CentralizedTesting> CentralizedTestings { get; set; }
        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<Enrolle> Enrolles { get; set; }
        public DbSet<EntranceExam> EntranceExams { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupSubjectList> GroupSubjectLists { get; set; }
        public DbSet<InstitutionName> InstitutionNames { get; set; }
        public DbSet<InstitutionType> InstitutionTypes { get; set; }
        public DbSet<JobsInfo> JobsInfos { get; set; }
        public DbSet<LocallityType> LocallityTypes { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<MillitaryRegistration> MillitaryRegistrations { get; set; }
        public DbSet<MillitaryRegistrationStatus> MillitaryRegistrationStatuses { get; set; }
        public DbSet<PasportDetails> PasportDetails { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<PlaceType> PlaceTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RelativesAboutInfo> RelativesAboutInfos { get; set; }
        public DbSet<RelativesAddress> RelativesAddresses { get; set; }
        public DbSet<RelativeType> RelativeTypes { get; set; }
        public DbSet<ScientificSpeciality> ScientificSpecialities { get; set; }
        public DbSet<ScientificTitleIPD> ScientificTitleIPDs { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<SpecialityInfoForEnrolle> SpecialityInfoForEnrolles { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Statement> Statements { get; set; }
        public DbSet<StatementLine> StatementLines { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<StreetType> StreetTypes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentsInfo> StudentsInfos { get; set; }
        public DbSet<StudyForm> StudyForms { get; set; }
        public DbSet<StudyInfo> StudyInfos { get; set; }
        public DbSet<StudyType> StudyTypes { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectDebtInfo> SubjectDebtInfos { get; set; }
        public DbSet<SubjectInfo> SubjectInfos { get; set; }
        public DbSet<SubjectMarkInfo> SubjectMarkInfos { get; set; }
        public DbSet<SubjectTask> SubjectTasks { get; set; }
        public DbSet<SubjectTaskInfo> SubjectTaskInfos { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<WorkersInfo> WorkersInfos { get; set; }



 
    }
}
