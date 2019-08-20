using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Models
{
    public class UtilizatorModel
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
        public Nullable<decimal> Salar { get; set; }
        public int Fk_FunctieId { get; set; }
        public int Fk_RolId { get; set; }
        public int Fk_UnitateMedicalaId { get; set; }
        public string Adresa { get; set; }
    }
}
