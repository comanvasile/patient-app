using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class MedicSpecialitati
    {
        public int PkMedicaSpecialitatiId { get; set; }
        public int FkMedicId { get; set; }
        public int FkSpecialitateId { get; set; }

        public Medic FkMedic { get; set; }
        public Specialitati FkSpecialitate { get; set; }
    }
}
