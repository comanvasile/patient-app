using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class LoginPacient
    {
        public int FkPacientId { get; set; }
        public string UserName { get; set; }
        public string Parola { get; set; }
        public DateTime DataInregistrare { get; set; }

        public Pacient FkPacient { get; set; }
    }
}
