using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavistarWebApp.Data
{
    public class SLTPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Month { get; set; }
        public int Aprroved { get; set; }
        public int Employee { get; set; }
        public int Contractor { get; set; }
        public int Open { get; set; }
    }
}
