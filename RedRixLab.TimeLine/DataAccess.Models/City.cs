using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class City
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int LocallityTypeId { get; set; }
        public LocallityType LocallityType { get; set; }
        public string Name { get; set; }
        public ICollection<Street> Streets { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
