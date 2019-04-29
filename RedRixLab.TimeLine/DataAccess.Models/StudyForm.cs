using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class StudyForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<Enrolle> Enrolles { get; set; }
        public ICollection<SpecialityInfoForEnrolle> SpecialityInfoForEnrolles { get; set; }
        public ICollection<StudentsInfo> StudentsInfos { get; set; }
    }
}
