using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Roluri
    {
        public Roluri()
        {
            Utilizatori = new HashSet<Utilizatori>();
        }

        public int RolId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public ICollection<Utilizatori> Utilizatori { get; set; }
    }
}
