using Policlinica.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Models
{
    public class AsistentMedicalModel : UtilizatorModel
    {
        public GradAsistentMedical Grad { get; set; }
        public TipAsistentMedical Tip { get; set; }
    }
}
