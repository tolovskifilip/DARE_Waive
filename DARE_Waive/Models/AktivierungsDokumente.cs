using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DARE_Waive.Models
{
    public class AktivierungsDokumente
    {
        [Required]
        public int ID { get; set; }
        [Required]
        DateTime TimeInterval { get; set; }
        [Required]
        string Anschlussnetzbetreiber { get; set; }
        [Required]
        string Anschlussnetzbetreiber_ID_Sender { get; set; }
        [Required]
        string Anschlussnetzbetreiber_ID_Receiver { get; set; }
        [Required]
        string SR_ID { get; set; }
        [Required]
        string System_Operator_or_Internal_Redispatching_Code { get; set; }
        [Required]
        double positive_Redispatch_Aktivierung { get; set; }
        [Required]
        double negative_Redispatch_Aktivierung { get; set; }

    }
}
