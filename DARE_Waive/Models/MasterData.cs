using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DARE_Waive.Models
{
    public class MasterData
    {
        [Required]
        public int ID { get; set; }
        [Required]
        string Klarname { get; set; }
        [Required]
        string Anschlussnetzbetreiber { get; set; }
        [Required]
        string Anschlussnetzbetreiber_ID { get; set; }
        [Required]
        string SR_ID { get; set; }
        [Required]
        string Energietraeger { get; set; }
        [Required]
        string Regelzone { get; set; }
        [Required]
        string Klarname_TR { get; set; }
        [Required]
        string TR_ID { get; set; }
        [Required]
        double Nettonennleistung { get; set; } 
        [Required]
        double Geokoordinaten_lon { get; set; }
        [Required]
        double Geokoordinaten_lat { get; set; }

    }
}
