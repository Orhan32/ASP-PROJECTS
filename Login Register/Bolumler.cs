//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login_Register
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bolumler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bolumler()
        {
            this.Dersler = new HashSet<Dersler>();
            this.Ogrenciler = new HashSet<Ogrenciler>();
        }
    
        public int BolumID { get; set; }
        public string BolumAdi { get; set; }
        public Nullable<int> FakulteID { get; set; }
    
        public virtual Fakulteler Fakulteler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dersler> Dersler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogrenciler> Ogrenciler { get; set; }
    }
}
