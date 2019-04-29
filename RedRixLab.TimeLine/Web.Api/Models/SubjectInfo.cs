using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class SubjectInfo
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public double AllottedStudyTime { get; set; }
        public int CourseOfStudy { get; set; }
        public int Semmester { get; set; }
    }
}
