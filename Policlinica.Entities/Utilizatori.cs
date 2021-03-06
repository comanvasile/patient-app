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
    
    public partial class Utilizatori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilizatori()
        {
            this.OrarUtilizatori = new HashSet<OrarUtilizatori>();
            this.ProgramariServicii = new HashSet<ProgramariServicii>();
        }
    
        public int UtilizatorId { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string IBAN { get; set; }
        public int NumarContract { get; set; }
        public System.DateTime DataAngajare { get; set; }
        public decimal Salar { get; set; }
        public int Fk_FunctieId { get; set; }
        public int Fk_RolId { get; set; }
        public int Fk_UnitateMedicalaId { get; set; }
        public string Adresa { get; set; }
    
        public virtual AsistentMedical AsistentMedical { get; set; }
        public virtual FunctiiDepartament FunctiiDepartament { get; set; }
        public virtual LoginUser LoginUser { get; set; }
        public virtual Medic Medic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrarUtilizatori> OrarUtilizatori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramariServicii> ProgramariServicii { get; set; }
        public virtual Roluri Roluri { get; set; }
        public virtual UnitateMedicala UnitateMedicala { get; set; }
    }
}
