//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vertibrates.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class project_table2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public Nullable<int> projectID { get; set; }
    
        public virtual project_table project_table { get; set; }
    }
}
