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
    
    public partial class FunctiiDepartament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FunctiiDepartament()
        {
            this.Utilizatori = new HashSet<Utilizatori>();
        }
    
        public int FunctieId { get; set; }
        public string Functie { get; set; }
        public int Fk_DepartamentId { get; set; }
    
        public virtual Departament Departament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizatori> Utilizatori { get; set; }
    }
}
