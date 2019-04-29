using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class StatementLine
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public Statement Statement { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int Mark { get; set; }
    }
}
