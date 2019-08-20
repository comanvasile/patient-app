using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Adresa
    {
        public int FkUnitateMedicalaId { get; set; }
        public string Numar { get; set; }
        public string Judet { get; set; }
        public string Localitate { get; set; }
        public string Adresa1 { get; set; }

        public UnitateMedicala FkUnitateMedicala { get; set; }
    }
}
