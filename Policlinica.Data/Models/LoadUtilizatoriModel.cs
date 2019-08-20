using Policlinica.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Models
{
    public class LoadUtilizatoriModel
    {
        public int UtilizatorId { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string IBAN { get; set; }
        public int NumarContract { get; set; }
        public System.DateTime DataAngajare { get; set; }
        public decimal Salar { get; set; }
        public string Adresa { get; set; }
        public Nullable<GradAsistentMedical> GradAsistent { get; set; }
        public Nullable<TipAsistentMedical> TipAsistent { get; set; }
        public Nullable<GradMedic> GradMedic { get; set; }
        public string CodulDeParafa { get; set; }
        public Nullable<TitluStiintific> TitlulStiintific { get; set; }
        public Nullable<PostDidactic> PostulDidactic { get; set; }
        public Nullable<decimal> ProcentServicii { get; set; }
        public string Rol { get; set; }
        public string Functie { get; set; }
        public string Departament { get; set; }
        public string UnitateMedicala { get; set; }
    }
}
