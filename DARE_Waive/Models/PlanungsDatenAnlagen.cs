using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DARE_Waive.Models
{
    public class PlanungsDatenAnlagen
    {
        [Required]
        public int ID { get; set; }
        [Required]
        string Klarname { get; set; }
        [Required]
        string Anschlussnetzbetreiber_ID { get; set; }
        [Required]
        string SR_ID { get; set; }
        [Required]
        DateTime TimeInterval { get; set; }
        [Required]
        double Erzeugungsprognose { get; set; }
        [Required]
        double positive_Redispatch_Vermoegen { get; set; }
        [Required]
        double negative_Redispatch_Vermoegen { get; set; }

    }
}
