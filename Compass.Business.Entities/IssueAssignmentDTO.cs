namespace Compass.Business.Entities
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class IssueAssignmentDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IssueId { get; set; }
        [DataMember]
        public int AssignedBy { get; set; }
        [DataMember]
        public string AssignedByDisplay { get; set; }
        [DataMember]
        public int AssignedTo { get; set; }
        [DataMember]
        public string AssignedToDisplay { get; set; }
        [DataMember]
        public System.DateTime AssignedOn { get; set; }
        [DataMember]
        public bool IsCurrent { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public System.DateTime CreatedOn { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
