using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class Place
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PlaceTypeId { get; set; }
        public PlaceType PlaceType { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
