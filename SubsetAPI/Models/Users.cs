//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SubsetAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.Enrollment = new HashSet<Enrollment>();
        }
    
        public string id { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string type { get; set; }
        public string cohort { get; set; }
    
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
