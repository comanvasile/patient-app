using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class OrarUnitateMedicala
    {
        public int OrarId { get; set; }
        public int Zi { get; set; }
        public TimeSpan OraDeschidere { get; set; }
        public TimeSpan OraInchidere { get; set; }
        public int FkUnitateMedicalaId { get; set; }

        public UnitateMedicala FkUnitateMedicala { get; set; }
    }
}
