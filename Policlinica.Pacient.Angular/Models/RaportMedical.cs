using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class RaportMedical
    {
        public int FkServiciuMedicalId { get; set; }
        public string NumePrenumeMedic { get; set; }
        public string NumePrenumePacient { get; set; }
        public DateTime? DataConsultatie { get; set; }
        public string Istoric { get; set; }
        public string Simptome { get; set; }
        public string Investigații { get; set; }
        public string Diagnostic { get; set; }
        public string Recomandări { get; set; }
        public int Status { get; set; }

        public ServiciiMedicale FkServiciuMedical { get; set; }
    }
}
