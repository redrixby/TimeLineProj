using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Speciality
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<Specialization> Specializations { get; set; }
        public ICollection<Enrolle> Enrolles { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<SpecialityInfoForEnrolle> SpecialityInfoForEnrolles { get; set; }
        public ICollection<StudentsInfo> StudentsInfos { get; set; }
    }
}
