//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegion()
        {
            this.tblAddress = new HashSet<tblAddress>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Fk_City { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAddress> tblAddress { get; set; }
        public virtual tblCity tblCity { get; set; }
    }
}
