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

    public partial class AircraftInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AircraftInfo()
        {
            this.FlightInfoes = new HashSet<FlightInfo>();
        }

        [Required]
        [Display(Name = "Aircraft ID")]
        [DataType(DataType.Text)]
        public string AC_ID { get; set; }

        [Required]
        [Display(Name = "Aircraft Model")]
        [DataType(DataType.Text)]
        public string AC_Name { get; set; }

        [Required]
        [Display(Name = "Capacity (Passenger)")]
        [DataType(DataType.Text)]
        public Nullable<int> PassengerCapacity { get; set; }

        [Required]
        [Display(Name = "Capacity (Cargo)")]
        [DataType(DataType.Text)]
        public Nullable<int> CargoCapacity { get; set; }

        [Required]
        [Display(Name = "Aircraft Type")]
        [DataType(DataType.Text)]
        public string AC_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightInfo> FlightInfoes { get; set; }
    }
}
