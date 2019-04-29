using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class EntranceExam
    {
        public int Id { get; set; }
        public int EnrolleId { get; set; }
        public Enrolle Enrolle { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int Mark { get; set; }
    }
}
