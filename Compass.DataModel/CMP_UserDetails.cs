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
    
    public partial class CMP_UserDetails
    {
        public CMP_UserDetails()
        {
            this.CMP_IssueActivityDetails = new HashSet<CMP_IssueActivityDetails>();
            this.CMP_IssueAssignmentDetails = new HashSet<CMP_IssueAssignmentDetails>();
            this.CMP_IssueAssignmentDetails1 = new HashSet<CMP_IssueAssignmentDetails>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public int RoleId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<CMP_IssueActivityDetails> CMP_IssueActivityDetails { get; set; }
        public virtual ICollection<CMP_IssueAssignmentDetails> CMP_IssueAssignmentDetails { get; set; }
        public virtual ICollection<CMP_IssueAssignmentDetails> CMP_IssueAssignmentDetails1 { get; set; }
        public virtual CMP_RoleMaster CMP_RoleMaster { get; set; }
    }
}
