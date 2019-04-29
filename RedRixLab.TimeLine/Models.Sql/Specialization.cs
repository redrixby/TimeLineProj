using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Specialization
    {
        public int Id { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<StudyInfo> StudyInfos { get; set; }
        public ICollection<StudentsInfo> StudentsInfos { get; set; }
    }
}
