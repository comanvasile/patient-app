using System;
using System.Collections.Generic;

namespace Policlinica.Pacient.Angular.Models
{
    public partial class LoginUser
    {
        public int FkUtilizatorId { get; set; }
        public string UserName { get; set; }
        public byte[] Parola { get; set; }
        public DateTime DataInregistrare { get; set; }

        public Utilizatori FkUtilizator { get; set; }
    }
}
