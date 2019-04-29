using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class StudyInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EducationTypeId { get; set; }
        public EducationType EducationType { get; set; }
        public int InstitutionNameId { get; set; }
        public InstitutionName InstitutionName { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public int QualificationId { get; set; }
        public Qualification Qualification { get; set; }
        public int AcademicTitleId { get; set; }
        public AcademicTitle AcademicTitle { get; set; }
        public int AcademicDegreeId { get; set; }
        public AcademicDegree AcademicDegree { get; set; }
        public int ScientificSpecialityId { get; set; }
        public ScientificSpeciality ScientificSpeciality { get; set; }
        public int ScientificTitleIPDId { get; set; }
        public ScientificTitleIPD ScientificTitleIPD { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public DateTime DateEnrollment { get; set; }
        public DateTime DateReEnrollment { get; set; }
        public string LanguageForeign { get; set; }
    }
}
