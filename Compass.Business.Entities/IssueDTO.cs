namespace Compass.Business.Entities
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class IssueDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IssueType { get; set; }
        [DataMember]
        public string ExternalId { get; set; }
        [DataMember]
        public string Summary { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public string Status { get; set; }
        public int StatusId { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public System.DateTime CreatedOn { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        [DataMember]
        public int TenantId { get; set; }
        [DataMember]
        public string TenantName { get; set; }
    }
}
