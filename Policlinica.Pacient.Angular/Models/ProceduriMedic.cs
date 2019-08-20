using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class ProceduriMedic
    {
        public int ProceduraMedicId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int FkMedicId { get; set; }

        public Medic FkMedic { get; set; }
    }
}
