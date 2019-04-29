using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Api.Models
{
    public class RelativesAddress
    {
        public int Id { get; set; }
        public int RelativesAboutInfoId { get; set; }
        public RelativesAboutInfo RelativesAboutInfo { get; set; }
        public int AddressId { get; set; } 
        public Address Address { get; set; }
        public  bool AddressType { get; set; }
    }
}
