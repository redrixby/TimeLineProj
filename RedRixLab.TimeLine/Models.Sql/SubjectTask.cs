using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class SubjectTask
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }
        public int CourseOfStudy { get; set; }
        public int Semmester { get; set; }
    }
}
