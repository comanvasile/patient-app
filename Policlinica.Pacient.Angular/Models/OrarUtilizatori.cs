using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class OrarUtilizatori
    {
        public int OrarId { get; set; }
        public int Zi { get; set; }
        public TimeSpan IncepereProgram { get; set; }
        public TimeSpan SfarsitProgram { get; set; }
        public DateTime? DataZiSpeciala { get; set; }
        public int FkUtilizatorId { get; set; }

        public Utilizatori FkUtilizator { get; set; }
    }
}
