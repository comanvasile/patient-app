using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class BonuriFiscale
    {
        public int BonFiscalId { get; set; }
        public DateTime DataEmitere { get; set; }
        public int FkProgramareId { get; set; }

        public ProgramariServicii FkProgramare { get; set; }
    }
}
