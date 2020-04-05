using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExemple.Models
{
    public class Identity
    {
        [Display(Name = "Numéro d'enregistrement")]
        public int Id { get; set; }

        [Display(Name = "Nom de famille")]
        public string Nom { get; set; }
        public string Prenom { get; set; }

        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
