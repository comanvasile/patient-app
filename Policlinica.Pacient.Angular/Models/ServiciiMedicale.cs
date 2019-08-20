using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class ServiciiMedicale
    {
        public ServiciiMedicale()
        {
            SpecialitateServicii = new HashSet<SpecialitateServicii>();
        }

        public int ServiciuMedicalId { get; set; }
        public string Competenta { get; set; }
        public decimal? Pret { get; set; }
        public int Durata { get; set; }
        public int FkUnitateMedicala { get; set; }
        public int? FkMedicId { get; set; }
        public int FkProgramareId { get; set; }

        public Medic FkMedic { get; set; }
        public ProgramariServicii FkProgramare { get; set; }
        public UnitateMedicala FkUnitateMedicalaNavigation { get; set; }
        public RaportMedical RaportMedical { get; set; }
        public ICollection<SpecialitateServicii> SpecialitateServicii { get; set; }
    }
}
