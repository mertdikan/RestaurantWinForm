//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adisyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adisyon()
        {
            this.AdisyonOdemeDetay = new HashSet<AdisyonOdemeDetay>();
            this.AdisyonSiparisDetay = new HashSet<AdisyonSiparisDetay>();
        }
    
        public int AdisyonID { get; set; }
        public System.DateTime Tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdisyonOdemeDetay> AdisyonOdemeDetay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdisyonSiparisDetay> AdisyonSiparisDetay { get; set; }
    }
}
