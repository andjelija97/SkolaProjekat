//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektniCentarSkole
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class KontaktOsoba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KontaktOsoba()
        {
            this.Mails = new HashSet<Mail>();
            this.Telefons = new HashSet<Telefon>();
        }
    
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Ime ne sme sadrzati cifre ni specijalne znakove")]
        public string Ime { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Prezime ne sme sadrzati cifre ni specijalne znakove")]
        public string Prezime { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [RegularExpression("^[A-Za-z]*$", ErrorMessage = "Radno mesto ne sme sadrzati cifre ni specijalne znakove")]
        public string RadnoMesto { get; set; }

        public Nullable<int> IdSkola { get; set; }
    
        public virtual Skola Skola { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mail> Mails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefon> Telefons { get; set; }
    }
}
