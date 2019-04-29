using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<SubjectInfo> SubjectInfos { get; set; }
        public ICollection<SubjectTask> SubjectTasks { get; set; }
        public ICollection<EntranceExam> EntranceExams { get; set; }
        public ICollection<CentralizedTesting> CentralizedTestings { get; set; }
        public ICollection<GroupSubjectList> GroupSubjects { get; set; }
        public ICollection<SubjectDebtInfo> SubjectDebtInfos { get; set; }
        public ICollection<Statement> Statements { get; set; }
        public ICollection<SubjectTaskInfo> SubjectTaskInfos { get; set; }
    }
}
