using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Pacient
    {
        public Pacient()
        {
            ProgramariServicii = new HashSet<ProgramariServicii>();
        }

        public int PacientId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cnp { get; set; }
        public string CardSanatate { get; set; }
        public string Ocupatie { get; set; }
        public string Email { get; set; }

        public LoginPacient LoginPacient { get; set; }
        public ICollection<ProgramariServicii> ProgramariServicii { get; set; }
    }
}
