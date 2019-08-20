using Policlinica.Data.Models;
using Policlinica.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica.Data.StoredProcedures
{
    public class ProceduriStocateService
    {
        PoliclinicaDataContext dc;
        public ProceduriStocateService(PoliclinicaDataContext dc)
        {
            this.dc = dc;
        }

        public UtilizatorModel LoginUserPoliclinica(string userName, byte[] parola)
        {
            var userParam = new SqlParameter
            {
                ParameterName = "userName",
                Value = userName
            };
            var passParam = new SqlParameter
            {
                ParameterName = "parola",
                Value = parola
            };
            return dc.Database.SqlQuery<UtilizatorModel>("exec LoginUserPoliclinica @userName, @parola ", userParam, passParam).SingleOrDefault<UtilizatorModel>();
        }

        public IList<LoadPacientiMedic_Result> LoadPacientiMedic(bool @checked,int fk_UnitateMedicalaId, int utilizatorId)
        {
            
                var item = dc.LoadPacientiMedic(@checked, fk_UnitateMedicalaId, utilizatorId).ToList();
            return item;
        }

        public IList<LoadSpecialitatiUnitate_Result> LoadSpecialitatiUnitate(int unitateMedicalaId)
        {
            return dc.LoadSpecialitatiUnitate(unitateMedicalaId).ToList();
        }

        public IList<LoadUtilizatoriModel> LoadUtilizatori(int unitateMedicalaId)
        {
            var unitateMedicalaParam = new SqlParameter
            {
                ParameterName = "unitateMedicalaId",
                Value = unitateMedicalaId
            };
            return dc.Database.SqlQuery<LoadUtilizatoriModel>("exec LoadUtilizatori @unitateMedicalaId", unitateMedicalaParam).ToList<LoadUtilizatoriModel>();
        }

        public IList<LoadPacientiAsistent_Result> LoadPacientiAsistent(bool @checked, int fk_UnitateMedicalaId)
        {
            var item = dc.LoadPacientiAsistent(@checked, fk_UnitateMedicalaId).ToList();
            return item;
        }

        public void InsertMedicSpecialitati(int medicId, int specialitateId)
        {
            dc.InsertMedicSpecialitati(medicId, specialitateId);
        }

        public void DeleteFromMedicSpecialitati(int medicId)
        {
            dc.DeleteFromMedicSpecialitati(medicId);
        }

        public Dictionary<int, string> GetMedici(int specialitateId, int unitateMedicalaId)
        {
            var medici = dc.LoadMediciBySpecialitateId(specialitateId, unitateMedicalaId).ToList();
            return (from m in medici
                    select new
                    {
                        m.Fk_UtilizatorId,
                        Nume = m.Nume
                    }).ToDictionary(key => key.Fk_UtilizatorId, value => value.Nume);
        }

        public IList<LoadIstoricPacient_Result> LoadIstoricPacient(int pacientId)
        {
            return dc.LoadIstoricPacient(pacientId).ToList();
        }

        public void InserProgramariServicii(Nullable<int> pacientId, Nullable<int> receptionerId, Nullable<System.DateTime> dataProgramare, Nullable<bool> realizata, string competenta, Nullable<decimal> pret, Nullable<int> durata, Nullable<int> unitateMedicalaId, Nullable<int> medicId, Nullable<int> specialitateId)
        {
            dc.InsertProgramariServicii(pacientId, receptionerId, dataProgramare, realizata, competenta, pret, durata, unitateMedicalaId, medicId, specialitateId);
        }

        public IList<Venituri_Result> GetVenituri(int an, int luna, int unitateId)
        {
            return dc.Venituri(an, luna, unitateId).ToList();
        }

        public IList<Cheltuieli_Result> GetCheltuieli(int an, int luna, int unitateId)
        {
            return dc.Cheltuieli(an, luna, unitateId).ToList();
        }

        public IList<SalariiMedic_Result> GetSalariiMedic(int an, int luna, int medicId)
        {
            return dc.SalariiMedic(an, luna, medicId).ToList();
        }

    }
}
