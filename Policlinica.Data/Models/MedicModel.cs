using Policlinica.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Models
{
    public class MedicModel : UtilizatorModel
    {
        public GradMedic Grad { get; set; }
        public string CodulDeParafa { get; set; }
        public TitluStiintific TitlulStiintific { get; set; }
        public PostDidactic PostulDidactic { get; set; }
        public Nullable<decimal> ProcentServicii { get; set; }
    }
}
