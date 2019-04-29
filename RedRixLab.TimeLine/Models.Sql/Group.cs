using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Group
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public string GroupName { get; set; }
        public int CourseOfStudy { get; set; }
        public int Semmester { get; set; }
        public ICollection<GroupSubjectList> GroupSubjects { get; set; }
        public ICollection<StudentsInfo> StudentsInfos { get; set; }
        public ICollection<StatementLine> StatementLines { get; set; }
    }
}
