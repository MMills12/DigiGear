using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingWebsite.Models
{
    public class Schedule
    {
        [Key]
        public int SyllabusId { get; set; }
        public int Week { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
    }
}