using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<StudentsInfo> StudentsInfos { get; set; }
        public ICollection<SubjectMarkInfo> SubjectMarkInfos { get; set; }
        public ICollection<SubjectDebtInfo> SubjectDebtInfos { get; set; }
        public ICollection<StatementLine> StatementLines { get; set; }
        public ICollection<SubjectTaskInfo> SubjectTaskInfos { get; set; }

    }
}
