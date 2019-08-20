using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class UnitateMedicala
    {
        public UnitateMedicala()
        {
            OrarUnitateMedicala = new HashSet<OrarUnitateMedicala>();
            ServiciiMedicale = new HashSet<ServiciiMedicale>();
            Utilizatori = new HashSet<Utilizatori>();
        }

        public int UnitateMedicalaId { get; set; }
        public string Denumire { get; set; }
        public string DescriereSrvicii { get; set; }

        public Adresa Adresa { get; set; }
        public ICollection<OrarUnitateMedicala> OrarUnitateMedicala { get; set; }
        public ICollection<ServiciiMedicale> ServiciiMedicale { get; set; }
        public ICollection<Utilizatori> Utilizatori { get; set; }
    }
}
