using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class SpecialitateServicii
    {
        public int PkSpecialitatiServiciiId { get; set; }
        public int FkServiciuMedicalId { get; set; }
        public int FkSpecialitateId { get; set; }

        public ServiciiMedicale FkServiciuMedical { get; set; }
        public Specialitati FkSpecialitate { get; set; }
    }
}
