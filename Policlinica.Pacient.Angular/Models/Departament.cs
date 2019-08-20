using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Departament
    {
        public Departament()
        {
            FunctiiDepartament = new HashSet<FunctiiDepartament>();
        }

        public int DepartamentId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public ICollection<FunctiiDepartament> FunctiiDepartament { get; set; }
    }
}
