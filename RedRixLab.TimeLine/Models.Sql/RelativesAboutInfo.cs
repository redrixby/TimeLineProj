using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class RelativesAboutInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RelativeTypeId { get; set; }
        public RelativeType RelativeType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public ICollection<RelativesAddress> RelativesAddresses { get; set; }
    }
}
