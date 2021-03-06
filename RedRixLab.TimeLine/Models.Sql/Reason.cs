﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Reason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ICollection<WorkersInfo> WorkersInfos { get; set; }
    }
}
