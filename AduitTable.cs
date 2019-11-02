using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavistarWebApp.Data
{
    public class AduitTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AID { get; set; }

        public string SLT { get; set; }


        [Display(Name = "Approved Positions")]
        [ForeignKey("Approved")]
        public Headcount Appr { get; set; }

        [Display(Name = "Employee Count")]
        public int ECount { get; set; }

        [Display(Name = "Contractor Count")]
        public int CCount { get; set; }

        [Display(Name = "Open Position Count")]
        public int OCount { get; set; }

        [Display(Name = "Time Stamp")]
        public DateTime DTStamp { get; set; }

        [Display(Name = "Update or Submit")]
        public string UorS { get; set; }

    }
}
