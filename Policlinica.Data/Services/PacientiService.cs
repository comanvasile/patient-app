using Policlinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Services
{
    public class PacientiService
    {
        PoliclinicaDataContext dc;
        public PacientiService(PoliclinicaDataContext dc)
        {
            this.dc = dc;
        }

        public void AddPacient(Pacient pacient)
        {
            dc.Pacient.Add(pacient);

            dc.SaveChanges();
        }
    }
}
