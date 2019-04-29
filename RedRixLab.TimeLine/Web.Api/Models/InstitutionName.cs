﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class InstitutionName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int InstitutionTypeId { get; set; }
        public InstitutionType InstitutionType { get; set; }
        public ICollection<StudyInfo> StudyInfos { get; set; }
        public ICollection<Training> Trainings { get; set; }

    }
}
