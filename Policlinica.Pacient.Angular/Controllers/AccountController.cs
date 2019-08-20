using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Policlinica.Pacient.Angular.Models;
using Policlinica.Pacient.Angular.ModelsApp;

namespace Policlinica.Pacient.Angular.Controllers
{
    //[Route("http://localhost:4200/api/[controller]")]
    public class AccountController : Controller
    {
        private int receptionerId = 8;
        private string dateFormat = "dd-MM-yyyy HH:mm";
        private CultureInfo provider = CultureInfo.InvariantCulture;
        [HttpPost]
        [Route("/api/create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Create([FromBody] Models.Pacient pacient)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                pc.Pacient.Add(pacient);
                pc.SaveChanges();
                //if(pacient == "ok")
                //PacientiService service = new PacientiService(new PoliclinicaDataContext());
                //service.AddPacient((Entities.Pacient)pacient);

                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
                //else
                //    throw new Exception("nu exista");
            }
            catch (Exception ex)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }

        }
        [HttpPost]
        [Route("/api/createlogin")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateLogin([FromBody] Models.LoginPacient loginPacient)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                Models.Pacient pac = pc.Pacient.Last();
                loginPacient.DataInregistrare = DateTime.Now;
                loginPacient.FkPacientId = pac.PacientId;
                pc.LoginPacient.Add(loginPacient);
                pc.SaveChanges();
                //if(pacient == "ok")
                //PacientiService service = new PacientiService(new PoliclinicaDataContext());
                //service.AddPacient((Entities.Pacient)pacient);

                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
                //else
                //    throw new Exception("nu exista");
            }
            catch (Exception ex)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }

        }

        [HttpPost]
        [Route("/api/login")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Login([FromBody] Models.LoginPacient loginPacient)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                if(pc.LoginPacient.Any(p => p.UserName == loginPacient.UserName && p.Parola == loginPacient.Parola))
                    return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
                else
                    return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }

        }

        [HttpGet]
        [Route("/api/unitati")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IEnumerable<UnitateMedicala> GetUnitati()
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                var lista = pc.UnitateMedicala.Select(u => u).ToList();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpGet]
        [Route("/api/medici/{denumire}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IEnumerable<string> GetMedici(string denumire)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                var unitateID = pc.UnitateMedicala.Where(u => u.Denumire == denumire).FirstOrDefault().UnitateMedicalaId;
                var listaU = pc.Utilizatori.Where(u => u.FkUnitateMedicalaId == unitateID).ToList();
                var listaM = pc.Medic.ToList();
                return (from u in listaU
                        join m in listaM on u.UtilizatorId equals m.FkUtilizatorId
                        select u.Nume + " " + u.Prenume).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("/api/specialitati/{denumire}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IEnumerable<string> GetSpecialitati(string denumire)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                var medicID = pc.Utilizatori.Where(u => u.Nume +" " + u.Prenume == denumire).FirstOrDefault().UtilizatorId;
                var listaMS = pc.MedicSpecialitati.Where(u => u.FkMedicId == medicID).ToList();
                var listaS = pc.Specialitati.ToList();
                return (from u in listaMS
                        join m in listaS on u.FkSpecialitateId equals m.SpecialitateId
                        select m.Nume).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("/api/createprogramare")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateProgramare([FromBody] Policlinica.Pacient.Angular.ModelsApp.Programare programare)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                var pacientId = pc.LoginPacient.Where(p => p.UserName == programare.Pacient).FirstOrDefault().FkPacientId;
                var medicId = pc.Utilizatori.Where(u => u.Nume + " " + u.Prenume == programare.Medic).FirstOrDefault().UtilizatorId;
                var unitateID = pc.UnitateMedicala.Where(u => u.Denumire == programare.UnitateMedicala).FirstOrDefault().UnitateMedicalaId;
                var specialitateID = pc.Specialitati.Where(u => u.Nume == programare.Specialitate).FirstOrDefault().SpecialitateId;
                var data = /*DateTime.Now.AddDays(2);*/ DateTime.ParseExact(programare.Data, dateFormat, provider);
                ProgramariServicii programariServicii = new ProgramariServicii()
                {
                    FkPacientId = pacientId,
                    FkReceptionerId = receptionerId,
                    DataProgramare = data
                };
                ServiciiMedicale serviciiMedicale = new ServiciiMedicale()
                {
                    Durata = 30,
                    FkUnitateMedicala = unitateID,
                    FkMedicId = medicId,
                    FkProgramare = programariServicii
                };
                SpecialitateServicii specialitateServicii = new SpecialitateServicii()
                {
                    FkSpecialitateId = specialitateID,
                    FkServiciuMedical = serviciiMedicale
                };
                pc.ProgramariServicii.Add(programariServicii);
                pc.ServiciiMedicale.Add(serviciiMedicale);
                pc.SpecialitateServicii.Add(specialitateServicii);
                pc.SaveChanges();
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }

        }

        [HttpGet]
        [Route("/api/programari/{username}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IEnumerable<string> GetProgramari(string username)
        {
            try
            {
                Models.PoliclinicaPacientiContext pc = new Models.PoliclinicaPacientiContext();
                var pacient = (from lp in pc.LoginPacient.ToList()
                               join p in pc.Pacient.ToList() on lp.FkPacientId equals p.PacientId
                               where lp.UserName == username
                               select p).FirstOrDefault();
                return (from ps in pc.ProgramariServicii.ToList()
                        join sm in pc.ServiciiMedicale.ToList() on ps.ProgramareId equals sm.FkProgramareId
                        join u in pc.Utilizatori.ToList() on sm.FkMedicId equals u.UtilizatorId
                        join um in pc.UnitateMedicala.ToList() on sm.FkUnitateMedicala equals um.UnitateMedicalaId
                        join ss in pc.SpecialitateServicii.ToList() on sm.ServiciuMedicalId equals ss.FkServiciuMedicalId
                        join s in pc.Specialitati.ToList() on ss.FkSpecialitateId equals s.SpecialitateId
                        where ps.FkPacientId == pacient.PacientId
                        //select new Programare()
                        //{
                        //    UnitateMedicala = um.Denumire,
                        //    Medic = u.Nume + " " + u.Prenume,
                        //    Specialitate = s.Nume,
                        //    //ProgramareId = ps.ProgramareId,
                        //    Pacient = pacient.Nume + " " + pacient.Prenume,
                        //    Data = ps.DataProgramare.ToString(dateFormat)
                        select string.Format("{0}@{1}@{2}@{3}@{4}", um.Denumire, u.Nume+" "+u.Prenume,s.Nume, pacient.Nume+ " "+pacient.Prenume, ps.DataProgramare.ToString(dateFormat))
                        ).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
