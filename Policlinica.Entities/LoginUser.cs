//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Policlinica.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoginUser
    {
        public int Fk_UtilizatorId { get; set; }
        public string UserName { get; set; }
        public byte[] Parola { get; set; }
        public System.DateTime DataInregistrare { get; set; }
    
        public virtual Utilizatori Utilizatori { get; set; }
    }
}
