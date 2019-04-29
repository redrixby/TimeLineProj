using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class SpecialityInfoForEnrolle
    {
        public int Id { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public int StudyFormId { get; set; }
        public StudyForm StudyForm { get; set; }
        public int TotalAmountRecruitmant { get; set; }
        public int AmountRecruitmentPaid { get; set; }
        public int AmountRecruitmentFree { get; set; }
        public double PassingBall { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
