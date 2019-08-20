using Policlinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Services
{
    public class ActivitateService
    {
        PoliclinicaDataContext dc;
        public ActivitateService(PoliclinicaDataContext dc)
        {
            this.dc = dc;
        }

        public Dictionary<int, string> GetPacienti()
        {
            return (from p in dc.Pacient
                    select new
                    {
                       p.PacientId,
                       Nume = (p.Nume + " " + p.Prenume)
                    }).ToDictionary(key => key.PacientId, value => value.Nume);
        }

        public IList<Pacient> GetPacientiAll()
        {
            return (from p in dc.Pacient
                    select p).ToList();
        }

        public void AddPacient(Pacient pacient)
        {
            try
            {
                dc.Pacient.Add(pacient);
                dc.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Pacient GetPacientById(int pacientId)
        {
            return dc.Pacient.Find(pacientId);
        }

        public string GetPacientString(int serviciuMedicalId)
        {
            int pacientId = (from s in dc.ServiciiMedicale
                             join p in dc.ProgramariServicii on s.Fk_ProgramareId equals p.ProgramareId
                             select p.Fk_PacientId).Take(1).SingleOrDefault();
            var pacient = this.GetPacientById(pacientId);
            return pacient.Nume + " " + pacient.Prenume;
        }

        public void UpdatePacient(Pacient pacient)
        {
            try
            {
                dc.Entry<Pacient>(pacient).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateProgramare(ProgramariServicii programare)
        {
            try
            {
                dc.Entry<ProgramariServicii>(programare).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ServiciiMedicale GetServiciuById(int id)
        {
            return dc.ServiciiMedicale.Find(id);
        }

        public ProgramariServicii GetProgramareById(int id)
        {
            return dc.ProgramariServicii.Find(id);
        }

        public void AddRaportMedical(RaportMedical raport)
        {
            try
            {
                dc.RaportMedical.Add(raport);

                var programare = this.GetProgramareById(this.GetServiciuById(raport.Fk_ServiciuMedicalId).Fk_ProgramareId);
                programare.Realizata = true;
                dc.Entry<ProgramariServicii>(programare).State = System.Data.Entity.EntityState.Modified;

                dc.SaveChanges(); 
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
