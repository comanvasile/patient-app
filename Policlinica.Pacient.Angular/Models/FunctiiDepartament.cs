using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class FunctiiDepartament
    {
        public FunctiiDepartament()
        {
            Utilizatori = new HashSet<Utilizatori>();
        }

        public int FunctieId { get; set; }
        public string Functie { get; set; }
        public int FkDepartamentId { get; set; }

        public Departament FkDepartament { get; set; }
        public ICollection<Utilizatori> Utilizatori { get; set; }
    }
}
