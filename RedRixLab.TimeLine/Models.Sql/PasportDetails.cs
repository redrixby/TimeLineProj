using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.Sql
{
    public class PasportDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string PasportSeries { get; set; }
        public string PasportNumber { get; set; }
        public string IssuedBy { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime FinishDate { get; set; }
        public int TLid { get; set; }
    }
}
