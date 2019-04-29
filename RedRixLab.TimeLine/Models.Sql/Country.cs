using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Region> Regions { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}