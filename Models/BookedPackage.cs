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
    
    public partial class BookedPackage
    {
        public string S_UserID { get; set; }
        public string PackageID { get; set; }
        public string CheckInDate { get; set; }
        public int NoOfPerson { get; set; }
        public Nullable<int> TotalPrice { get; set; }
    
        public virtual PackageInfo PackageInfo { get; set; }
        public virtual SingleUserLog SingleUserLog { get; set; }
    }
}
