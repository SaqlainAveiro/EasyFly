//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyFly.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class PackageInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PackageInfo()
        {
            this.BookedPackages = new HashSet<BookedPackage>();
            this.PassengerFlights = new HashSet<PassengerFlight>();
        }

        [Required]
        [Display(Name = "Package ID")]
        [DataType(DataType.Text)]
        public string PackageID { get; set; }

        [Required]
        [Display(Name = "Hotel Name")]
        [DataType(DataType.Text)]
        public string HotelName { get; set; }

        [Display(Name = "Hotel Photo")]
        [DataType(DataType.Text)]
        public string HotelImage { get; set; }

        [Display(Name = "Destination")]
        [DataType(DataType.Text)]
        public string Destination { get; set; }

        [Required]
        [Display(Name = "Package Sub-Description")]
        [DataType(DataType.Text)]
        public string PackageSubDesc { get; set; }

        [Required]
        [Display(Name = "Package Description")]
        [DataType(DataType.Text)]
        public string PackageDesc { get; set; }

        [Required]
        [Display(Name = "Package Price")]
        [DataType(DataType.Text)]
        public Nullable<int> PackagePrice { get; set; }


    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookedPackage> BookedPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassengerFlight> PassengerFlights { get; set; }
    }
}
