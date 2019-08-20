using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Medic
    {
        public Medic()
        {
            MedicSpecialitati = new HashSet<MedicSpecialitati>();
            ProceduriMedic = new HashSet<ProceduriMedic>();
            ServiciiMedicale = new HashSet<ServiciiMedicale>();
        }

        public int FkUtilizatorId { get; set; }
        public int Grad { get; set; }
        public string CodulDeParafa { get; set; }
        public int? TitlulStiintific { get; set; }
        public int? PostulDidactic { get; set; }
        public decimal? ProcentServicii { get; set; }

        public Utilizatori FkUtilizator { get; set; }
        public ICollection<MedicSpecialitati> MedicSpecialitati { get; set; }
        public ICollection<ProceduriMedic> ProceduriMedic { get; set; }
        public ICollection<ServiciiMedicale> ServiciiMedicale { get; set; }
    }
}
