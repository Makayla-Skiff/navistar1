using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavistarWebApp.Data
{
    public class Headcount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UserID { get; set; }

        [Display(Name = "User First Name")]
        public string UFname { get; set; }

        [Display(Name = "User Last Name")]
        public string ULname { get; set; }

        [Display(Name = "Date User Created")]
        public DateTime Dsubmitted { get; set; }

        [Display(Name = "Approved Positions")]
        public bool? Approved { get; set; }

        [Display(Name = "Finance Department")]
        public int FDepartment { get; set; }

        [Display(Name = "Finance Entity")]
        public int FEntity { get; set; }

        [Display(Name = "Dept Description")]
        public int DID { get; set; }
        [ForeignKey("DID")]
        public DepartmentPage Departments { get; set; }
    }
}
