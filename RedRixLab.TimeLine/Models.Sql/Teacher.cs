using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Teacher
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<SubjectMarkInfo> SubjectMarkInfos { get; set; }
        public ICollection<SubjectDebtInfo> SubjectDebtInfos { get; set; }
        public ICollection<Statement> Statements { get; set; }
        public ICollection<SubjectTaskInfo> SubjectTaskInfos { get; set; }

    }
}
