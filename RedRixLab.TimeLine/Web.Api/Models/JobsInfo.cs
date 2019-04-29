using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Web.Api.Models
{
    public class JobsInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string WorkPlace { get; set; }
        public int AddressId { get; set; }
        public Address WorkAddress { get; set; }
        public int SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public bool FullTimeEmployee { get; set; }
        public bool Teacher { get; set; }
        public bool Retiree { get; set; }
        public bool PartTimeJob { get; set; }
        public bool PositionPartTimeJob { get; set; }
        public double NumberOfBets { get; set; }
        public bool UnionMember { get; set; }
        public bool TempReplacementOfMainEmployee { get; set; }
        public DateTime DateOfCompetition { get; set; }
        public bool ChildChildcareLeave { get; set; }
        public DateTime DateCLStart { get; set; }
        public DateTime DateCLEnd { get; set; }

    }
}
