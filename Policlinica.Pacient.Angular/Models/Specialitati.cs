using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Specialitati
    {
        public Specialitati()
        {
            MedicSpecialitati = new HashSet<MedicSpecialitati>();
            SpecialitateServicii = new HashSet<SpecialitateServicii>();
        }

        public int SpecialitateId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public ICollection<MedicSpecialitati> MedicSpecialitati { get; set; }
        public ICollection<SpecialitateServicii> SpecialitateServicii { get; set; }
    }
}
