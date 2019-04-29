using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Workers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateChanged { get; set; }
        public DateTime DateDeleted { get; set; }
        public ICollection<WorkersInfo> WorkersInfos { get; set; }
        public ICollection<Training> Trainings { get; set; }
    }
}
