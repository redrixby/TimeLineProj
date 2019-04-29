using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Enrolle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateChanged { get; set; }
        public DateTime DateDeleted { get; set; }
        public int StudyFormId { get; set; }
        public StudyForm StudyForm { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public double AverageGradeCertificate { get; set; }
        public int BenefitsId { get; set; }
        public Benefits Benefits { get; set; }
        public bool DucementDelivery { get; set; }
        public bool DocumentPickUp { get; set; }
        public bool Status { get; set; }
        public double AmountBall { get; set; }
        public ICollection<EntranceExam> EntranceExams { get; set; }
        public ICollection<CentralizedTesting> CentralizedTestings { get; set; }
    }
}
