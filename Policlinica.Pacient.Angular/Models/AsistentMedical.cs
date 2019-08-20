using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class AsistentMedical
    {
        public int FkUtilizatorId { get; set; }
        public int Grad { get; set; }
        public int Tip { get; set; }

        public Utilizatori FkUtilizator { get; set; }
    }
}
