using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class User: IdentityUser<int>
    {
        public bool Active { get; set; }
        public ICollection<RelativesAboutInfo> RelativesAboutInfos { get; set; }
        public ICollection<Place> Places { get; set; }
        public ICollection<PasportDetails> PasportDetails { get; set; }
        public ICollection<BasicInfo> BasicInfos { get; set; }
        public ICollection<MillitaryRegistration> MillitaryRegistrations { get; set; }
        public ICollection<StudyInfo> StudyInfos { get; set; }
        public ICollection<Workers> Workers { get; set; }
        public ICollection<JobsInfo> JobsInfos { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Enrolle> Enrolles { get; set; }
    }
}
