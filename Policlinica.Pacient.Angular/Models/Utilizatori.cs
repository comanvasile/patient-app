using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class Utilizatori
    {
        public Utilizatori()
        {
            OrarUtilizatori = new HashSet<OrarUtilizatori>();
            ProgramariServicii = new HashSet<ProgramariServicii>();
        }

        public int UtilizatorId { get; set; }
        public string Cnp { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Iban { get; set; }
        public int NumarContract { get; set; }
        public DateTime DataAngajare { get; set; }
        public decimal Salar { get; set; }
        public int FkFunctieId { get; set; }
        public int FkRolId { get; set; }
        public int FkUnitateMedicalaId { get; set; }
        public string Adresa { get; set; }

        public FunctiiDepartament FkFunctie { get; set; }
        public Roluri FkRol { get; set; }
        public UnitateMedicala FkUnitateMedicala { get; set; }
        public AsistentMedical AsistentMedical { get; set; }
        public LoginUser LoginUser { get; set; }
        public Medic Medic { get; set; }
        public ICollection<OrarUtilizatori> OrarUtilizatori { get; set; }
        public ICollection<ProgramariServicii> ProgramariServicii { get; set; }
    }
}
