using Policlinica.Data.Enums;
using Policlinica.Data.Models;
using Policlinica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.Services
{
    public class UtilizatoriService
    {
        PoliclinicaDataContext dc;
        public UtilizatoriService(PoliclinicaDataContext dc)
        {
            this.dc = dc;
        }

        public bool ExistaUnitateMedicala()
        {
            return (from u in dc.UnitateMedicala
                    select u).Any();
        }

        public bool ExistaUtilizatori()
        {
            return (from u in dc.Utilizatori
                    select u).Any();
        }

        public void AddUtilizator(Utilizatori utilizator)
        {
            try
            {
                dc.Utilizatori.Add(utilizator);
                dc.SaveChanges();

            }
            catch (Exception)
            {
                utilizator.OrarUtilizatori = null;
                utilizator.Medic = null;
                utilizator.AsistentMedical = null;
                utilizator.LoginUser = null;
                utilizator.UnitateMedicala = null;
                utilizator = null;
                throw;
            }
        }

        public DateTime GetPrimaAngajare(int unitateId)
        {
            return dc.Utilizatori.OrderBy(d => d.DataAngajare).Where(u => u.Fk_UnitateMedicalaId == unitateId).Select(p => p.DataAngajare).Take(1).SingleOrDefault();
        }

        public IList<Specialitati> GetSpecialitati(int utilizatorId)
        {
            //var list = (List<Specialitati>)dc.Medic.Include("Specialitati").Where(u => u.Fk_UtilizatorId == utilizatorId).Select(s => s.Specialitati);
            //var list2 = dc.Medic.Include("Specialitati").Where(u => u.Fk_UtilizatorId == utilizatorId);
            //return (from m in dc.Medic
            //        where m.Fk_UtilizatorId == utilizatorId
            //        select m.Specialitati.ToList()).ToList();
            return (from spec in dc.Specialitati
                          where spec.Medic.Any(m => m.Fk_UtilizatorId == utilizatorId)
                          select spec).ToList();
            //return list;
        }

        public IList<Specialitati> GetSpecialitati()
        {
            return (from s in dc.Specialitati
                    select s).ToList();
        }

        public IList<MedicModel> GetMedici(int unitateMedicalaId)
        {
            return (from m in dc.Medic
                    join u in dc.Utilizatori on m.Fk_UtilizatorId equals u.UtilizatorId
                    where u.Fk_UnitateMedicalaId == unitateMedicalaId
                    select new MedicModel
                    {
                        Grad = (GradMedic)m.Grad,
                        CodulDeParafa = m.CodulDeParafa,
                        TitlulStiintific = (TitluStiintific)m.TitlulStiintific,
                        PostulDidactic = (PostDidactic)m.PostulDidactic,
                        ProcentServicii = m.ProcentServicii,
                        UtilizatorId = u.UtilizatorId,
                        CNP = u.CNP,
                        Nume = u.Nume,
                        Prenume = u.Prenume,
                        Telefon = u.Telefon,
                        Email = u.Email,
                        IBAN = u.IBAN,
                        NumarContract = u.NumarContract,
                        DataAngajare = u.DataAngajare,
                        Salar = u.Salar,
                        Fk_FunctieId = u.Fk_FunctieId,
                        Fk_RolId = u.Fk_RolId,
                        Fk_UnitateMedicalaId = u.Fk_UnitateMedicalaId,
                        Adresa = u.Adresa
                    }).ToList();
        }

        public void AddUnitateMedicala(UnitateMedicala um, Adresa adresa, List<OrarUnitateMedicala> orar)
        {
            try
            {
                um.Adresa = adresa;
                um.OrarUnitateMedicala = orar;
                dc.UnitateMedicala.Add(um);
                dc.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUtilizatorById(int utilizatorId)
        {
            try
            {
                var utilizator = dc.Utilizatori.Select(u => u).Where(w => w.UtilizatorId == utilizatorId).SingleOrDefault();
                dc.Utilizatori.Remove(utilizator);
                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Medic GetMedicById(int utilizatorId)
        {
            return dc.Medic.Where(m => m.Fk_UtilizatorId == utilizatorId).SingleOrDefault();
        }

        public void UpdateMedic(Medic medic)
        {
            dc.Medic.Attach(medic);
            dc.Entry<Medic>(medic).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
        }

        public Specialitati GetSpecilateById(int specialitateId)
        {
            return dc.Specialitati.Where(s => s.SpecialitateId == specialitateId).SingleOrDefault();
        }

        public UnitateMedicala GetUnitateMedicalaById(int id)
        {
            return dc.UnitateMedicala.Where(u => u.UnitateMedicalaId == id).SingleOrDefault();
        }

        public void AddOrarUtilizator(OrarUtilizatori zi)
        {
            try
            {
                dc.OrarUtilizatori.Add(zi);
                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateOrarUtilizator(OrarUtilizatori zi)
        {
            try
            {
                dc.Entry<OrarUtilizatori>(zi).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExistaUserName(string text)
        {
            return (from u in dc.LoginUser
                    select u).Where(u => u.UserName == text).Any();
        }

        public Dictionary<int, string> GetRoluri()
        {
            return (from r in dc.Roluri
                    select new
                    {
                        r.RolId,
                        r.Nume
                    }).ToDictionary(key => key.RolId, value => value.Nume);
        }
        public Dictionary<int, string> GetFunctii(int departamentId)
        {
            return (from f in dc.FunctiiDepartament
                    where f.Fk_DepartamentId == departamentId
                    select new
                    {
                        f.FunctieId,
                        f.Functie
                    }).ToDictionary(key => key.FunctieId, value => value.Functie);
        }

        public IList<OrarUtilizatorModel> GetOrarUtilizator(int utilizatorId)
        {
            return (from o in dc.OrarUtilizatori
                    where o.Fk_UtilizatorId == utilizatorId
                    select new OrarUtilizatorModel
                    {
                        OrarId = o.OrarId,
                        Fk_UtilizatorId = o.Fk_UtilizatorId,
                        Zi = (ZileOrar)o.Zi,
                        IncepereProgram = o.IncepereProgram,
                        SfarsitProgram = o.SfarsitProgram,
                        DataZiSpeciala = o.DataZiSpeciala
                    }).ToList();
        }

        public Dictionary<int, string> GetDepartamente()
        {
            return (from d in dc.Departament
                    select new
                    {
                        d.DepartamentId,
                        d.Nume
                    }).ToDictionary(key => key.DepartamentId, value => value.Nume);
        }
        public Dictionary<int, string> GetUnitatiMedicale()
        {
            return (from um in dc.UnitateMedicala
                    select new
                    {
                        um.UnitateMedicalaId,
                        um.Denumire
                    }).ToDictionary(key => key.UnitateMedicalaId, value => value.Denumire);
        }
        public int GetNrContract()
        {
            int nrContract = 0;
            if ((from u in dc.Utilizatori
                 select u).Any())
            {
                nrContract = (from u in dc.Utilizatori
                              orderby u.NumarContract descending
                              select u.NumarContract).Take(1).SingleOrDefault<int>();
            }

            return nrContract + 1;
        }

        public void AddUtilizator(Utilizatori utilizator, Medic medic, ICollection<OrarUtilizatori> collection, LoginUser loginUser)
        {
            try
            {                
               
                medic.Utilizatori = utilizator;
                dc.Medic.Add(medic);
                loginUser.Utilizatori = utilizator;
                dc.LoginUser.Add(loginUser);
                utilizator.OrarUtilizatori = collection;
                //dc.Entry(utilizator).State = System.Data.Entity.EntityState.Modified;
                utilizator.OrarUtilizatori = collection;
                dc.Utilizatori.Add(utilizator);
                dc.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateUtilizator(Utilizatori utilizator)
        {
            try
            {
                dc.Entry<Utilizatori>(utilizator).State = System.Data.Entity.EntityState.Modified;
                                
                dc.SaveChanges();
            }
            catch (Exception)
            {
                utilizator.OrarUtilizatori = null;
                utilizator.Medic = null;
                utilizator.AsistentMedical = null;
                utilizator.LoginUser = null;
                utilizator.UnitateMedicala = null;
                utilizator = null;
                throw;
            }
        }

        public String GetFunctieById(int id)
        {
            return (from f in dc.FunctiiDepartament
                    where f.FunctieId == id
                    select f.Functie).SingleOrDefault();
        }

        public Utilizatori GetUtilizatorById(int id)
        {
            return dc.Utilizatori.Find(id);
        }
    }
}
