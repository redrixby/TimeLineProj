using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class SubjectTaskInfo
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public DateTime DateCreated { get; set; }
        public int Mark { get; set; }
        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CourseOfStudy { get; set; }
        public int Semmester { get; set; }
        public int StatementId { get; set; }
        public Statement Statement { get; set; }
    }
}
