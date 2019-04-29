using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Training
    {
        public int Id { get; set; }
        public int WorkersId { get; set; }
        public Workers Workers { get; set; }
        public DateTime DateTraining { get; set; }
        public int InstitutionNameId { get; set; }
        public InstitutionName InstitutionName { get; set; }
        public DateTime DateEndTraining { get; set; }
    }
}
