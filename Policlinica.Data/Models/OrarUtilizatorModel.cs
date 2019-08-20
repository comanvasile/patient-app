using Policlinica.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Models
{
    public class OrarUtilizatorModel
    {
        public int OrarId { get; set; }
        public Nullable<ZileOrar> Zi { get; set; }
        public System.TimeSpan SfarsitProgram { get; set; }
        public Nullable<System.DateTime> DataZiSpeciala { get; set; }
        public int Fk_UtilizatorId { get; set; }
        public System.TimeSpan IncepereProgram { get; set; }

    }
}
