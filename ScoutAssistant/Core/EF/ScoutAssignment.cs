//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoutAssistant.Core.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScoutAssignment
    {
        public int ScoutId { get; set; }
        public int SchoolId { get; set; }
        public int Priority { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Deleted { get; set; }
    
        public virtual School School { get; set; }
        public virtual Scout Scout { get; set; }
    }
}