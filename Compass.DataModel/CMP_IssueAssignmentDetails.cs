//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compass.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMP_IssueAssignmentDetails
    {
        public int Id { get; set; }
        public int IssueId { get; set; }
        public int AssignedBy { get; set; }
        public int AssignedTo { get; set; }
        public System.DateTime AssignedOn { get; set; }
        public bool IsCurrent { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual CMP_IssueDetails CMP_IssueDetails { get; set; }
        public virtual CMP_UserDetails CMP_UserDetails { get; set; }
        public virtual CMP_UserDetails CMP_UserDetails1 { get; set; }
    }
}
