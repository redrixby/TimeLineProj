using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class Statement
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDelevery { get; set; }
        public DateTime DateFinish { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public string StatementName { get; set; }
        public ICollection<StatementLine> StatementLines { get; set; }
        public ICollection<SubjectTaskInfo> SubjectTaskInfos { get; set; }
    }
}
