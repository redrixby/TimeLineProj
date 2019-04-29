using Interfaces.Sql;
using Microsoft.Extensions.DependencyInjection;
using Models.Sql;

namespace Services.Sql.Extensions
{
    public static class BusinessLogicExtension
    {
        /// <summary>
        /// Configures services for BusinessLogic
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureBusinessLogic(this IServiceCollection services)
        {
            services.AddTransient<IAcademicDegreesService, AcademicDegreesService>();
            services.AddTransient<IAcademicTitleService, AcademicTitleService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IBasicInfoService, BasicInfoService>();
            services.AddTransient<IBenefitsService, BenefitsService>();
            services.AddTransient<ICentralizedTestingService, CentralizedTestingService>();
            services.AddTransient<ICitizenshipService, CitizenshipService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IDistrictService, DistrictService>();
            services.AddTransient<IEducationTypeService, EducationTypeService>();
            services.AddTransient<IEnrolleService, EnrolleService>();
            services.AddTransient<IEntranceExamService, EntranceExamService>();
            services.AddTransient<IFacultyService, FacultyService>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IGroupService, GroupService>();
            services.AddTransient<IGroupSubjectListService, GroupSubjectListService>();
            services.AddTransient<IInstitutionNameService, InstitutionNameService>();
            services.AddTransient<IInstitutionTypeService, InstitutionTypeService>();
            services.AddTransient<IJobsInfoService, JobsInfoService>();
            services.AddTransient<ILocallityTypeService, LocallityTypeService>();
            services.AddTransient<IMaritalStatusService, MaritalStatusService>();
            services.AddTransient<IMillitaryRegistrationService, MillitaryRegistrationService>();
            services.AddTransient<IMillitaryRegistrationStatusService, MillitaryRegistrationStatusService>();
            services.AddTransient<IPasportDetailsService, PasportDetailsService>();
            services.AddTransient<IPlaceService, PlaceService>();
            services.AddTransient<IPlaceTypeService, PlaceTypeService>();
            services.AddTransient<IPositionService, PositionService>();
            services.AddTransient<IQualificationService, QualificationService>();
            services.AddTransient<IReasonService, ReasonService>();
            services.AddTransient<IRegionService, RegionService>();
            services.AddTransient<IRelativesAboutInfoService, RelativesAboutInfoService>();
            services.AddTransient<IRelativesAddressService, RelativesAddressService>();
            services.AddTransient<IRelativeTypeService, RelativeTypeService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IScientificSpecialityService, ScientificSpecialityService>();
            services.AddTransient<IScientificTitleIPDService, ScientificTitleIPDService>();
            services.AddTransient<ISpecialityService, SpecialityService>();
            services.AddTransient<ISpecialityInfoForEnrolleService, SpecialityInfoForEnrolleService>();
            services.AddTransient<ISpecializationService, SpecializationService>();
            services.AddTransient<IStatementService, StatementService>();
            services.AddTransient<IStatementLineService, StatementLineService>();
            services.AddTransient<IStreetService, StreetService>();
            services.AddTransient<IStreetTypeService, StreetTypeService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IStudentsInfoService, StudentsInfoService>();
            services.AddTransient<IStudyFormService,StudyFormService>();
            services.AddTransient<IStudyInfoService, StudyInfoService>();
            services.AddTransient<IStudyTypeService, StudyTypeService>();
            services.AddTransient<ISubdivisionService, SubdivisionService>();
            services.AddTransient<ISubjectService, SubjectService>();
            services.AddTransient<ISubjectDebtInfoService, SubjectDebtInfoService>();
            services.AddTransient<ISubjectInfoService, SubjectInfoService>();
            services.AddTransient<ISubjectMarkInfoService, SubjectMarkInfoService>();
            services.AddTransient<ISubjectTaskService, SubjectTaskService>();
            services.AddTransient<ISubjectTaskInfoService, SubjectTaskInfoService>();
            services.AddTransient<ITaskTypeService, TaskTypeService>();
            services.AddTransient<ITeacherService, TeacherService>();
            services.AddTransient<ITrainingService, TrainingService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IWorkersService, WorkersService>();
            services.AddTransient<IWorkersInfoService, WorkersInfoService>();

            return services;
        }
    }
}
