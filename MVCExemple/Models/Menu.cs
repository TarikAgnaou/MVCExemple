using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExemple.Models
{
    public class Menu
    {
        public string Icone { get; set; }
        public string Nom { get; set; }
        public string Lien { get; set; }
        public string Controller { get; set; }
        public string Methode { get; set; }
    }
}
