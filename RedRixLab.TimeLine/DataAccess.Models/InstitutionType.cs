﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class InstitutionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<InstitutionName> InstitutionNames { get; set; }
    }
}
