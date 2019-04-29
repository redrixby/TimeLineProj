using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int StreetId { get; set; }
        public Street Street { get; set; }
        public int HouseNumber { get; set; }
        public string Corps { get; set; }
        public string RoomNumber { get; set; }
        public int Index { get; set; }
        public string Phone { get; set; }
        public ICollection<RelativesAddress> RelativesAddresses { get; set; }
        public ICollection<Place> Places { get; set; }
        public ICollection<JobsInfo> JobsInfos { get; set; }
    }
}
