using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Street
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int StreetTypeId { get; set; }
        public StreetType StreetType { get; set; }
        public string Name { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
