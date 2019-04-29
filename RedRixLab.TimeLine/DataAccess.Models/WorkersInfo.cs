using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class WorkersInfo
    {
        public int Id { get; set; }
        public int WorkersId { get; set; }
        public Workers Workers { get; set; }
        public DateTime DateOrderNumber { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateRegistration { get; set; }
        public int ReasonId { get; set; }
        public Reason Reason { get; set; }
        public double WorkExperience { get; set; }
        public DateTime DateTransfer { get; set; }
        public string OrderNumberForTransfer { get; set; }
    }
}
