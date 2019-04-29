using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class StudentsInfo
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int StudyFormId { get; set; }
        public StudyForm StudyForm { get; set; }
        public int StudyTypeId { get; set; }
        public StudyType StudyType { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; } 
        public int CourseOfStudy { get; set; }
        public int Semmester { get; set; }

    }
}
