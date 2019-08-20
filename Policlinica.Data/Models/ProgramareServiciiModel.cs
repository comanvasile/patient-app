using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Models
{
    public class ProgramareServiciiModel
    {
        public int SpecialitateId { get; set; }
        public string Nume { get; set; }
        public string Competenta { get; set; }
        public decimal Pret { get; set; }
        public int Durata { get; set; }
        public int Medic { get; set; }
        public DateTime DataProgramare { get; set; }
    }
}
