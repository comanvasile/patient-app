using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class ProgramariServicii
    {
        public ProgramariServicii()
        {
            BonuriFiscale = new HashSet<BonuriFiscale>();
            ServiciiMedicale = new HashSet<ServiciiMedicale>();
        }

        public int ProgramareId { get; set; }
        public int FkPacientId { get; set; }
        public int FkReceptionerId { get; set; }
        public DateTime DataProgramare { get; set; }
        public bool? Realizata { get; set; }

        public Pacient FkPacient { get; set; }
        public Utilizatori FkReceptioner { get; set; }
        public ICollection<BonuriFiscale> BonuriFiscale { get; set; }
        public ICollection<ServiciiMedicale> ServiciiMedicale { get; set; }
    }
}
